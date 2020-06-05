namespace Youtube_Video_Uploader
{
	partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.openFileButton1 = new Youtube_Video_Uploader.OpenFileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.youTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cancelButton1 = new Youtube_Video_Uploader.CancelButton();
            this.clearButton1 = new Youtube_Video_Uploader.ClearButton();
            this.clearButton2 = new Youtube_Video_Uploader.ClearButton();
            this.uploadButton1 = new Youtube_Video_Uploader.UploadButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.openFileButton1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(73, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(650, 201);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.panel1_DragEnter);
            this.panel1.DragLeave += new System.EventHandler(this.panel1_DragLeave);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // openFileButton1
            // 
            this.openFileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openFileButton1.BackColor = System.Drawing.Color.MediumPurple;
            this.openFileButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openFileButton1.ForeColor = System.Drawing.Color.White;
            this.openFileButton1.Location = new System.Drawing.Point(260, 114);
            this.openFileButton1.Name = "openFileButton1";
            this.openFileButton1.Size = new System.Drawing.Size(133, 33);
            this.openFileButton1.TabIndex = 2;
            this.openFileButton1.Text = "Выберите файл";
            this.openFileButton1.Click += new System.EventHandler(this.openFileButton1_Click);
            this.openFileButton1.Enter += new System.EventHandler(this.openFileButton1_Enter);
            this.openFileButton1.Leave += new System.EventHandler(this.openFileButton1_Leave);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.DarkGray;
            this.label2.Location = new System.Drawing.Point(257, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "или нажмите кнопку";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(236, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Перетащите файлы сюда";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.progressBar1.Location = new System.Drawing.Point(187, 89);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(278, 23);
            this.progressBar1.TabIndex = 3;
            this.progressBar1.Value = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(73, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Загрузка видео";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(73, 367);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(650, 24);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Введите название видео";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox2.Location = new System.Drawing.Point(73, 573);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(650, 24);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "Введите теги для видео";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.Enter += new System.EventHandler(this.textBox2_Enter);
            this.textBox2.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // textBox4
            // 
            this.textBox4.AutoSize = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox4.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox4.Location = new System.Drawing.Point(73, 415);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(650, 136);
            this.textBox4.TabIndex = 7;
            this.textBox4.Text = "Введите описание видео";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.textBox4.Enter += new System.EventHandler(this.textBox4_Enter);
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preferenceToolStripMenuItem,
            this.referenceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openfileToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openfileToolStripMenuItem
            // 
            this.openfileToolStripMenuItem.Name = "openfileToolStripMenuItem";
            this.openfileToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.openfileToolStripMenuItem.Text = "Выбрать файл";
            this.openfileToolStripMenuItem.Click += new System.EventHandler(this.openfileToolStripMenuItem_Click);
            // 
            // preferenceToolStripMenuItem
            // 
            this.preferenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem1});
            this.preferenceToolStripMenuItem.Name = "preferenceToolStripMenuItem";
            this.preferenceToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.preferenceToolStripMenuItem.Text = "Инструменты";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.youTubeToolStripMenuItem});
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.optionsToolStripMenuItem1.Text = "Настройки";
            // 
            // youTubeToolStripMenuItem
            // 
            this.youTubeToolStripMenuItem.Name = "youTubeToolStripMenuItem";
            this.youTubeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.youTubeToolStripMenuItem.Text = "YouTube";
            // 
            // referenceToolStripMenuItem
            // 
            this.referenceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.referenceToolStripMenuItem.Name = "referenceToolStripMenuItem";
            this.referenceToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.referenceToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(239, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.DarkGray;
            this.label6.Location = new System.Drawing.Point(250, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cancelButton1
            // 
            this.cancelButton1.BackColor = System.Drawing.Color.Firebrick;
            this.cancelButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.cancelButton1.ForeColor = System.Drawing.Color.White;
            this.cancelButton1.Location = new System.Drawing.Point(249, 118);
            this.cancelButton1.Name = "cancelButton1";
            this.cancelButton1.Size = new System.Drawing.Size(158, 43);
            this.cancelButton1.TabIndex = 4;
            this.cancelButton1.Text = "Отменить";
            this.cancelButton1.Click += new System.EventHandler(this.cancelButton1_Click);
            // 
            // clearButton1
            // 
            this.clearButton1.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.clearButton1.ForeColor = System.Drawing.Color.White;
            this.clearButton1.Location = new System.Drawing.Point(121, 104);
            this.clearButton1.Name = "clearButton1";
            this.clearButton1.Size = new System.Drawing.Size(181, 43);
            this.clearButton1.TabIndex = 3;
            this.clearButton1.Text = "Очистить";
            this.clearButton1.Click += new System.EventHandler(this.clearButton1_Click);
            // 
            // clearButton2
            // 
            this.clearButton2.BackColor = System.Drawing.Color.DarkGray;
            this.clearButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.clearButton2.ForeColor = System.Drawing.Color.White;
            this.clearButton2.Location = new System.Drawing.Point(121, 104);
            this.clearButton2.Name = "clearButton2";
            this.clearButton2.Size = new System.Drawing.Size(181, 43);
            this.clearButton2.TabIndex = 3;
            this.clearButton2.Text = "В начало";
            this.clearButton2.Click += new System.EventHandler(this.clearButton2_Click);
            // 
            // uploadButton1
            // 
            this.uploadButton1.BackColor = System.Drawing.Color.SeaGreen;
            this.uploadButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.uploadButton1.ForeColor = System.Drawing.Color.White;
            this.uploadButton1.Location = new System.Drawing.Point(347, 104);
            this.uploadButton1.Name = "uploadButton1";
            this.uploadButton1.Size = new System.Drawing.Size(181, 43);
            this.uploadButton1.TabIndex = 4;
            this.uploadButton1.Text = "Загрузить";
            this.uploadButton1.Click += new System.EventHandler(this.uploadButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 642);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Ultimate Uploader";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

        private System.Windows.Forms.Panel panel1;
        private OpenFileButton openFileButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceToolStripMenuItem;
        private UploadButton uploadButton1;
        private ClearButton clearButton1;
        private ClearButton clearButton2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripMenuItem openfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem youTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private CancelButton cancelButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
    }
}

