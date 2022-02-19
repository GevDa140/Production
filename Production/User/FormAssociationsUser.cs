using System;
using System.Data;
using System.Windows.Forms;

namespace Production.User
{
    public partial class FormAssociationsUser : Form
    {
        public FormAssociationsUser()
        {
            InitializeComponent();
        }
        private static FormAssociationsUser f;

        public static FormAssociationsUser fau
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAssociationsUser();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void FormAssociationsUser_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Объединение". При необходимости она может быть перемещена или удалена.
            this.объединениеTableAdapter.Fill(this.soundProdDataSet.Объединение);

        }

        string GetSelectedFieldName()
        {
            return объединениеDataGridView.Columns[объединениеDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                объединениеBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                объединениеBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких объединений нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                объединениеBindingSource.Position = 0;
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
                        объединениеBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                объединениеBindingSource.Filter = "";
            if (объединениеBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                объединениеBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }
        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        string assCurrent = "";
        public string ShowSelectForm(string serv)
        {
            toolStripButtonOK.Visible = true;
            assCurrent = serv;
            if (ShowDialog() == DialogResult.OK)
                return
                (string)((DataRowView)объединениеBindingSource.Current)["PK_Название_Объединения"];
            else
                return "";
        }

        private void FormAssociationsUser_Shown(object sender, EventArgs e)
        {
            объединениеBindingSource.Position =
объединениеBindingSource.Find("PK_Название_Объединения", assCurrent);
        }

    }
}
