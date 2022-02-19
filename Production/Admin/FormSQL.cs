using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Production.Admin
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
        }

        private static FormSQL f;

        public static FormSQL fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        //объявляем метод, на вход подаем строку запроса, а возвращаем объект DataTable
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //SoundProdConnectionString – строка описания соединения с источником данных
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButtonAssociations_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT Музыкант.PK_Псевдоним, Объединение.PK_Название_Объединения, Объединение.Расположение, Музыкант.Популярность FROM Музыкант INNER JOIN Объединение ON Музыкант.FK_Название_Объединения = Объединение.PK_Название_Объединения");
        }

        private void radioButtonTracks_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView(@"SELECT        Трек.PK_Название_Трека, Трек.PK_FK_Псевдоним, Музыкант.FK_Название_Объединения, Трек.Жанр, Секвенсор.PK_Название_Секвенсора, Секвенсор.Расширение, Сервис.PK_Название_Сервиса
                        FROM Музыкант INNER JOIN
                        Трек ON Музыкант.PK_Псевдоним = Трек.PK_FK_Псевдоним INNER JOIN
                        Секвенсор ON Трек.FK_Название_Секвенсора = Секвенсор.PK_Название_Секвенсора INNER JOIN
                        Сервис ON Трек.FK_Название_Сервиса = Сервис.PK_Название_Сервиса");
        }

        private void radioButtonSequencers_CheckedChanged(object sender, EventArgs e)
        {
            dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Секвенсор");
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxMusician.Text))
            {
                MessageBox.Show("Обязательно укажите псевдоним необходимого музыканта.\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButtonDet_Associations.Checked)
                sqlSelect = @"SELECT m.PK_Псевдоним, m.Популярность, a.PK_Название_Объединения, a.Расположение
FROM Музыкант m, Объединение a
WHERE PK_Псевдоним LIKE @nickname AND
m.FK_Название_Объединения = a.PK_Название_Объединения
GROUP BY m.PK_Псевдоним, m.Популярность, a.PK_Название_Объединения, a.Расположение";
            else if (radioButtonDet_Tracks.Checked)
                sqlSelect = @"SELECT m.PK_Псевдоним, m.Популярность, t.PK_Название_Трека, t.Жанр
FROM Музыкант m, Трек t
WHERE PK_Псевдоним LIKE @nickname AND
m.PK_Псевдоним = t.PK_FK_Псевдоним
GROUP BY m.PK_Псевдоним, m.Популярность, t.PK_Название_Трека, t.Жанр";
            else
                sqlSelect = @"SELECT m.PK_Псевдоним, m.Популярность
FROM Музыкант m
WHERE PK_Псевдоним LIKE @nickname";
            if (checkBoxSort.Checked)
                sqlSelect += " ORDER BY Популярность asc";
            SqlConnection connection = new

SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@nickname", textBoxMusician.Text +
            "%");
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewS.DataSource = table;
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            dataGridViewMusician.DataSource = FillDataGridView("SELECT * FROM Музыкант");
        }

        void SQLInsert()
        {
            if
           (String.IsNullOrEmpty(textBoxPop.Text) ||
           (String.IsNullOrEmpty(textBoxRep.Text) ||
           (String.IsNullOrEmpty(textBoxAud.Text))))
            {
                MessageBox.Show("Обязательно введите псевдоним музыканта, популярность, репутацию и возраст аудитории", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlInsert = @"INSERT INTO Музыкант (PK_Псевдоним, FK_Название_Объединения, Популярность, Репутация, Билет, Образование, Аудитория, Кодовое_слово)
 VALUES (@Name, @Ass, @Pop, @Rep, @Cost, @Edu, @Aud, @Code)";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@Name", textBoxArtist.Text);
            command.Parameters.AddWithValue("@Ass", textBoxAss.Text);
            command.Parameters.AddWithValue("@Pop", textBoxPop.Text);
            command.Parameters.AddWithValue("@Rep", textBoxRep.Text);
            command.Parameters.AddWithValue("@Cost", textBoxCost.Text);
            command.Parameters.AddWithValue("@Edu", checkBoxEdu.Checked);
            command.Parameters.AddWithValue("@Aud", textBoxAud.Text);
            command.Parameters.AddWithValue("@Code", textBoxCode.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
            buttonSelect_Click(this, EventArgs.Empty);
        }

        void SQLUpdate()
        {
            if (String.IsNullOrEmpty(textBoxArtist.Text))
            {
                MessageBox.Show("Обязательно укажите псевдоним музыканта, для которой будете менять данные", "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }
            string sqlUpdate = "UPDATE Музыкант SET {0} Образование=@Edu WHERE PK_Псевдоним = @Name";
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBoxAss.Text))
                sqlValues += "FK_Название_Объединения=@Ass,";
            if (!String.IsNullOrEmpty(textBoxPop.Text))
                sqlValues += "Популярность=@Pop,";
            if (!String.IsNullOrEmpty(textBoxRep.Text))
                sqlValues += "Репутация=@Rep,";
            if (!String.IsNullOrEmpty(textBoxCost.Text))
                sqlValues += "Билет=@Cost,";
            if (!String.IsNullOrEmpty(textBoxAud.Text))
                sqlValues += "Аудитория=@Aud,";
            if (!String.IsNullOrEmpty(textBoxCode.Text))
                sqlValues += "Кодовое_слово=@Code,";
            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(textBoxAss.Text))
                command.Parameters.AddWithValue("@Ass", textBoxAss.Text);
            if (!String.IsNullOrEmpty(textBoxPop.Text))
                command.Parameters.AddWithValue("@Pop", textBoxPop.Text);
            if (!String.IsNullOrEmpty(textBoxRep.Text))
                command.Parameters.AddWithValue("@Rep", textBoxRep.Text);
            if (!String.IsNullOrEmpty(textBoxCost.Text))
                command.Parameters.AddWithValue("@Cost", textBoxCost.Text);
            if (!String.IsNullOrEmpty(textBoxAud.Text))
                command.Parameters.AddWithValue("@Aud", textBoxAud.Text);
            if (!String.IsNullOrEmpty(textBoxAud.Text))
                command.Parameters.AddWithValue("@Code", textBoxCode.Text);
            command.Parameters.AddWithValue("@Edu", checkBoxEdu.Checked);
            command.Parameters.AddWithValue("@Name", textBoxArtist.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            buttonSelect_Click(this, EventArgs.Empty);
        }
        void SQLDelete()
        {
            if (String.IsNullOrEmpty(textBoxArtist.Text))
            {
                MessageBox.Show("Обязательно укажите псевдоним музыканта, данные которого необходимо удалить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlDelete = @"DELETE FROM Музыкант WHERE PK_Псевдоним=@Name";
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlDelete;
            command.Parameters.AddWithValue("@Name", textBoxArtist.Text);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка удаления");
            }
            connection.Close();
            buttonSelect_Click(this, EventArgs.Empty);
        }


        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            {
                if (radioButtonInsert.Checked)
                    SQLInsert();
                else
                if (radioButtonUpdate.Checked)
                    SQLUpdate();
                else
                if (radioButtonDelete.Checked)
                    SQLDelete();
                else
                MessageBox.Show("Вы не выбрали действие", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
