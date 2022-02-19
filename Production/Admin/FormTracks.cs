using Production.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace Production
{
    public partial class FormTracks : Form
    {
        public FormTracks()
        {
            InitializeComponent();
        }

        private static FormTracks f;

        public static FormTracks ft
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormTracks();
                return f;
            }
        }

        private void трекBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.трекBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.soundProdDataSet);

        }

        private void FormTracks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "soundProdDataSet.Трек". При необходимости она может быть перемещена или удалена.
            this.трекTableAdapter.Fill(this.soundProdDataSet.Трек);

        }

        private void buttonSequencors_Click(object sender, EventArgs e)
        {
            string seq = "";
            if
            (((DataRowView)трекBindingSource.Current)["FK_Название_Секвенсора"].ToString() !=
            "")
            {
                seq =
                (string)(((DataRowView)трекBindingSource.Current)["FK_Название_Секвенсора"]);
            }
            seq = FormSequencersList.fs.ShowSelectForm(seq);
            if (seq != "")
            {
                MessageBox.Show(seq);
                ((DataRowView)трекBindingSource.Current)["FK_Название_Секвенсора"]
                = seq;
                трекBindingSource.ResetCurrentItem();
                секвенсорTableAdapter.Fill(this.soundProdDataSet.Секвенсор);
            }
        }

        private void buttonServices_Click(object sender, EventArgs e)
        {
            string serv = "";
            if
            (((DataRowView)трекBindingSource.Current)["FK_Название_Сервиса"].ToString() !=
            "")
            {
                serv =
                (string)(((DataRowView)трекBindingSource.Current)["FK_Название_Сервиса"]);
            }
            serv = FormServices.fs.ShowSelectForm(serv);
            if (serv != "")
            {
                MessageBox.Show(serv);
                ((DataRowView)трекBindingSource.Current)["FK_Название_Сервиса"]
                = serv;
                трекBindingSource.ResetCurrentItem();
                сервисTableAdapter.Fill(this.soundProdDataSet.Сервис);
            }
        }

        private void buttonMusician_Click(object sender, EventArgs e)
        {
            string mus = "";
            if
            (((DataRowView)трекBindingSource.Current)["PK_FK_Псевдоним"].ToString() !=
            "")
            {
                mus =
                (string)(((DataRowView)трекBindingSource.Current)["PK_FK_Псевдоним"]);
            }
            mus = FormMusician.fm.ShowSelectForm(mus);
            if (mus != "")
            {
                MessageBox.Show(mus);
                ((DataRowView)трекBindingSource.Current)["PK_FK_Псевдоним"]
                = mus;
                трекBindingSource.ResetCurrentItem();
                музыкантTableAdapter.Fill(this.soundProdDataSet.Музыкант);
            }
        }


        public void ShowForm()
        {
            Show();
            Activate();
        }
    }
}
