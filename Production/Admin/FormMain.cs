using System;
using System.Windows.Forms;
using Production.Admin;
using Production.Properties;

namespace Production
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?",
            "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) !=
            DialogResult.Yes;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,КИБЭВС,Геворгян Давид Размикович,728-2,2021", "О программе",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }

        private void toolStripButtonServices_Click(object sender, EventArgs e)
        {
            FormServices.fs.ShowForm();
        }

        private void toolStripButtonSequencers_Click(object sender, EventArgs e)
        {
            FormSequencersList.fs.ShowForm();
        }

        private void toolStripButtonAssociations_Click(object sender, EventArgs e)
        {
            FormAssociations.fa.ShowForm();
        }

        private void toolStripButtonTracks_Click(object sender, EventArgs e)
        {
            FormTracks.ft.ShowForm();
        }

        private void toolStripButtonSQL_Click(object sender, EventArgs e)
        {
            FormSQL.fs.ShowForm();
        }
    }
}
