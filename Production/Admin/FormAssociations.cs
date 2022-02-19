using System;
using System.Windows.Forms;

namespace Production
{
    public partial class FormAssociations : Form
    {
        public FormAssociations()
        {
            InitializeComponent();
        }

        private void объединениеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.объединениеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.soundProdDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void musicianBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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

        private void FormAssociations_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Музыкант". При необходимости она может быть перемещена или удалена.
            this.музыкантTableAdapter.Fill(this.soundProdDataSet.Музыкант);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet1.Музыкант". При необходимости она может быть перемещена или удалена.
            this.музыкантTableAdapter.Fill(this.soundProdDataSet1.Музыкант);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Музыкант". При необходимости она может быть перемещена или удалена.
            this.музыкантTableAdapter.Fill(this.soundProdDataSet.Музыкант);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Музыкант". При необходимости она может быть перемещена или удалена.
            this.музыкантTableAdapter.Fill(this.soundProdDataSet.Музыкант);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Объединение". При необходимости она может быть перемещена или удалена.
            this.объединениеTableAdapter.Fill(this.soundProdDataSet.Объединение);

        }

        static FormAssociations f;
        static public FormAssociations fa
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormAssociations();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return музыкантDataGridView.Columns[музыкантDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                MessageBox.Show("Таких объединений нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                музыкантBindingSource.Position = 0;
            }
        }
    }
}
