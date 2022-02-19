using System;
using System.Windows.Forms;

namespace Production.User
{
    public partial class FormMainUser : Form
    {
        public FormMainUser()
        {
            InitializeComponent();
        }

        private void FormMainUser_Load(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMainUser_FormClosing(object sender, FormClosingEventArgs e)
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

        private void toolStripButtonServices_Click(object sender, EventArgs e)
        {
            FormServicesUser.fsu.ShowForm();
        }

        private void toolStripButtonSequencers_Click(object sender, EventArgs e)
        {
            FormSequencersListUser.fsu.ShowForm();
        }

        private void toolStripButtonAssociations_Click(object sender, EventArgs e)
        {
            FormAssociationsUser.fau.ShowForm();
        }

        private void toolStripButtonMusicians_Click(object sender, EventArgs e)
        {
            FormMusicianUser.fmu.ShowForm();
        }

        private void toolStripButtonTrack_Click(object sender, EventArgs e)
        {
            FormTracksUser.ftu.ShowForm();
        }

        private void toolStripButtonArtist_Click(object sender, EventArgs e)
        {
            FormArtistUser.fau.ShowForm();
        }
    }
}
