
namespace Production.User
{
    partial class FormArtistUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormArtistUser));
            this.panelMusicians = new System.Windows.Forms.Panel();
            this.listBoxAss = new System.Windows.Forms.ListBox();
            this.объединениеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soundProdDataSet = new Production.SoundProdDataSet();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxArtist = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.checkBoxEdu = new System.Windows.Forms.CheckBox();
            this.textBoxAud = new System.Windows.Forms.TextBox();
            this.labelAud = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.textBoxRep = new System.Windows.Forms.TextBox();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelRep = new System.Windows.Forms.Label();
            this.textBoxPop = new System.Windows.Forms.TextBox();
            this.labelPop = new System.Windows.Forms.Label();
            this.labelAss = new System.Windows.Forms.Label();
            this.dataGridViewMusician = new System.Windows.Forms.DataGridView();
            this.объединениеTableAdapter = new Production.SoundProdDataSetTableAdapters.ОбъединениеTableAdapter();
            this.tableAdapterManager = new Production.SoundProdDataSetTableAdapters.TableAdapterManager();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.panelMusicians.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объединениеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusician)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMusicians
            // 
            this.panelMusicians.Controls.Add(this.listBoxAss);
            this.panelMusicians.Controls.Add(this.textBoxCode);
            this.panelMusicians.Controls.Add(this.label1);
            this.panelMusicians.Controls.Add(this.buttonAdd);
            this.panelMusicians.Controls.Add(this.textBoxArtist);
            this.panelMusicians.Controls.Add(this.label2);
            this.panelMusicians.Controls.Add(this.buttonSelect);
            this.panelMusicians.Controls.Add(this.checkBoxEdu);
            this.panelMusicians.Controls.Add(this.textBoxAud);
            this.panelMusicians.Controls.Add(this.labelAud);
            this.panelMusicians.Controls.Add(this.textBoxCost);
            this.panelMusicians.Controls.Add(this.textBoxRep);
            this.panelMusicians.Controls.Add(this.labelCost);
            this.panelMusicians.Controls.Add(this.labelRep);
            this.panelMusicians.Controls.Add(this.textBoxPop);
            this.panelMusicians.Controls.Add(this.labelPop);
            this.panelMusicians.Controls.Add(this.labelAss);
            this.panelMusicians.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMusicians.Location = new System.Drawing.Point(0, 0);
            this.panelMusicians.Name = "panelMusicians";
            this.panelMusicians.Size = new System.Drawing.Size(815, 231);
            this.panelMusicians.TabIndex = 0;
            // 
            // listBoxAss
            // 
            this.listBoxAss.DataSource = this.объединениеBindingSource;
            this.listBoxAss.DisplayMember = "PK_Название_Объединения";
            this.listBoxAss.FormattingEnabled = true;
            this.listBoxAss.Location = new System.Drawing.Point(308, 11);
            this.listBoxAss.Name = "listBoxAss";
            this.listBoxAss.Size = new System.Drawing.Size(103, 56);
            this.listBoxAss.TabIndex = 1;
            // 
            // объединениеBindingSource
            // 
            this.объединениеBindingSource.DataMember = "Объединение";
            this.объединениеBindingSource.DataSource = this.soundProdDataSet;
            // 
            // soundProdDataSet
            // 
            this.soundProdDataSet.DataSetName = "SoundProdDataSet";
            this.soundProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(94, 135);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(293, 20);
            this.textBoxCode.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Кодовое слово";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(94, 161);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(79, 37);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Добавить музыканта";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxArtist
            // 
            this.textBoxArtist.Location = new System.Drawing.Point(78, 15);
            this.textBoxArtist.Name = "textBoxArtist";
            this.textBoxArtist.Size = new System.Drawing.Size(136, 20);
            this.textBoxArtist.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Музыкант";
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(308, 161);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(79, 37);
            this.buttonSelect.TabIndex = 9;
            this.buttonSelect.Text = "Показать музыканта";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // checkBoxEdu
            // 
            this.checkBoxEdu.AutoSize = true;
            this.checkBoxEdu.Location = new System.Drawing.Point(625, 83);
            this.checkBoxEdu.Name = "checkBoxEdu";
            this.checkBoxEdu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxEdu.Size = new System.Drawing.Size(94, 17);
            this.checkBoxEdu.TabIndex = 6;
            this.checkBoxEdu.Text = "Образование";
            this.checkBoxEdu.UseVisualStyleBackColor = true;
            // 
            // textBoxAud
            // 
            this.textBoxAud.Location = new System.Drawing.Point(114, 80);
            this.textBoxAud.Name = "textBoxAud";
            this.textBoxAud.Size = new System.Drawing.Size(100, 20);
            this.textBoxAud.TabIndex = 3;
            // 
            // labelAud
            // 
            this.labelAud.AutoSize = true;
            this.labelAud.Location = new System.Drawing.Point(5, 84);
            this.labelAud.Name = "labelAud";
            this.labelAud.Size = new System.Drawing.Size(104, 13);
            this.labelAud.TabIndex = 8;
            this.labelAud.Text = "Возраст аудитории";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(519, 81);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(100, 20);
            this.textBoxCost.TabIndex = 5;
            // 
            // textBoxRep
            // 
            this.textBoxRep.Location = new System.Drawing.Point(519, 11);
            this.textBoxRep.Name = "textBoxRep";
            this.textBoxRep.Size = new System.Drawing.Size(100, 20);
            this.textBoxRep.TabIndex = 2;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(417, 84);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(100, 13);
            this.labelCost.TabIndex = 5;
            this.labelCost.Text = "Стоимость билета";
            // 
            // labelRep
            // 
            this.labelRep.AutoSize = true;
            this.labelRep.Location = new System.Drawing.Point(417, 15);
            this.labelRep.Name = "labelRep";
            this.labelRep.Size = new System.Drawing.Size(60, 13);
            this.labelRep.TabIndex = 4;
            this.labelRep.Text = "Репутация";
            // 
            // textBoxPop
            // 
            this.textBoxPop.Location = new System.Drawing.Point(308, 81);
            this.textBoxPop.Name = "textBoxPop";
            this.textBoxPop.Size = new System.Drawing.Size(100, 20);
            this.textBoxPop.TabIndex = 4;
            // 
            // labelPop
            // 
            this.labelPop.AutoSize = true;
            this.labelPop.Location = new System.Drawing.Point(226, 84);
            this.labelPop.Name = "labelPop";
            this.labelPop.Size = new System.Drawing.Size(79, 13);
            this.labelPop.TabIndex = 1;
            this.labelPop.Text = "Популярность";
            // 
            // labelAss
            // 
            this.labelAss.AutoSize = true;
            this.labelAss.Location = new System.Drawing.Point(226, 15);
            this.labelAss.Name = "labelAss";
            this.labelAss.Size = new System.Drawing.Size(76, 13);
            this.labelAss.TabIndex = 0;
            this.labelAss.Text = "Объединение";
            // 
            // dataGridViewMusician
            // 
            this.dataGridViewMusician.AllowUserToAddRows = false;
            this.dataGridViewMusician.AllowUserToDeleteRows = false;
            this.dataGridViewMusician.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMusician.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewMusician.Location = new System.Drawing.Point(0, 231);
            this.dataGridViewMusician.Name = "dataGridViewMusician";
            this.dataGridViewMusician.ReadOnly = true;
            this.dataGridViewMusician.Size = new System.Drawing.Size(815, 225);
            this.dataGridViewMusician.TabIndex = 3;
            // 
            // объединениеTableAdapter
            // 
            this.объединениеTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Production.SoundProdDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.МузыкантTableAdapter = null;
            this.tableAdapterManager.ОбъединениеTableAdapter = this.объединениеTableAdapter;
            this.tableAdapterManager.СеквенсорTableAdapter = null;
            this.tableAdapterManager.СервисTableAdapter = null;
            this.tableAdapterManager.ТрекTableAdapter = null;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 456);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(815, 25);
            this.fillByToolStrip.TabIndex = 4;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // FormArtistUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 454);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridViewMusician);
            this.Controls.Add(this.panelMusicians);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormArtistUser";
            this.Text = "Присоединиться к нам";
            this.Load += new System.EventHandler(this.FormArtistUser_Load);
            this.panelMusicians.ResumeLayout(false);
            this.panelMusicians.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.объединениеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMusician)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMusicians;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.CheckBox checkBoxEdu;
        private System.Windows.Forms.TextBox textBoxAud;
        private System.Windows.Forms.Label labelAud;
        private System.Windows.Forms.TextBox textBoxCost;
        private System.Windows.Forms.TextBox textBoxRep;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelRep;
        private System.Windows.Forms.TextBox textBoxPop;
        private System.Windows.Forms.Label labelPop;
        private System.Windows.Forms.Label labelAss;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxArtist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewMusician;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxAss;
        private SoundProdDataSet soundProdDataSet;
        private System.Windows.Forms.BindingSource объединениеBindingSource;
        private SoundProdDataSetTableAdapters.ОбъединениеTableAdapter объединениеTableAdapter;
        private SoundProdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}