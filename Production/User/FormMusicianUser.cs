using System;
using System.Windows.Forms;

namespace Production.User
{
    public partial class FormMusicianUser : Form
    {
        public FormMusicianUser()
        {
            InitializeComponent();
        }
        private static FormMusicianUser f;

        public static FormMusicianUser fmu
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMusicianUser();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void FormMusicianUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Сервис". При необходимости она может быть перемещена или удалена.
            try
            {
                this.музыкантTableAdapter.FillBy(this.soundProdDataSet.Музыкант);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        string GetSelectedFieldName()
        {
            return музыкантDataGridView.Columns[музыкантDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                музыкантBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                музыкантBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких музыкантов нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                музыкантBindingSource.Position = 0;
            }
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                if (toolStripTextBoxFind.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        музыкантBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                музыкантBindingSource.Filter = "";
            if (музыкантBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                музыкантBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.музыкантTableAdapter.Fill(this.soundProdDataSet.Музыкант);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.музыкантTableAdapter.FillBy(this.soundProdDataSet.Музыкант);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}