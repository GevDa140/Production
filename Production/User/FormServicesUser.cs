using System;
using System.Data;
using System.Windows.Forms;

namespace Production.User
{
    public partial class FormServicesUser : Form
    {
        public FormServicesUser()
        {
            InitializeComponent();
        }
        private static FormServicesUser f;

        public static FormServicesUser fsu
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormServicesUser();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void FormServicesUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Сервис". При необходимости она может быть перемещена или удалена.
            this.сервисTableAdapter.Fill(this.soundProdDataSet.Сервис);

        }

        string GetSelectedFieldName()
        {
            return сервисDataGridView.Columns[сервисDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                сервисBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                сервисBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сервисов нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                сервисBindingSource.Position = 0;
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
                        сервисBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                сервисBindingSource.Filter = "";
            if (сервисBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                сервисBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        string servCurrent = "";
        public string ShowSelectForm(string serv)
        {
            toolStripButtonOK.Visible = true;
            servCurrent = serv;
            if (ShowDialog() == DialogResult.OK)
                return
                (string)((DataRowView)сервисBindingSource.Current)["PK_Название_Сервиса"];
            else
                return "";
        }

        private void FormSequencersList_Shown(object sender, EventArgs e)
        {
            сервисBindingSource.Position =
сервисBindingSource.Find("PK_Название_Сервиса", servCurrent);
        }

    }
}
