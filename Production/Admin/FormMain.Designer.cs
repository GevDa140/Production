
namespace Production
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трекиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.исполнителиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объединенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трекиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.запросыToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.секвенсорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.объединенияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonServices = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSequencers = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAssociations = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTracks = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSQL = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonAbout = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonExit = new System.Windows.Forms.ToolStripButton();
            this.menuStripMain.SuspendLayout();
            this.contextMenuStripMain.SuspendLayout();
            this.toolStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.запросыToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(800, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem.Image")));
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.трекиToolStripMenuItem,
            this.исполнителиToolStripMenuItem,
            this.объединенияToolStripMenuItem,
            this.трекиToolStripMenuItem1});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // трекиToolStripMenuItem
            // 
            this.трекиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("трекиToolStripMenuItem.Image")));
            this.трекиToolStripMenuItem.Name = "трекиToolStripMenuItem";
            this.трекиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.трекиToolStripMenuItem.Text = "Сервисы";
            this.трекиToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonServices_Click);
            // 
            // исполнителиToolStripMenuItem
            // 
            this.исполнителиToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("исполнителиToolStripMenuItem.Image")));
            this.исполнителиToolStripMenuItem.Name = "исполнителиToolStripMenuItem";
            this.исполнителиToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.исполнителиToolStripMenuItem.Text = "Секвенсоры";
            // 
            // объединенияToolStripMenuItem
            // 
            this.объединенияToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("объединенияToolStripMenuItem.Image")));
            this.объединенияToolStripMenuItem.Name = "объединенияToolStripMenuItem";
            this.объединенияToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.объединенияToolStripMenuItem.Text = "Объединения";
            // 
            // трекиToolStripMenuItem1
            // 
            this.трекиToolStripMenuItem1.Image = global::Production.Properties.Resources.Headphones_icon_icons_com_53690;
            this.трекиToolStripMenuItem1.Name = "трекиToolStripMenuItem1";
            this.трекиToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.трекиToolStripMenuItem1.Text = "Треки";
            this.трекиToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButtonTracks_Click);
            // 
            // запросыToolStripMenuItem
            // 
            this.запросыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запросыToolStripMenuItem1});
            this.запросыToolStripMenuItem.Name = "запросыToolStripMenuItem";
            this.запросыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.запросыToolStripMenuItem.Text = "Запросы";
            // 
            // запросыToolStripMenuItem1
            // 
            this.запросыToolStripMenuItem1.Image = global::Production.Properties.Resources.file_type_light_rubocop_icon_130438;
            this.запросыToolStripMenuItem1.Name = "запросыToolStripMenuItem1";
            this.запросыToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.запросыToolStripMenuItem1.Text = "Запросы";
            this.запросыToolStripMenuItem1.Click += new System.EventHandler(this.toolStripButtonSQL_Click);
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem1,
            this.справочникиToolStripMenuItem1});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(150, 48);
            // 
            // файлToolStripMenuItem1
            // 
            this.файлToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem1,
            this.оПрограммеToolStripMenuItem1});
            this.файлToolStripMenuItem1.Name = "файлToolStripMenuItem1";
            this.файлToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.файлToolStripMenuItem1.Text = "Файл";
            // 
            // выходToolStripMenuItem1
            // 
            this.выходToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("выходToolStripMenuItem1.Image")));
            this.выходToolStripMenuItem1.Name = "выходToolStripMenuItem1";
            this.выходToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.выходToolStripMenuItem1.Text = "Выход";
            this.выходToolStripMenuItem1.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem1.Image")));
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // справочникиToolStripMenuItem1
            // 
            this.справочникиToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сервисыToolStripMenuItem,
            this.секвенсорыToolStripMenuItem,
            this.объединенияToolStripMenuItem1});
            this.справочникиToolStripMenuItem1.Name = "справочникиToolStripMenuItem1";
            this.справочникиToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.справочникиToolStripMenuItem1.Text = "Справочники";
            // 
            // сервисыToolStripMenuItem
            // 
            this.сервисыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сервисыToolStripMenuItem.Image")));
            this.сервисыToolStripMenuItem.Name = "сервисыToolStripMenuItem";
            this.сервисыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.сервисыToolStripMenuItem.Text = "Сервисы";
            this.сервисыToolStripMenuItem.Click += new System.EventHandler(this.toolStripButtonServices_Click);
            // 
            // секвенсорыToolStripMenuItem
            // 
            this.секвенсорыToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("секвенсорыToolStripMenuItem.Image")));
            this.секвенсорыToolStripMenuItem.Name = "секвенсорыToolStripMenuItem";
            this.секвенсорыToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.секвенсорыToolStripMenuItem.Text = "Секвенсоры";
            // 
            // объединенияToolStripMenuItem1
            // 
            this.объединенияToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("объединенияToolStripMenuItem1.Image")));
            this.объединенияToolStripMenuItem1.Name = "объединенияToolStripMenuItem1";
            this.объединенияToolStripMenuItem1.Size = new System.Drawing.Size(149, 22);
            this.объединенияToolStripMenuItem1.Text = "Объединения";
            // 
            // toolStripMain
            // 
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonServices,
            this.toolStripButtonSequencers,
            this.toolStripButtonAssociations,
            this.toolStripButtonTracks,
            this.toolStripButtonSQL,
            this.toolStripButtonAbout,
            this.toolStripButtonExit});
            this.toolStripMain.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(800, 25);
            this.toolStripMain.TabIndex = 2;
            this.toolStripMain.Text = "toolStrip1";
            // 
            // toolStripButtonServices
            // 
            this.toolStripButtonServices.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonServices.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonServices.Image")));
            this.toolStripButtonServices.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonServices.Name = "toolStripButtonServices";
            this.toolStripButtonServices.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonServices.Text = "toolStripButton1";
            this.toolStripButtonServices.ToolTipText = "Сервисы";
            this.toolStripButtonServices.Click += new System.EventHandler(this.toolStripButtonServices_Click);
            // 
            // toolStripButtonSequencers
            // 
            this.toolStripButtonSequencers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSequencers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSequencers.Image")));
            this.toolStripButtonSequencers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSequencers.Name = "toolStripButtonSequencers";
            this.toolStripButtonSequencers.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSequencers.Text = "toolStripButton2";
            this.toolStripButtonSequencers.ToolTipText = "Секвенсоры";
            this.toolStripButtonSequencers.Click += new System.EventHandler(this.toolStripButtonSequencers_Click);
            // 
            // toolStripButtonAssociations
            // 
            this.toolStripButtonAssociations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAssociations.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAssociations.Image")));
            this.toolStripButtonAssociations.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAssociations.Name = "toolStripButtonAssociations";
            this.toolStripButtonAssociations.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAssociations.Text = "toolStripButton3";
            this.toolStripButtonAssociations.ToolTipText = "Объединения";
            this.toolStripButtonAssociations.Click += new System.EventHandler(this.toolStripButtonAssociations_Click);
            // 
            // toolStripButtonTracks
            // 
            this.toolStripButtonTracks.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTracks.Image = global::Production.Properties.Resources.Headphones_icon_icons_com_53690;
            this.toolStripButtonTracks.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTracks.Name = "toolStripButtonTracks";
            this.toolStripButtonTracks.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonTracks.Text = "Треки";
            this.toolStripButtonTracks.Click += new System.EventHandler(this.toolStripButtonTracks_Click);
            // 
            // toolStripButtonSQL
            // 
            this.toolStripButtonSQL.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonSQL.Image = global::Production.Properties.Resources.file_type_light_rubocop_icon_130438;
            this.toolStripButtonSQL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSQL.Name = "toolStripButtonSQL";
            this.toolStripButtonSQL.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonSQL.Text = "Запросы";
            this.toolStripButtonSQL.Click += new System.EventHandler(this.toolStripButtonSQL_Click);
            // 
            // toolStripButtonAbout
            // 
            this.toolStripButtonAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAbout.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAbout.Image")));
            this.toolStripButtonAbout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAbout.Name = "toolStripButtonAbout";
            this.toolStripButtonAbout.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAbout.Text = "О программе";
            this.toolStripButtonAbout.ToolTipText = "О программе";
            this.toolStripButtonAbout.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // toolStripButtonExit
            // 
            this.toolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonExit.Image")));
            this.toolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonExit.Name = "toolStripButtonExit";
            this.toolStripButtonExit.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonExit.Text = "toolStripButton1";
            this.toolStripButtonExit.ToolTipText = "Выход";
            this.toolStripButtonExit.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStripMain;
            this.Controls.Add(this.toolStripMain);
            this.Controls.Add(this.menuStripMain);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::Production.Properties.Settings.Default, "FormPos", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::Production.Properties.Settings.Default.FormPos;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "FormMain";
            this.Text = "Sound Production";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.contextMenuStripMain.ResumeLayout(false);
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem трекиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem исполнителиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объединенияToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сервисыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem секвенсорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem объединенияToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonExit;
        private System.Windows.Forms.ToolStripButton toolStripButtonAbout;
        private System.Windows.Forms.ToolStripButton toolStripButtonServices;
        private System.Windows.Forms.ToolStripButton toolStripButtonSequencers;
        private System.Windows.Forms.ToolStripButton toolStripButtonAssociations;
        private System.Windows.Forms.ToolStripMenuItem трекиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonTracks;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem запросыToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonSQL;
    }
}

