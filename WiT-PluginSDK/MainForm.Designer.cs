
namespace WiT_PluginSDK
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        System.ComponentModel.IContainer components = null;

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
        void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.упаковатьПлагинсохранитьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.сформироватьПроектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеБиблиотекиПлагинаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.обSDKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.API = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Help = new System.Windows.Forms.TextBox();
            this.Version = new System.Windows.Forms.TextBox();
            this.CommandReg = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.disChk = new System.Windows.Forms.CheckBox();
            this.ccControl = new System.Windows.Forms.CheckBox();
            this.debug = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Gainsboro;
            this.menuStrip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.справкаToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(749, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.упаковатьПлагинсохранитьПроектToolStripMenuItem,
            this.toolStripSeparator1,
            this.сформироватьПроектToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.toolStripMenuItem4});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem2.Text = "Проект";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(273, 22);
            this.toolStripMenuItem3.Text = "Открыть плагин";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // упаковатьПлагинсохранитьПроектToolStripMenuItem
            // 
            this.упаковатьПлагинсохранитьПроектToolStripMenuItem.Name = "упаковатьПлагинсохранитьПроектToolStripMenuItem";
            this.упаковатьПлагинсохранитьПроектToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.упаковатьПлагинсохранитьПроектToolStripMenuItem.Text = "Упаковать плагин";
            this.упаковатьПлагинсохранитьПроектToolStripMenuItem.Click += new System.EventHandler(this.упаковатьПлагинToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(270, 6);
            // 
            // сформироватьПроектToolStripMenuItem
            // 
            this.сформироватьПроектToolStripMenuItem.Name = "сформироватьПроектToolStripMenuItem";
            this.сформироватьПроектToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.сформироватьПроектToolStripMenuItem.Text = "Сформировать проект";
            this.сформироватьПроектToolStripMenuItem.Click += new System.EventHandler(this.сформироватьПроектToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(273, 22);
            this.toolStripMenuItem1.Text = "Очистить сформированный проект";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеБиблиотекиПлагинаToolStripMenuItem,
            this.купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem,
            this.toolStripSeparator2,
            this.обSDKToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // созданиеБиблиотекиПлагинаToolStripMenuItem
            // 
            this.созданиеБиблиотекиПлагинаToolStripMenuItem.Name = "созданиеБиблиотекиПлагинаToolStripMenuItem";
            this.созданиеБиблиотекиПлагинаToolStripMenuItem.Size = new System.Drawing.Size(382, 22);
            this.созданиеБиблиотекиПлагинаToolStripMenuItem.Text = "Разработка плагина и использование SDK";
            this.созданиеБиблиотекиПлагинаToolStripMenuItem.Click += new System.EventHandler(this.созданиеБиблиотекиПлагинаToolStripMenuItem_Click);
            // 
            // купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem
            // 
            this.купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem.Name = "купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem";
            this.купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem.Size = new System.Drawing.Size(382, 22);
            this.купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem.Text = "Купить Premium (для использования плагинов в боте)";
            this.купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem.Click += new System.EventHandler(this.купитьPremiumДляWiTToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(379, 6);
            // 
            // обSDKToolStripMenuItem
            // 
            this.обSDKToolStripMenuItem.Name = "обSDKToolStripMenuItem";
            this.обSDKToolStripMenuItem.Size = new System.Drawing.Size(382, 22);
            this.обSDKToolStripMenuItem.Text = "Версия SDK";
            this.обSDKToolStripMenuItem.Click += new System.EventHandler(this.обSDKToolStripMenuItem_Click);
            // 
            // PName
            // 
            this.PName.Location = new System.Drawing.Point(87, 28);
            this.PName.Name = "PName";
            this.PName.Size = new System.Drawing.Size(212, 22);
            this.PName.TabIndex = 2;
            this.PName.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Author);
            this.groupBox1.Controls.Add(this.API);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Help);
            this.groupBox1.Controls.Add(this.Version);
            this.groupBox1.Controls.Add(this.CommandReg);
            this.groupBox1.Controls.Add(this.PName);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 329);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки проекта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Автор:";
            // 
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(65, 127);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(234, 22);
            this.Author.TabIndex = 5;
            this.Author.TabStop = false;
            // 
            // API
            // 
            this.API.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.API.FormattingEnabled = true;
            this.API.Items.AddRange(new object[] {
            "1.0"});
            this.API.Location = new System.Drawing.Point(226, 59);
            this.API.Name = "API";
            this.API.Size = new System.Drawing.Size(73, 24);
            this.API.TabIndex = 4;
            this.API.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(187, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "API:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Справка:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Версия:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Команда:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название:";
            // 
            // Help
            // 
            this.Help.Location = new System.Drawing.Point(80, 163);
            this.Help.Multiline = true;
            this.Help.Name = "Help";
            this.Help.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Help.Size = new System.Drawing.Size(219, 154);
            this.Help.TabIndex = 2;
            this.Help.TabStop = false;
            // 
            // Version
            // 
            this.Version.Location = new System.Drawing.Point(80, 61);
            this.Version.Name = "Version";
            this.Version.Size = new System.Drawing.Size(101, 22);
            this.Version.TabIndex = 2;
            this.Version.TabStop = false;
            // 
            // CommandReg
            // 
            this.CommandReg.Location = new System.Drawing.Point(87, 95);
            this.CommandReg.Name = "CommandReg";
            this.CommandReg.Size = new System.Drawing.Size(212, 22);
            this.CommandReg.TabIndex = 2;
            this.CommandReg.TabStop = false;
            // 
            // saveFile
            // 
            this.saveFile.Filter = "Файл плагина WiT|*.wit";
            this.saveFile.Title = "Сохранить плагин как";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(342, 36);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 94);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Добавление файлов проекта (сначала сформируйте проект)";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(193, 24);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 25);
            this.button6.TabIndex = 1;
            this.button6.TabStop = false;
            this.button6.Text = "Импортировать";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(217, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 23);
            this.button3.TabIndex = 1;
            this.button3.TabStop = false;
            this.button3.Text = "Импортировать";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Дополнительные файлы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Библиотека плагина:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.disChk);
            this.groupBox3.Controls.Add(this.ccControl);
            this.groupBox3.Controls.Add(this.debug);
            this.groupBox3.Controls.Add(this.button8);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(342, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(395, 71);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Конфигурация [НЕДОСТУПНО]";
            // 
            // disChk
            // 
            this.disChk.AutoSize = true;
            this.disChk.Location = new System.Drawing.Point(157, 21);
            this.disChk.Name = "disChk";
            this.disChk.Size = new System.Drawing.Size(194, 20);
            this.disChk.TabIndex = 2;
            this.disChk.TabStop = false;
            this.disChk.Text = "Отключить после установки";
            this.disChk.UseVisualStyleBackColor = true;
            this.disChk.Visible = false;
            // 
            // ccControl
            // 
            this.ccControl.AutoSize = true;
            this.ccControl.Location = new System.Drawing.Point(35, 45);
            this.ccControl.Name = "ccControl";
            this.ccControl.Size = new System.Drawing.Size(321, 20);
            this.ccControl.TabIndex = 2;
            this.ccControl.TabStop = false;
            this.ccControl.Text = "Отключить ввод параметров при вызове плагина";
            this.ccControl.UseVisualStyleBackColor = true;
            this.ccControl.Visible = false;
            // 
            // debug
            // 
            this.debug.AutoSize = true;
            this.debug.Location = new System.Drawing.Point(35, 21);
            this.debug.Name = "debug";
            this.debug.Size = new System.Drawing.Size(118, 20);
            this.debug.TabIndex = 2;
            this.debug.TabStop = false;
            this.debug.Text = "Режим отладки";
            this.debug.UseVisualStyleBackColor = true;
            this.debug.Visible = false;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(250, 188);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(116, 48);
            this.button8.TabIndex = 1;
            this.button8.TabStop = false;
            this.button8.Text = "Удалить все файлы";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Controls.Add(this.button2);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(342, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(395, 152);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Удаление файлов проекта (сначала добавьте их)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(17, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 116);
            this.listBox1.TabIndex = 2;
            this.listBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(277, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 45);
            this.button2.TabIndex = 1;
            this.button2.TabStop = false;
            this.button2.Text = "Удалить выделенный";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(277, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 39);
            this.button7.TabIndex = 1;
            this.button7.TabStop = false;
            this.button7.Text = "Удалить все файлы";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(297, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Удаление:";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(273, 22);
            this.toolStripMenuItem4.Text = "Закрыть проект";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(270, 6);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 374);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiT PluginSDK";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        System.Windows.Forms.MenuStrip menuStrip;
        System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        System.Windows.Forms.ToolStripMenuItem обSDKToolStripMenuItem;
        System.Windows.Forms.TextBox PName;
        System.Windows.Forms.GroupBox groupBox1;
        System.Windows.Forms.Label label1;
        System.Windows.Forms.Label label2;
        System.Windows.Forms.TextBox Version;
        System.Windows.Forms.Label label3;
        System.Windows.Forms.ComboBox API;
        System.Windows.Forms.Label label5;
        System.Windows.Forms.TextBox Help;
        System.Windows.Forms.OpenFileDialog openFile;
        System.Windows.Forms.SaveFileDialog saveFile;
        System.Windows.Forms.Label label6;
        System.Windows.Forms.TextBox Author;
        System.Windows.Forms.Label label7;
        System.Windows.Forms.TextBox CommandReg;
        System.Windows.Forms.GroupBox groupBox2;
        System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        System.Windows.Forms.ToolStripMenuItem сформироватьПроектToolStripMenuItem;
        System.Windows.Forms.Label label8;
        System.Windows.Forms.Label label9;
        System.Windows.Forms.Button button3;
        System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        System.Windows.Forms.GroupBox groupBox3;
        System.Windows.Forms.Button button8;
        System.Windows.Forms.CheckBox debug;
        System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        System.Windows.Forms.ToolStripMenuItem упаковатьПлагинсохранитьПроектToolStripMenuItem;
        System.Windows.Forms.Button button6;
        System.Windows.Forms.GroupBox groupBox4;
        System.Windows.Forms.ListBox listBox1;
        System.Windows.Forms.Button button2;
        System.Windows.Forms.Button button7;
        System.Windows.Forms.Label label11;
        System.Windows.Forms.CheckBox ccControl;
        System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        System.Windows.Forms.ToolStripMenuItem созданиеБиблиотекиПлагинаToolStripMenuItem;
        System.Windows.Forms.ToolStripMenuItem купитьPremiumдляИспользованияПлагиновВБотеToolStripMenuItem;
        private System.Windows.Forms.CheckBox disChk;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

