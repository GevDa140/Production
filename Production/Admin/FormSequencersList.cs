using System;
using System.Data;
using System.Windows.Forms;

namespace Production
{
    public partial class FormSequencersList : Form
    {
        public FormSequencersList()
        {
            InitializeComponent();
        }

        private void секвенсорBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.секвенсорBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.soundProdDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FormSequencersList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Секвенсор". При необходимости она может быть перемещена или удалена.
            this.секвенсорTableAdapter.Fill(this.soundProdDataSet.Секвенсор);

        }

        private static FormSequencersList f;
        public static FormSequencersList fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSequencersList();
                return f;
            }
        }
        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            секвенсорBindingSource.Position = 0;
            Show();
            Activate();
        }

        string GetSelectedFieldName()
        {
            return секвенсорDataGridView.Columns[секвенсорDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                секвенсорBindingSource.Find(GetSelectedFieldName(),
                toolStripTextBoxFind.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                секвенсорBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких секвенсоров нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                секвенсорBindingSource.Position = 0;
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
                        секвенсорBindingSource.Filter =
                        GetSelectedFieldName() + "='" + toolStripTextBoxFind.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                секвенсорBindingSource.Filter = "";
            if (секвенсорBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                секвенсорBindingSource.Filter = "";
                checkBoxFind.Checked = false;
            }
        }

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        string seqCurrent = "";
        public string ShowSelectForm(string seq)
        {
            toolStripButtonOK.Visible = true;
            seqCurrent = seq;
            if (ShowDialog() == DialogResult.OK)
                return
                (string)((DataRowView)секвенсорBindingSource.Current)["PK_Название_Секвенсора"];
            else
                return "";
        }

        private void FormSequencersList_Shown(object sender, EventArgs e)
        {
            секвенсорBindingSource.Position =
секвенсорBindingSource.Find("PK_Название_Секвенсора", seqCurrent);
        }
    }
}
