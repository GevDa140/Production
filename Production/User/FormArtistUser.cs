using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Production.User
{
    public partial class FormArtistUser : Form
    {
        public FormArtistUser()
        {
            InitializeComponent();
        }

        private static FormArtistUser f;

        public static FormArtistUser fau
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormArtistUser();
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

        void CheckSelect()
        {
            bool auth = false;
            if
           (String.IsNullOrEmpty(textBoxArtist.Text))
            {
                MessageBox.Show("Обязательно введите Псевдоним музыканта!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if
                (String.IsNullOrEmpty(textBoxCode.Text))
            {
                MessageBox.Show("Обязательно введите Кодовое слово!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new
SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            SqlCommand command = connection.CreateCommand();
            string sqlCheck = "SELECT * FROM Музыкант WHERE PK_Псевдоним = @log AND Кодовое_слово=@pass";
            command.CommandText = sqlCheck;
            command.Parameters.AddWithValue("@log", textBoxArtist.Text);
            command.Parameters.AddWithValue("@pass", textBoxCode.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count > 0)
                auth = true;
            connection.Close();
            if (auth)
                SelectMus();
            else
            {
                MessageBox.Show("Проверьте правильность ввода своего псевдонима и кодового слова", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        void SelectMus()
        {
            string sqlName = "'" + textBoxArtist.Text + "'";
            string sqlSelect = $"SELECT * FROM Музыкант WHERE PK_Псевдоним={sqlName}";
            try
            {
                dataGridViewMusician.DataSource = FillDataGridView(sqlSelect);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        void SQLInsert()
        {
            if
                (String.IsNullOrEmpty(textBoxPop.Text) ||
                (String.IsNullOrEmpty(textBoxRep.Text) ||
                (String.IsNullOrEmpty(textBoxAud.Text) ||
                (String.IsNullOrEmpty(textBoxCode.Text)))))
            {
                MessageBox.Show("Обязательно введите псевдоним музыканта, популярность, репутацию, возраст аудитории и кодовое слово", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            command.Parameters.AddWithValue("@Ass", listBoxAss.GetItemText(listBoxAss.SelectedItem));
            command.Parameters.AddWithValue("@Pop", textBoxPop.Text);
            command.Parameters.AddWithValue("@Rep", textBoxRep.Text);
            command.Parameters.AddWithValue("@Cost", textBoxCost.Text);
            command.Parameters.AddWithValue("@Edu", checkBoxEdu.Checked);
            command.Parameters.AddWithValue("@Aud", textBoxAud.Text);
            command.Parameters.AddWithValue("@Code", textBoxCode.Text);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Добро пожаловать! Рады видеть Вас в нашей большой и дружной семье!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SQLInsert();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            CheckSelect();
        }


        private void FormArtistUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Объединение". При необходимости она может быть перемещена или удалена.
            this.объединениеTableAdapter.Fill(this.soundProdDataSet.Объединение);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.объединениеTableAdapter.FillBy(this.soundProdDataSet.Объединение);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
