using System;
using System.Data;
using System.Windows.Forms;

namespace Production.Admin
{
    public partial class FormMusician : Form
    {
        public FormMusician()
        {
            InitializeComponent();
        }

        private void музыкантBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.музыкантBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.soundProdDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void FormMusician_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Музыкант". При необходимости она может быть перемещена или удалена.
            this.музыкантTableAdapter.Fill(this.soundProdDataSet.Музыкант);

        }

        private static FormMusician f;

        public static FormMusician fm
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormMusician();
                return f;
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
                (string)((DataRowView)музыкантBindingSource.Current)["PK_Псевдоним"];
            else
                return "";
        }

        private void FormMusician_Shown(object sender, EventArgs e)
        {
            музыкантBindingSource.Position = музыкантBindingSource.Find("PK_Псевдоним", servCurrent);
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

    }
}
