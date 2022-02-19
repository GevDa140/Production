using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Production.User
{
    public partial class FormTracksUser : Form
    {
        public FormTracksUser()
        {
            InitializeComponent();
        }
        private static FormTracksUser f;

        public static FormTracksUser ftu
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormTracksUser();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

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
        void SelectTracks()
        {
            if (String.IsNullOrEmpty(textBoxArtist.Text))
            {
                MessageBox.Show("Обязательно введите псевдоним музыканта", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlName = "'" + textBoxArtist.Text + "'";
            string sqlSelect = $"SELECT * FROM Трек WHERE PK_FK_Псевдоним={sqlName}";
            try
            {
                dataGridViewTrack.DataSource = FillDataGridView(sqlSelect);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void CheckSelect()
        {
            bool auth = false;
            if
           (String.IsNullOrEmpty(textBoxArtist.Text)) /*||
           (String.IsNullOrEmpty(textBoxCode.Text)))*/
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
                SelectTracks();
            else
            {
                MessageBox.Show("Проверьте правильность ввода своего псевдонима и кодового слова", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }


        void CheckIns()
        {
            bool auth = false;
            if
           (String.IsNullOrEmpty(textBoxArtist.Text) ||
           (String.IsNullOrEmpty(textBoxTrack.Text) ||
           (String.IsNullOrEmpty(textBoxGenre.Text) ||
           (String.IsNullOrEmpty(textBoxLyrics.Text) ||
           (String.IsNullOrEmpty(textBoxCode.Text))))))
            {
                MessageBox.Show("Обязательно заполните все данные!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                SQLInsert();
            else
            {
                MessageBox.Show("Проверьте правильность ввода своего псевдонима и кодового слова", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        void SQLInsert()
        {
            string sqlInsert = @"INSERT INTO Трек (PK_Название_Трека, PK_FK_Псевдоним, FK_Название_Секвенсора, FK_Название_Сервиса, Текст, Жанр)
 VALUES (@Title, @Name, @Seq, @Serv, @Lyr, @Gen)";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.SoundProdConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlInsert;
            command.Parameters.AddWithValue("@Title", textBoxTrack.Text);
            command.Parameters.AddWithValue("@Name", textBoxArtist.Text);
            command.Parameters.AddWithValue("@Seq", listBoxSeq.GetItemText(listBoxSeq.SelectedItem));
            command.Parameters.AddWithValue("@Serv", listBoxServ.GetItemText(listBoxServ.SelectedItem));
            command.Parameters.AddWithValue("@Lyr", textBoxLyrics.Text);
            command.Parameters.AddWithValue("@Gen", textBoxGenre.Text);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Круто! Надеемся, что Ваш трек разорвёт все известные и неизвестные чарты!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса.\n" + err.Message,
               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            connection.Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            CheckSelect();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CheckIns();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.сервисTableAdapter.FillBy(this.soundProdDataSet.Сервис);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillSeqToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.секвенсорTableAdapter.FillSeq(this.soundProdDataSet.Секвенсор);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void FormTracksUser_Load(object sender, EventArgs e)
        {
            fillByToolStripButton_Click(sender, e);
            fillSeqToolStripButton_Click(sender, e);
        }
    }
}
