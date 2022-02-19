
namespace Production.Admin
{
    partial class FormSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSQL));
            this.tabControlSQL = new System.Windows.Forms.TabControl();
            this.tabPageQueries = new System.Windows.Forms.TabPage();
            this.dataGridViewSelect = new System.Windows.Forms.DataGridView();
            this.groupBoxSelect = new System.Windows.Forms.GroupBox();
            this.radioButtonTracks = new System.Windows.Forms.RadioButton();
            this.radioButtonSequencers = new System.Windows.Forms.RadioButton();
            this.radioButtonAssociations = new System.Windows.Forms.RadioButton();
            this.tabPageSelect = new System.Windows.Forms.TabPage();
            this.dataGridViewS = new System.Windows.Forms.DataGridView();
            this.groupBoxMusician = new System.Windows.Forms.GroupBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.groupBoxDet = new System.Windows.Forms.GroupBox();
            this.radioButtonNoDet = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Tracks = new System.Windows.Forms.RadioButton();
            this.radioButtonDet_Associations = new System.Windows.Forms.RadioButton();
            this.textBoxMusician = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageDML = new System.Windows.Forms.TabPage();
            this.dataGridViewMusician = new System.Windows.Forms.DataGridView();
            this.panelMusicians = new System.Windows.Forms.Panel();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.checkBoxEdu = new System.Windows.Forms.CheckBox();
            this.textBoxAud = new System.Windows.Forms.TextBox();
            this.labelAud = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxRep = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelRep = new System.Windows.Forms.Label();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.textBoxAss = new System.Windows.Forms.TextBox();
            this.labelPop = new System.Windows.Forms.Label();
            this.labelAss = new System.Windows.Forms.Label();
            this.groupBoxDML = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonDelete = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdate = new System.Windows.Forms.RadioButton();
            this.radioButtonInsert = new System.Windows.Forms.RadioButton();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.buttonExecuteDML = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.soundProdDataSet = new Production.SoundProdDataSet();
            this.soundProdDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soundProdDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlSQL.SuspendLayout();
            this.tabPageQueries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).BeginInit();
            this.groupBoxSelect.SuspendLayout();
            this.tabPageSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).BeginInit();
            this.groupBoxMusician.SuspendLayout();
            this.groupBoxDet.SuspendLayout();
            this.tabPageDML.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusician)).BeginInit();
            this.panelMusicians.SuspendLayout();
            this.groupBoxDML.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlSQL
            // 
            this.tabControlSQL.Controls.Add(this.tabPageQueries);
            this.tabControlSQL.Controls.Add(this.tabPageSelect);
            this.tabControlSQL.Controls.Add(this.tabPageDML);
            this.tabControlSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSQL.Location = new System.Drawing.Point(0, 0);
            this.tabControlSQL.Name = "tabControlSQL";
            this.tabControlSQL.SelectedIndex = 0;
            this.tabControlSQL.Size = new System.Drawing.Size(962, 565);
            this.tabControlSQL.TabIndex = 0;
            // 
            // tabPageQueries
            // 
            this.tabPageQueries.Controls.Add(this.dataGridViewSelect);
            this.tabPageQueries.Controls.Add(this.groupBoxSelect);
            this.tabPageQueries.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueries.Name = "tabPageQueries";
            this.tabPageQueries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQueries.Size = new System.Drawing.Size(954, 539);
            this.tabPageQueries.TabIndex = 0;
            this.tabPageQueries.Text = "Запросы по данным";
            this.tabPageQueries.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSelect
            // 
            this.dataGridViewSelect.AllowUserToOrderColumns = true;
            this.dataGridViewSelect.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSelect.Location = new System.Drawing.Point(3, 103);
            this.dataGridViewSelect.Name = "dataGridViewSelect";
            this.dataGridViewSelect.Size = new System.Drawing.Size(948, 433);
            this.dataGridViewSelect.TabIndex = 1;
            // 
            // groupBoxSelect
            // 
            this.groupBoxSelect.Controls.Add(this.radioButtonTracks);
            this.groupBoxSelect.Controls.Add(this.radioButtonSequencers);
            this.groupBoxSelect.Controls.Add(this.radioButtonAssociations);
            this.groupBoxSelect.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSelect.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSelect.Name = "groupBoxSelect";
            this.groupBoxSelect.Size = new System.Drawing.Size(948, 100);
            this.groupBoxSelect.TabIndex = 0;
            this.groupBoxSelect.TabStop = false;
            this.groupBoxSelect.Text = "Запросы по данным";
            // 
            // radioButtonTracks
            // 
            this.radioButtonTracks.AutoSize = true;
            this.radioButtonTracks.Location = new System.Drawing.Point(274, 47);
            this.radioButtonTracks.Name = "radioButtonTracks";
            this.radioButtonTracks.Size = new System.Drawing.Size(56, 17);
            this.radioButtonTracks.TabIndex = 2;
            this.radioButtonTracks.TabStop = true;
            this.radioButtonTracks.Text = "Треки";
            this.radioButtonTracks.UseVisualStyleBackColor = true;
            this.radioButtonTracks.CheckedChanged += new System.EventHandler(this.radioButtonTracks_CheckedChanged);
            // 
            // radioButtonSequencers
            // 
            this.radioButtonSequencers.AutoSize = true;
            this.radioButtonSequencers.Location = new System.Drawing.Point(180, 47);
            this.radioButtonSequencers.Name = "radioButtonSequencers";
            this.radioButtonSequencers.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSequencers.TabIndex = 1;
            this.radioButtonSequencers.TabStop = true;
            this.radioButtonSequencers.Text = "Секвенсоры";
            this.radioButtonSequencers.UseVisualStyleBackColor = true;
            this.radioButtonSequencers.CheckedChanged += new System.EventHandler(this.radioButtonSequencers_CheckedChanged);
            // 
            // radioButtonAssociations
            // 
            this.radioButtonAssociations.AutoSize = true;
            this.radioButtonAssociations.Location = new System.Drawing.Point(6, 47);
            this.radioButtonAssociations.Name = "radioButtonAssociations";
            this.radioButtonAssociations.Size = new System.Drawing.Size(168, 17);
            this.radioButtonAssociations.TabIndex = 0;
            this.radioButtonAssociations.TabStop = true;
            this.radioButtonAssociations.Text = "Музыканты в объединениях";
            this.radioButtonAssociations.UseVisualStyleBackColor = true;
            this.radioButtonAssociations.CheckedChanged += new System.EventHandler(this.radioButtonAssociations_CheckedChanged);
            // 
            // tabPageSelect
            // 
            this.tabPageSelect.Controls.Add(this.dataGridViewS);
            this.tabPageSelect.Controls.Add(this.groupBoxMusician);
            this.tabPageSelect.Location = new System.Drawing.Point(4, 22);
            this.tabPageSelect.Name = "tabPageSelect";
            this.tabPageSelect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSelect.Size = new System.Drawing.Size(954, 539);
            this.tabPageSelect.TabIndex = 1;
            this.tabPageSelect.Text = "Детализация";
            this.tabPageSelect.UseVisualStyleBackColor = true;
            // 
            // dataGridViewS
            // 
            this.dataGridViewS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewS.Location = new System.Drawing.Point(3, 119);
            this.dataGridViewS.Name = "dataGridViewS";
            this.dataGridViewS.Size = new System.Drawing.Size(948, 417);
            this.dataGridViewS.TabIndex = 1;
            // 
            // groupBoxMusician
            // 
            this.groupBoxMusician.Controls.Add(this.buttonFind);
            this.groupBoxMusician.Controls.Add(this.checkBoxSort);
            this.groupBoxMusician.Controls.Add(this.groupBoxDet);
            this.groupBoxMusician.Controls.Add(this.textBoxMusician);
            this.groupBoxMusician.Controls.Add(this.label1);
            this.groupBoxMusician.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMusician.Location = new System.Drawing.Point(3, 3);
            this.groupBoxMusician.Name = "groupBoxMusician";
            this.groupBoxMusician.Size = new System.Drawing.Size(948, 116);
            this.groupBoxMusician.TabIndex = 0;
            this.groupBoxMusician.TabStop = false;
            this.groupBoxMusician.Text = "Популярность музыканта";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(480, 87);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(75, 23);
            this.buttonFind.TabIndex = 4;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.Location = new System.Drawing.Point(7, 60);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(176, 17);
            this.checkBoxSort.TabIndex = 3;
            this.checkBoxSort.Text = "Сортировать по возрастанию";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // groupBoxDet
            // 
            this.groupBoxDet.Controls.Add(this.radioButtonNoDet);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Tracks);
            this.groupBoxDet.Controls.Add(this.radioButtonDet_Associations);
            this.groupBoxDet.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxDet.Location = new System.Drawing.Point(745, 16);
            this.groupBoxDet.Name = "groupBoxDet";
            this.groupBoxDet.Size = new System.Drawing.Size(200, 97);
            this.groupBoxDet.TabIndex = 2;
            this.groupBoxDet.TabStop = false;
            this.groupBoxDet.Text = "Детализация";
            // 
            // radioButtonNoDet
            // 
            this.radioButtonNoDet.AutoSize = true;
            this.radioButtonNoDet.Location = new System.Drawing.Point(7, 68);
            this.radioButtonNoDet.Name = "radioButtonNoDet";
            this.radioButtonNoDet.Size = new System.Drawing.Size(112, 17);
            this.radioButtonNoDet.TabIndex = 2;
            this.radioButtonNoDet.TabStop = true;
            this.radioButtonNoDet.Text = "Нет детализации";
            this.radioButtonNoDet.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Tracks
            // 
            this.radioButtonDet_Tracks.AutoSize = true;
            this.radioButtonDet_Tracks.Location = new System.Drawing.Point(7, 44);
            this.radioButtonDet_Tracks.Name = "radioButtonDet_Tracks";
            this.radioButtonDet_Tracks.Size = new System.Drawing.Size(148, 17);
            this.radioButtonDet_Tracks.TabIndex = 1;
            this.radioButtonDet_Tracks.TabStop = true;
            this.radioButtonDet_Tracks.Text = "Детализация по трекам";
            this.radioButtonDet_Tracks.UseVisualStyleBackColor = true;
            // 
            // radioButtonDet_Associations
            // 
            this.radioButtonDet_Associations.AutoSize = true;
            this.radioButtonDet_Associations.Location = new System.Drawing.Point(7, 20);
            this.radioButtonDet_Associations.Name = "radioButtonDet_Associations";
            this.radioButtonDet_Associations.Size = new System.Drawing.Size(186, 17);
            this.radioButtonDet_Associations.TabIndex = 0;
            this.radioButtonDet_Associations.TabStop = true;
            this.radioButtonDet_Associations.Text = "Детализация по объединениям";
            this.radioButtonDet_Associations.UseVisualStyleBackColor = true;
            // 
            // textBoxMusician
            // 
            this.textBoxMusician.Location = new System.Drawing.Point(71, 27);
            this.textBoxMusician.Name = "textBoxMusician";
            this.textBoxMusician.Size = new System.Drawing.Size(216, 20);
            this.textBoxMusician.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Музыкант";
            // 
            // tabPageDML
            // 
            this.tabPageDML.Controls.Add(this.dataGridViewMusician);
            this.tabPageDML.Controls.Add(this.panelMusicians);
            this.tabPageDML.Controls.Add(this.groupBoxDML);
            this.tabPageDML.Location = new System.Drawing.Point(4, 22);
            this.tabPageDML.Name = "tabPageDML";
            this.tabPageDML.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDML.Size = new System.Drawing.Size(954, 539);
            this.tabPageDML.TabIndex = 2;
            this.tabPageDML.Text = "Запросы изменения данных";
            this.tabPageDML.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMusician
            // 
            this.dataGridViewMusician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusician.Location = new System.Drawing.Point(3, 211);
            this.dataGridViewMusician.Name = "dataGridViewMusician";
            this.dataGridViewMusician.Size = new System.Drawing.Size(948, 325);
            this.dataGridViewMusician.TabIndex = 2;
            // 
            // panelMusicians
            // 
            this.panelMusicians.Controls.Add(this.label3);
            this.panelMusicians.Controls.Add(this.textBoxCode);
            this.panelMusicians.Controls.Add(this.buttonSelect);
            this.panelMusicians.Controls.Add(this.checkBoxEdu);
            this.panelMusicians.Controls.Add(this.textBoxAud);
            this.panelMusicians.Controls.Add(this.labelAud);
            this.panelMusicians.Controls.Add(this.textBoxCost);
            this.panelMusicians.Controls.Add(this.textBoxRep);
            this.panelMusicians.Controls.Add(this.labelCost);
            this.panelMusicians.Controls.Add(this.labelRep);
            this.panelMusicians.Controls.Add(this.textBoxPop);
            this.panelMusicians.Controls.Add(this.textBoxAss);
            this.panelMusicians.Controls.Add(this.labelPop);
            this.panelMusicians.Controls.Add(this.labelAss);
            this.panelMusicians.Location = new System.Drawing.Point(3, 131);
            this.panelMusicians.Name = "panelMusicians";
            this.panelMusicians.Size = new System.Drawing.Size(948, 74);
            this.panelMusicians.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(731, 21);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(79, 37);
            this.buttonSelect.TabIndex = 11;
            this.buttonSelect.Text = "Показать музыкантов";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // checkBoxEdu
            // 
            this.checkBoxEdu.AutoSize = true;
            this.checkBoxEdu.Location = new System.Drawing.Point(619, 45);
            this.checkBoxEdu.Name = "checkBoxEdu";
            this.checkBoxEdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxEdu.Size = new System.Drawing.Size(94, 17);
            this.checkBoxEdu.TabIndex = 10;
            this.checkBoxEdu.Text = "Образование";
            this.checkBoxEdu.UseVisualStyleBackColor = true;
            // 
            // textBoxAud
            // 
            this.textBoxAud.Location = new System.Drawing.Point(513, 6);
            this.textBoxAud.Name = "textBoxAud";
            this.textBoxAud.Size = new System.Drawing.Size(100, 20);
            this.textBoxAud.TabIndex = 9;
            // 
            // labelAud
            // 
            this.labelAud.AutoSize = true;
            this.labelAud.Location = new System.Drawing.Point(404, 10);
            this.labelAud.Name = "labelAud";
            this.labelAud.Size = new System.Drawing.Size(104, 13);
            this.labelAud.TabIndex = 8;
            this.labelAud.Text = "Возраст аудитории";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(298, 42);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 7;
            // 
            // textBoxRep
            // 
            this.textBoxRep.Location = new System.Drawing.Point(298, 6);
            this.textBoxRep.Name = "textBoxRep";
            this.textBoxRep.Size = new System.Drawing.Size(100, 20);
            this.textBoxRep.TabIndex = 6;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(196, 45);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(100, 13);
            this.labelCost.TabIndex = 5;
            this.labelCost.Text = "Стоимость билета";
            // 
            // labelRep
            // 
            this.labelRep.AutoSize = true;
            this.labelRep.Location = new System.Drawing.Point(196, 10);
            this.labelRep.Name = "labelRep";
            this.labelRep.Size = new System.Drawing.Size(60, 13);
            this.labelRep.TabIndex = 4;
            this.labelRep.Text = "Репутация";
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(87, 42);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.Size = new System.Drawing.Size(100, 20);
            this.textBoxPop.TabIndex = 3;
            // 
            // textBoxAss
            // 
            this.textBoxAss.Location = new System.Drawing.Point(87, 6);
            this.textBoxAss.Name = "textBoxAss";
            this.textBoxAss.Size = new System.Drawing.Size(100, 20);
            this.textBoxAss.TabIndex = 2;
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(5, 45);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(79, 13);
            this.labelPop.TabIndex = 1;
            this.labelPop.Text = "Популярность";
            // 
            // labelAss
            // 
            this.labelAss.AutoSize = true;
            this.labelAss.Location = new System.Drawing.Point(5, 10);
            this.labelAss.Name = "labelAss";
            this.labelAss.Size = new System.Drawing.Size(76, 13);
            this.labelAss.TabIndex = 0;
            this.labelAss.Text = "Объединение";
            // 
            // groupBoxDML
            // 
            this.groupBoxDML.Controls.Add(this.groupBox2);
            this.groupBoxDML.Controls.Add(this.textBoxArtist);
            this.groupBoxDML.Controls.Add(this.buttonExecuteDML);
            this.groupBoxDML.Controls.Add(this.label2);
            this.groupBoxDML.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxDML.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDML.Name = "groupBoxDML";
            this.groupBoxDML.Size = new System.Drawing.Size(948, 122);
            this.groupBoxDML.TabIndex = 0;
            this.groupBoxDML.TabStop = false;
            this.groupBoxDML.Text = "Операторы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonDelete);
            this.groupBox2.Controls.Add(this.radioButtonUpdate);
            this.groupBox2.Controls.Add(this.radioButtonInsert);
            this.groupBox2.Location = new System.Drawing.Point(282, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 97);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выбор действия";
            // 
            // radioButtonDelete
            // 
            this.radioButtonDelete.AutoSize = true;
            this.radioButtonDelete.Location = new System.Drawing.Point(7, 68);
            this.radioButtonDelete.Name = "radioButtonDelete";
            this.radioButtonDelete.Size = new System.Drawing.Size(68, 17);
            this.radioButtonDelete.TabIndex = 2;
            this.radioButtonDelete.TabStop = true;
            this.radioButtonDelete.Text = "Удалить";
            this.radioButtonDelete.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdate
            // 
            this.radioButtonUpdate.AutoSize = true;
            this.radioButtonUpdate.Location = new System.Drawing.Point(7, 44);
            this.radioButtonUpdate.Name = "radioButtonUpdate";
            this.radioButtonUpdate.Size = new System.Drawing.Size(76, 17);
            this.radioButtonUpdate.TabIndex = 1;
            this.radioButtonUpdate.TabStop = true;
            this.radioButtonUpdate.Text = "Изменить";
            this.radioButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // radioButtonInsert
            // 
            this.radioButtonInsert.AutoSize = true;
            this.radioButtonInsert.Location = new System.Drawing.Point(7, 20);
            this.radioButtonInsert.Name = "radioButtonInsert";
            this.radioButtonInsert.Size = new System.Drawing.Size(75, 17);
            this.radioButtonInsert.TabIndex = 0;
            this.radioButtonInsert.TabStop = true;
            this.radioButtonInsert.Text = "Добавить";
            this.radioButtonInsert.UseVisualStyleBackColor = true;
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(68, 46);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(100, 20);
            this.textBoxArtist.TabIndex = 2;
            // 
            // buttonExecuteDML
            // 
            this.buttonExecuteDML.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExecuteDML.Image = ((System.Drawing.Image)(resources.GetObject("buttonExecuteDML.Image")));
            this.buttonExecuteDML.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExecuteDML.Location = new System.Drawing.Point(527, 39);
            this.buttonExecuteDML.Name = "buttonExecuteDML";
            this.buttonExecuteDML.Size = new System.Drawing.Size(143, 61);
            this.buttonExecuteDML.TabIndex = 1;
            this.buttonExecuteDML.Text = "Выполнить запрос";
            this.buttonExecuteDML.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExecuteDML.UseVisualStyleBackColor = true;
            this.buttonExecuteDML.Click += new System.EventHandler(this.buttonExecuteDML_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Музыкант";
            // 
            // soundProdDataSet
            // 
            this.soundProdDataSet.DataSetName = "SoundProdDataSet";
            this.soundProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // soundProdDataSetBindingSource
            // 
            this.soundProdDataSetBindingSource.DataSource = this.soundProdDataSet;
            this.soundProdDataSetBindingSource.Position = 0;
            // 
            // soundProdDataSetBindingSource1
            // 
            this.soundProdDataSetBindingSource1.DataSource = this.soundProdDataSet;
            this.soundProdDataSetBindingSource1.Position = 0;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(513, 42);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(100, 20);
            this.textBoxCode.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Кодовое слово";
            // 
            // FormSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 565);
            this.Controls.Add(this.tabControlSQL);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSQL";
            this.Text = "Запросы";
            this.tabControlSQL.ResumeLayout(false);
            this.tabPageQueries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelect)).EndInit();
            this.groupBoxSelect.ResumeLayout(false);
            this.groupBoxSelect.PerformLayout();
            this.tabPageSelect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewS)).EndInit();
            this.groupBoxMusician.ResumeLayout(false);
            this.groupBoxMusician.PerformLayout();
            this.groupBoxDet.ResumeLayout(false);
            this.groupBoxDet.PerformLayout();
            this.tabPageDML.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusician)).EndInit();
            this.panelMusicians.ResumeLayout(false);
            this.panelMusicians.PerformLayout();
            this.groupBoxDML.ResumeLayout(false);
            this.groupBoxDML.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlSQL;
        private System.Windows.Forms.TabPage tabPageQueries;
        private System.Windows.Forms.TabPage tabPageSelect;
        private System.Windows.Forms.DataGridView dataGridViewSelect;
        private System.Windows.Forms.BindingSource soundProdDataSetBindingSource;
        private SoundProdDataSet soundProdDataSet;
        private System.Windows.Forms.GroupBox groupBoxSelect;
        private System.Windows.Forms.RadioButton radioButtonTracks;
        private System.Windows.Forms.RadioButton radioButtonSequencers;
        private System.Windows.Forms.RadioButton radioButtonAssociations;
        private System.Windows.Forms.BindingSource soundProdDataSetBindingSource1;
        private System.Windows.Forms.GroupBox groupBoxMusician;
        private System.Windows.Forms.DataGridView dataGridViewS;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.CheckBox checkBoxSort;
        private System.Windows.Forms.GroupBox groupBoxDet;
        private System.Windows.Forms.RadioButton radioButtonNoDet;
        private System.Windows.Forms.RadioButton radioButtonDet_Tracks;
        private System.Windows.Forms.RadioButton radioButtonDet_Associations;
        private System.Windows.Forms.TextBox textBoxMusician;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDML;
        private System.Windows.Forms.GroupBox groupBoxDML;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButtonDelete;
        private System.Windows.Forms.RadioButton radioButtonUpdate;
        private System.Windows.Forms.RadioButton radioButtonInsert;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Button buttonExecuteDML;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelMusicians;
        private System.Windows.Forms.CheckBox checkBoxEdu;
        private System.Windows.Forms.TextBox textBoxAud;
        private System.Windows.Forms.Label labelAud;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxRep;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelRep;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.TextBox textBoxAss;
        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelAss;
        private System.Windows.Forms.DataGridView dataGridViewMusician;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCode;
    }
}