
namespace Production
{
    partial class FormTracks
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
            System.Windows.Forms.Label pK_Название_ТрекаLabel;
            System.Windows.Forms.Label pK_FK_ПсевдонимLabel;
            System.Windows.Forms.Label fK_Название_СеквенсораLabel;
            System.Windows.Forms.Label fK_Название_СервисаLabel;
            System.Windows.Forms.Label текстLabel;
            System.Windows.Forms.Label жанрLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTracks));
            this.soundProdDataSet = new Production.SoundProdDataSet();
            this.трекBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.трекTableAdapter = new Production.SoundProdDataSetTableAdapters.ТрекTableAdapter();
            this.tableAdapterManager = new Production.SoundProdDataSetTableAdapters.TableAdapterManager();
            this.трекBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pK_Название_ТрекаTextBox = new System.Windows.Forms.TextBox();
            this.pK_FK_ПсевдонимTextBox = new System.Windows.Forms.TextBox();
            this.fK_Название_СеквенсораTextBox = new System.Windows.Forms.TextBox();
            this.fK_Название_СервисаTextBox = new System.Windows.Forms.TextBox();
            this.текстTextBox = new System.Windows.Forms.TextBox();
            this.жанрTextBox = new System.Windows.Forms.TextBox();
            this.buttonSequencors = new System.Windows.Forms.Button();
            this.buttonServices = new System.Windows.Forms.Button();
            this.секвенсорTableAdapter = new Production.SoundProdDataSetTableAdapters.СеквенсорTableAdapter();
            this.сервисTableAdapter = new Production.SoundProdDataSetTableAdapters.СервисTableAdapter();
            this.buttonMusician = new System.Windows.Forms.Button();
            this.музыкантTableAdapter = new Production.SoundProdDataSetTableAdapters.МузыкантTableAdapter();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.трекBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            pK_Название_ТрекаLabel = new System.Windows.Forms.Label();
            pK_FK_ПсевдонимLabel = new System.Windows.Forms.Label();
            fK_Название_СеквенсораLabel = new System.Windows.Forms.Label();
            fK_Название_СервисаLabel = new System.Windows.Forms.Label();
            текстLabel = new System.Windows.Forms.Label();
            жанрLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трекBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.трекBindingNavigator)).BeginInit();
            this.трекBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pK_Название_ТрекаLabel
            // 
            pK_Название_ТрекаLabel.AutoSize = true;
            pK_Название_ТрекаLabel.Location = new System.Drawing.Point(15, 54);
            pK_Название_ТрекаLabel.Name = "pK_Название_ТрекаLabel";
            pK_Название_ТрекаLabel.Size = new System.Drawing.Size(111, 13);
            pK_Название_ТрекаLabel.TabIndex = 1;
            pK_Название_ТрекаLabel.Text = "PK Название Трека:";
            // 
            // pK_FK_ПсевдонимLabel
            // 
            pK_FK_ПсевдонимLabel.AutoSize = true;
            pK_FK_ПсевдонимLabel.Location = new System.Drawing.Point(15, 80);
            pK_FK_ПсевдонимLabel.Name = "pK_FK_ПсевдонимLabel";
            pK_FK_ПсевдонимLabel.Size = new System.Drawing.Size(101, 13);
            pK_FK_ПсевдонимLabel.TabIndex = 3;
            pK_FK_ПсевдонимLabel.Text = "PK FK Псевдоним:";
            // 
            // fK_Название_СеквенсораLabel
            // 
            fK_Название_СеквенсораLabel.AutoSize = true;
            fK_Название_СеквенсораLabel.Location = new System.Drawing.Point(15, 106);
            fK_Название_СеквенсораLabel.Name = "fK_Название_СеквенсораLabel";
            fK_Название_СеквенсораLabel.Size = new System.Drawing.Size(140, 13);
            fK_Название_СеквенсораLabel.TabIndex = 5;
            fK_Название_СеквенсораLabel.Text = "FK Название Секвенсора:";
            // 
            // fK_Название_СервисаLabel
            // 
            fK_Название_СервисаLabel.AutoSize = true;
            fK_Название_СервисаLabel.Location = new System.Drawing.Point(15, 132);
            fK_Название_СервисаLabel.Name = "fK_Название_СервисаLabel";
            fK_Название_СервисаLabel.Size = new System.Drawing.Size(122, 13);
            fK_Название_СервисаLabel.TabIndex = 7;
            fK_Название_СервисаLabel.Text = "FK Название Сервиса:";
            // 
            // текстLabel
            // 
            текстLabel.AutoSize = true;
            текстLabel.Location = new System.Drawing.Point(15, 158);
            текстLabel.Name = "текстLabel";
            текстLabel.Size = new System.Drawing.Size(40, 13);
            текстLabel.TabIndex = 9;
            текстLabel.Text = "Текст:";
            // 
            // жанрLabel
            // 
            жанрLabel.AutoSize = true;
            жанрLabel.Location = new System.Drawing.Point(15, 313);
            жанрLabel.Name = "жанрLabel";
            жанрLabel.Size = new System.Drawing.Size(39, 13);
            жанрLabel.TabIndex = 11;
            жанрLabel.Text = "Жанр:";
            // 
            // soundProdDataSet
            // 
            this.soundProdDataSet.DataSetName = "SoundProdDataSet";
            this.soundProdDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // трекBindingNavigator
            // 
            this.трекBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.трекBindingNavigator.BindingSource = this.трекBindingSource;
            this.трекBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.трекBindingNavigator.CountItemFormat = "из {0}";
            this.трекBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.трекBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.трекBindingNavigatorSaveItem});
            this.трекBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.трекBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.трекBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.трекBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.трекBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.трекBindingNavigator.Name = "трекBindingNavigator";
            this.трекBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.трекBindingNavigator.Size = new System.Drawing.Size(537, 25);
            this.трекBindingNavigator.TabIndex = 0;
            this.трекBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "из {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // pK_Название_ТрекаTextBox
            // 
            this.pK_Название_ТрекаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.трекBindingSource, "PK_Название_Трека", true));
            this.pK_Название_ТрекаTextBox.Location = new System.Drawing.Point(161, 51);
            this.pK_Название_ТрекаTextBox.Name = "pK_Название_ТрекаTextBox";
            this.pK_Название_ТрекаTextBox.Size = new System.Drawing.Size(100, 20);
            this.pK_Название_ТрекаTextBox.TabIndex = 2;
            // 
            // pK_FK_ПсевдонимTextBox
            // 
            this.pK_FK_ПсевдонимTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.трекBindingSource, "PK_FK_Псевдоним", true));
            this.pK_FK_ПсевдонимTextBox.Location = new System.Drawing.Point(161, 77);
            this.pK_FK_ПсевдонимTextBox.Name = "pK_FK_ПсевдонимTextBox";
            this.pK_FK_ПсевдонимTextBox.Size = new System.Drawing.Size(100, 20);
            this.pK_FK_ПсевдонимTextBox.TabIndex = 4;
            // 
            // fK_Название_СеквенсораTextBox
            // 
            this.fK_Название_СеквенсораTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.трекBindingSource, "FK_Название_Секвенсора", true));
            this.fK_Название_СеквенсораTextBox.Location = new System.Drawing.Point(161, 103);
            this.fK_Название_СеквенсораTextBox.Name = "fK_Название_СеквенсораTextBox";
            this.fK_Название_СеквенсораTextBox.Size = new System.Drawing.Size(100, 20);
            this.fK_Название_СеквенсораTextBox.TabIndex = 6;
            // 
            // fK_Название_СервисаTextBox
            // 
            this.fK_Название_СервисаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.трекBindingSource, "FK_Название_Сервиса", true));
            this.fK_Название_СервисаTextBox.Location = new System.Drawing.Point(161, 129);
            this.fK_Название_СервисаTextBox.Name = "fK_Название_СервисаTextBox";
            this.fK_Название_СервисаTextBox.Size = new System.Drawing.Size(100, 20);
            this.fK_Название_СервисаTextBox.TabIndex = 8;
            // 
            // текстTextBox
            // 
            this.текстTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.трекBindingSource, "Текст", true));
            this.текстTextBox.Location = new System.Drawing.Point(161, 155);
            this.текстTextBox.Multiline = true;
            this.текстTextBox.Name = "текстTextBox";
            this.текстTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.текстTextBox.Size = new System.Drawing.Size(343, 149);
            this.текстTextBox.TabIndex = 10;
            // 
            // жанрTextBox
            // 
            this.жанрTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.трекBindingSource, "Жанр", true));
            this.жанрTextBox.Location = new System.Drawing.Point(161, 310);
            this.жанрTextBox.Name = "жанрTextBox";
            this.жанрTextBox.Size = new System.Drawing.Size(100, 20);
            this.жанрTextBox.TabIndex = 12;
            // 
            // buttonSequencors
            // 
            this.buttonSequencors.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSequencors.Location = new System.Drawing.Point(292, 103);
            this.buttonSequencors.Name = "buttonSequencors";
            this.buttonSequencors.Size = new System.Drawing.Size(100, 20);
            this.buttonSequencors.TabIndex = 13;
            this.buttonSequencors.Text = "Секвенсоры";
            this.buttonSequencors.UseVisualStyleBackColor = true;
            this.buttonSequencors.Click += new System.EventHandler(this.buttonSequencors_Click);
            // 
            // buttonServices
            // 
            this.buttonServices.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonServices.Location = new System.Drawing.Point(292, 129);
            this.buttonServices.Name = "buttonServices";
            this.buttonServices.Size = new System.Drawing.Size(100, 20);
            this.buttonServices.TabIndex = 14;
            this.buttonServices.Text = "Сервисы";
            this.buttonServices.UseVisualStyleBackColor = true;
            this.buttonServices.Click += new System.EventHandler(this.buttonServices_Click);
            // 
            // секвенсорTableAdapter
            // 
            this.секвенсорTableAdapter.ClearBeforeFill = true;
            // 
            // сервисTableAdapter
            // 
            this.сервисTableAdapter.ClearBeforeFill = true;
            // 
            // buttonMusician
            // 
            this.buttonMusician.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMusician.Location = new System.Drawing.Point(292, 77);
            this.buttonMusician.Name = "buttonMusician";
            this.buttonMusician.Size = new System.Drawing.Size(100, 20);
            this.buttonMusician.TabIndex = 15;
            this.buttonMusician.Text = "Музыканты";
            this.buttonMusician.UseVisualStyleBackColor = true;
            this.buttonMusician.Click += new System.EventHandler(this.buttonMusician_Click);
            // 
            // музыкантTableAdapter
            // 
            this.музыкантTableAdapter.ClearBeforeFill = true;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // трекBindingNavigatorSaveItem
            // 
            this.трекBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.трекBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("трекBindingNavigatorSaveItem.Image")));
            this.трекBindingNavigatorSaveItem.Name = "трекBindingNavigatorSaveItem";
            this.трекBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.трекBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.трекBindingNavigatorSaveItem.Click += new System.EventHandler(this.трекBindingNavigatorSaveItem_Click);
            // 
            // FormTracks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 358);
            this.Controls.Add(this.buttonMusician);
            this.Controls.Add(this.buttonServices);
            this.Controls.Add(this.buttonSequencors);
            this.Controls.Add(pK_Название_ТрекаLabel);
            this.Controls.Add(this.pK_Название_ТрекаTextBox);
            this.Controls.Add(pK_FK_ПсевдонимLabel);
            this.Controls.Add(this.pK_FK_ПсевдонимTextBox);
            this.Controls.Add(fK_Название_СеквенсораLabel);
            this.Controls.Add(this.fK_Название_СеквенсораTextBox);
            this.Controls.Add(fK_Название_СервисаLabel);
            this.Controls.Add(this.fK_Название_СервисаTextBox);
            this.Controls.Add(текстLabel);
            this.Controls.Add(this.текстTextBox);
            this.Controls.Add(жанрLabel);
            this.Controls.Add(this.жанрTextBox);
            this.Controls.Add(this.трекBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormTracks";
            this.Text = "Треки";
            this.Load += new System.EventHandler(this.FormTracks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soundProdDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трекBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.трекBindingNavigator)).EndInit();
            this.трекBindingNavigator.ResumeLayout(false);
            this.трекBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoundProdDataSet soundProdDataSet;
        private System.Windows.Forms.BindingSource трекBindingSource;
        private SoundProdDataSetTableAdapters.ТрекTableAdapter трекTableAdapter;
        private SoundProdDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator трекBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton трекBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox pK_Название_ТрекаTextBox;
        private System.Windows.Forms.TextBox pK_FK_ПсевдонимTextBox;
        private System.Windows.Forms.TextBox fK_Название_СеквенсораTextBox;
        private System.Windows.Forms.TextBox fK_Название_СервисаTextBox;
        private System.Windows.Forms.TextBox текстTextBox;
        private System.Windows.Forms.TextBox жанрTextBox;
        private System.Windows.Forms.Button buttonSequencors;
        private System.Windows.Forms.Button buttonServices;
        private SoundProdDataSetTableAdapters.СеквенсорTableAdapter секвенсорTableAdapter;
        private SoundProdDataSetTableAdapters.СервисTableAdapter сервисTableAdapter;
        private System.Windows.Forms.Button buttonMusician;
        private SoundProdDataSetTableAdapters.МузыкантTableAdapter музыкантTableAdapter;
    }
}