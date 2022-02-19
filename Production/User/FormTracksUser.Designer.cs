
namespace Production.User
{
    partial class FormTracksUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTracksUser));
            this.dataGridViewTrack = new System.Windows.Forms.DataGridView();
            this.panelMusicians = new System.Windows.Forms.Panel();
            this.listBoxSeq = new System.Windows.Forms.ListBox();
            this.секвенсорBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soundProdDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soundProdDataSet = new Production.SoundProdDataSet();
            this.listBoxServ = new System.Windows.Forms.ListBox();
            this.сервисBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.labelAud = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelRep = new System.Windows.Forms.Label();
            this.textBoxLyrics = new System.Windows.Forms.TextBox();
            this.textBoxTrack = new System.Windows.Forms.TextBox();
            this.labelPop = new System.Windows.Forms.Label();
            this.labelAss = new System.Windows.Forms.Label();
            this.сервисTableAdapter = new Production.SoundProdDataSetTableAdapters.СервисTableAdapter();
            this.трекBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.трекTableAdapter = new Production.SoundProdDataSetTableAdapters.ТрекTableAdapter();
            this.tableAdapterManager = new Production.SoundProdDataSetTableAdapters.TableAdapterManager();
            this.секвенсорTableAdapter = new Production.SoundProdDataSetTableAdapters.СеквенсорTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.fillSeqToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillSeqToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrack)).BeginInit();
            this.panelMusicians.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.секвенсорBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сервисBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трекBindingSource)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.fillSeqToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTrack
            // 
            this.dataGridViewTrack.AllowUserToAddRows = false;
            this.dataGridViewTrack.AllowUserToDeleteRows = false;
            this.dataGridViewTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTrack.Location = new System.Drawing.Point(0, 191);
            this.dataGridViewTrack.Name = "dataGridViewTrack";
            this.dataGridViewTrack.ReadOnly = true;
            this.dataGridViewTrack.Size = new System.Drawing.Size(905, 282);
            this.dataGridViewTrack.TabIndex = 5;
            // 
            // panelMusicians
            // 
            this.panelMusicians.Controls.Add(this.listBoxSeq);
            this.panelMusicians.Controls.Add(this.listBoxServ);
            this.panelMusicians.Controls.Add(this.textBoxCode);
            this.panelMusicians.Controls.Add(this.label1);
            this.panelMusicians.Controls.Add(this.buttonAdd);
            this.panelMusicians.Controls.Add(this.textBoxArtist);
            this.panelMusicians.Controls.Add(this.label2);
            this.panelMusicians.Controls.Add(this.buttonSelect);
            this.panelMusicians.Controls.Add(this.labelAud);
            this.panelMusicians.Controls.Add(this.textBoxGenre);
            this.panelMusicians.Controls.Add(this.labelCost);
            this.panelMusicians.Controls.Add(this.labelRep);
            this.panelMusicians.Controls.Add(this.textBoxLyrics);
            this.panelMusicians.Controls.Add(this.textBoxTrack);
            this.panelMusicians.Controls.Add(this.labelPop);
            this.panelMusicians.Controls.Add(this.labelAss);
            this.panelMusicians.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMusicians.Location = new System.Drawing.Point(0, 0);
            this.panelMusicians.Name = "panelMusicians";
            this.panelMusicians.Size = new System.Drawing.Size(905, 191);
            this.panelMusicians.TabIndex = 0;
            // 
            // listBoxSeq
            // 
            this.listBoxSeq.DataSource = this.секвенсорBindingSource;
            this.listBoxSeq.DisplayMember = "PK_Название_Секвенсора";
            this.listBoxSeq.FormattingEnabled = true;
            this.listBoxSeq.Location = new System.Drawing.Point(335, 38);
            this.listBoxSeq.Name = "listBoxSeq";
            this.listBoxSeq.Size = new System.Drawing.Size(120, 43);
            this.listBoxSeq.TabIndex = 4;
            // 
            // секвенсорBindingSource
            // 
            this.секвенсорBindingSource.DataMember = "Секвенсор";
            this.секвенсорBindingSource.DataSource = this.soundProdDataSetBindingSource;
            // 
            // soundProdDataSetBindingSource
            // 
            this.soundProdDataSetBindingSource.DataSource = this.soundProdDataSet;
            this.soundProdDataSetBindingSource.Position = 0;
            // 
            // soundProdDataSet
            // 
            this.soundProdDataSet.DataSetName = "SoundProdDataSet";
            this.soundProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listBoxServ
            // 
            this.listBoxServ.DataSource = this.сервисBindingSource;
            this.listBoxServ.DisplayMember = "PK_Название_Сервиса";
            this.listBoxServ.FormattingEnabled = true;
            this.listBoxServ.Location = new System.Drawing.Point(114, 38);
            this.listBoxServ.Name = "listBoxServ";
            this.listBoxServ.Size = new System.Drawing.Size(120, 43);
            this.listBoxServ.TabIndex = 3;
            // 
            // сервисBindingSource
            // 
            this.сервисBindingSource.DataMember = "Сервис";
            this.сервисBindingSource.DataSource = this.soundProdDataSetBindingSource;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(114, 93);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(317, 20);
            this.textBoxCode.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кодовое слово";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(114, 122);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 37);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Добавить трек";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(114, 12);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(120, 20);
            this.textBoxArtist.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Музыкант";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(331, 122);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(100, 37);
            this.buttonSelect.TabIndex = 8;
            this.buttonSelect.Text = "Показать треки музыканта";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // labelAud
            // 
            this.labelAud.AutoSize = true;
            this.labelAud.Location = new System.Drawing.Point(64, 45);
            this.labelAud.Name = "labelAud";
            this.labelAud.Size = new System.Drawing.Size(44, 13);
            this.labelAud.TabIndex = 8;
            this.labelAud.Text = "Сервис";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(504, 12);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(100, 20);
            this.textBoxGenre.TabIndex = 2;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(462, 15);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(36, 13);
            this.labelCost.TabIndex = 5;
            this.labelCost.Text = "Жанр";
            // 
            // labelRep
            // 
            this.labelRep.AutoSize = true;
            this.labelRep.Location = new System.Drawing.Point(267, 45);
            this.labelRep.Name = "labelRep";
            this.labelRep.Size = new System.Drawing.Size(62, 13);
            this.labelRep.TabIndex = 4;
            this.labelRep.Text = "Секвенсор";
            // 
            // textBoxLyrics
            // 
            this.textBoxLyrics.Location = new System.Drawing.Point(504, 42);
            this.textBoxLyrics.Multiline = true;
            this.textBoxLyrics.Name = "textBoxLyrics";
            this.textBoxLyrics.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLyrics.Size = new System.Drawing.Size(248, 67);
            this.textBoxLyrics.TabIndex = 5;
            // 
            // textBoxTrack
            // 
            this.textBoxTrack.Location = new System.Drawing.Point(335, 11);
            this.textBoxTrack.Name = "textBoxTrack";
            this.textBoxTrack.Size = new System.Drawing.Size(120, 20);
            this.textBoxTrack.TabIndex = 1;
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(461, 45);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(37, 13);
            this.labelPop.TabIndex = 1;
            this.labelPop.Text = "Текст";
            // 
            // labelAss
            // 
            this.labelAss.AutoSize = true;
            this.labelAss.Location = new System.Drawing.Point(240, 15);
            this.labelAss.Name = "labelAss";
            this.labelAss.Size = new System.Drawing.Size(89, 13);
            this.labelAss.TabIndex = 0;
            this.labelAss.Text = "Название трека";
            // 
            // сервисTableAdapter
            // 
            this.сервисTableAdapter.ClearBeforeFill = true;
            // 
            // трекBindingSource
            // 
            this.трекBindingSource.DataMember = "Трек";
            this.трекBindingSource.DataSource = this.soundProdDataSet;
            // 
            // трекTableAdapter
            // 
            this.трекTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Production.SoundProdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МузыкантTableAdapter = null;
            this.tableAdapterManager.ОбъединениеTableAdapter = null;
            this.tableAdapterManager.СеквенсорTableAdapter = null;
            this.tableAdapterManager.СервисTableAdapter = null;
            this.tableAdapterManager.ТрекTableAdapter = this.трекTableAdapter;
            // 
            // секвенсорTableAdapter
            // 
            this.секвенсорTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 191);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(905, 25);
            this.fillByToolStrip.TabIndex = 6;
            this.fillByToolStrip.Text = "fillByToolStrip";
            this.fillByToolStrip.Visible = false;
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // fillSeqToolStrip
            // 
            this.fillSeqToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillSeqToolStripButton});
            this.fillSeqToolStrip.Location = new System.Drawing.Point(0, 191);
            this.fillSeqToolStrip.Name = "fillSeqToolStrip";
            this.fillSeqToolStrip.Size = new System.Drawing.Size(905, 25);
            this.fillSeqToolStrip.TabIndex = 7;
            this.fillSeqToolStrip.Text = "fillSeqToolStrip";
            this.fillSeqToolStrip.Visible = false;
            // 
            // fillSeqToolStripButton
            // 
            this.fillSeqToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillSeqToolStripButton.Name = "fillSeqToolStripButton";
            this.fillSeqToolStripButton.Size = new System.Drawing.Size(45, 22);
            this.fillSeqToolStripButton.Text = "FillSeq";
            this.fillSeqToolStripButton.Click += new System.EventHandler(this.fillSeqToolStripButton_Click);
            // 
            // FormTracksUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 473);
            this.Controls.Add(this.fillSeqToolStrip);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridViewTrack);
            this.Controls.Add(this.panelMusicians);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTracksUser";
            this.Text = "Добавить свой трек";
            this.Load += new System.EventHandler(this.FormTracksUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrack)).EndInit();
            this.panelMusicians.ResumeLayout(false);
            this.panelMusicians.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.секвенсорBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сервисBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трекBindingSource)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.fillSeqToolStrip.ResumeLayout(false);
            this.fillSeqToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTrack;
        private System.Windows.Forms.Panel panelMusicians;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label labelAud;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelRep;
        private System.Windows.Forms.TextBox textBoxLyrics;
        private System.Windows.Forms.TextBox textBoxTrack;
        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelAss;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label1;
        private SoundProdDataSetTableAdapters.СервисTableAdapter сервисTableAdapter;
        private System.Windows.Forms.BindingSource трекBindingSource;
        private SoundProdDataSet soundProdDataSet;
        private SoundProdDataSetTableAdapters.ТрекTableAdapter трекTableAdapter;
        private SoundProdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private SoundProdDataSetTableAdapters.СеквенсорTableAdapter секвенсорTableAdapter;
        private System.Windows.Forms.ListBox listBoxServ;
        private System.Windows.Forms.BindingSource сервисBindingSource;
        private System.Windows.Forms.BindingSource soundProdDataSetBindingSource;
        private System.Windows.Forms.ListBox listBoxSeq;
        private System.Windows.Forms.BindingSource секвенсорBindingSource;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.ToolStrip fillSeqToolStrip;
        private System.Windows.Forms.ToolStripButton fillSeqToolStripButton;
    }
}