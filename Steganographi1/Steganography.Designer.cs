namespace Steganographi1
{
    partial class Steganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Steganography));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonSaveImage = new System.Windows.Forms.Button();
            this.pictureBoxPixel = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageRixel = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.buttonCode = new System.Windows.Forms.Button();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonLoadProcessImage = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxSourceImage = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessImage = new System.Windows.Forms.PictureBox();
            this.buttonSaveMassage = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBoxDecode = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonLoadSourceImage = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBoxBinCode = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageRixel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 547);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.buttonRestart);
            this.tabPage1.Controls.Add(this.buttonSaveImage);
            this.tabPage1.Controls.Add(this.pictureBoxPixel);
            this.tabPage1.Controls.Add(this.pictureBoxImageRixel);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.pictureBoxImage);
            this.tabPage1.Controls.Add(this.textBoxCode);
            this.tabPage1.Controls.Add(this.buttonCode);
            this.tabPage1.Controls.Add(this.buttonUpload);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 521);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ЗАШИФРОВАТЬ";
            // 
            // buttonRestart
            // 
            this.buttonRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRestart.Location = new System.Drawing.Point(283, 82);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(198, 42);
            this.buttonRestart.TabIndex = 10;
            this.buttonRestart.Text = "Начать сначала";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // buttonSaveImage
            // 
            this.buttonSaveImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveImage.Location = new System.Drawing.Point(500, 82);
            this.buttonSaveImage.Name = "buttonSaveImage";
            this.buttonSaveImage.Size = new System.Drawing.Size(282, 42);
            this.buttonSaveImage.TabIndex = 9;
            this.buttonSaveImage.Text = "Сохранить изображение";
            this.buttonSaveImage.UseVisualStyleBackColor = true;
            this.buttonSaveImage.Click += new System.EventHandler(this.buttonSaveImage_Click);
            // 
            // pictureBoxPixel
            // 
            this.pictureBoxPixel.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxPixel.Image")));
            this.pictureBoxPixel.Location = new System.Drawing.Point(367, 130);
            this.pictureBoxPixel.Name = "pictureBoxPixel";
            this.pictureBoxPixel.Size = new System.Drawing.Size(49, 47);
            this.pictureBoxPixel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPixel.TabIndex = 8;
            this.pictureBoxPixel.TabStop = false;
            // 
            // pictureBoxImageRixel
            // 
            this.pictureBoxImageRixel.Location = new System.Drawing.Point(422, 130);
            this.pictureBoxImageRixel.Name = "pictureBoxImageRixel";
            this.pictureBoxImageRixel.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxImageRixel.TabIndex = 7;
            this.pictureBoxImageRixel.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(94, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 15);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Вы загрузили:";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(6, 130);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 5;
            this.pictureBoxImage.TabStop = false;
            // 
            // textBoxCode
            // 
            this.textBoxCode.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxCode.Location = new System.Drawing.Point(283, 6);
            this.textBoxCode.Multiline = true;
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(499, 70);
            this.textBoxCode.TabIndex = 4;
            this.textBoxCode.Text = "Введите свой текст здесь";
            // 
            // buttonCode
            // 
            this.buttonCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCode.Location = new System.Drawing.Point(6, 41);
            this.buttonCode.Name = "buttonCode";
            this.buttonCode.Size = new System.Drawing.Size(271, 35);
            this.buttonCode.TabIndex = 3;
            this.buttonCode.Text = "Кодировать";
            this.buttonCode.UseVisualStyleBackColor = true;
            this.buttonCode.Click += new System.EventHandler(this.buttonCode_Click);
            // 
            // buttonUpload
            // 
            this.buttonUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonUpload.Location = new System.Drawing.Point(42, 6);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(235, 30);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Загрузить изображение";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.buttonLoadProcessImage);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.pictureBoxSourceImage);
            this.tabPage2.Controls.Add(this.pictureBoxProcessImage);
            this.tabPage2.Controls.Add(this.buttonSaveMassage);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBoxDecode);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.buttonLoadSourceImage);
            this.tabPage2.Controls.Add(this.buttonDecode);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 521);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "РАСШИФРОВАТЬ";
            // 
            // buttonLoadProcessImage
            // 
            this.buttonLoadProcessImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadProcessImage.Location = new System.Drawing.Point(44, 69);
            this.buttonLoadProcessImage.Name = "buttonLoadProcessImage";
            this.buttonLoadProcessImage.Size = new System.Drawing.Size(235, 54);
            this.buttonLoadProcessImage.TabIndex = 12;
            this.buttonLoadProcessImage.Text = "Загрузить обработанное изображение";
            this.buttonLoadProcessImage.UseVisualStyleBackColor = true;
            this.buttonLoadProcessImage.Click += new System.EventHandler(this.buttonLoadProcessImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBoxSourceImage
            // 
            this.pictureBoxSourceImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSourceImage.Image")));
            this.pictureBoxSourceImage.Location = new System.Drawing.Point(8, 153);
            this.pictureBoxSourceImage.Name = "pictureBoxSourceImage";
            this.pictureBoxSourceImage.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxSourceImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSourceImage.TabIndex = 10;
            this.pictureBoxSourceImage.TabStop = false;
            // 
            // pictureBoxProcessImage
            // 
            this.pictureBoxProcessImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxProcessImage.Image")));
            this.pictureBoxProcessImage.Location = new System.Drawing.Point(424, 153);
            this.pictureBoxProcessImage.Name = "pictureBoxProcessImage";
            this.pictureBoxProcessImage.Size = new System.Drawing.Size(360, 360);
            this.pictureBoxProcessImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxProcessImage.TabIndex = 9;
            this.pictureBoxProcessImage.TabStop = false;
            // 
            // buttonSaveMassage
            // 
            this.buttonSaveMassage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSaveMassage.Location = new System.Drawing.Point(519, 82);
            this.buttonSaveMassage.Name = "buttonSaveMassage";
            this.buttonSaveMassage.Size = new System.Drawing.Size(264, 41);
            this.buttonSaveMassage.TabIndex = 8;
            this.buttonSaveMassage.Text = "Сохранить сообщение";
            this.buttonSaveMassage.UseVisualStyleBackColor = true;
            this.buttonSaveMassage.Click += new System.EventHandler(this.buttonSaveMassage_Click);
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.DarkGray;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(8, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 13);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Вы загрузили:";
            // 
            // textBoxDecode
            // 
            this.textBoxDecode.ForeColor = System.Drawing.Color.DarkGray;
            this.textBoxDecode.Location = new System.Drawing.Point(285, 6);
            this.textBoxDecode.Multiline = true;
            this.textBoxDecode.Name = "textBoxDecode";
            this.textBoxDecode.ReadOnly = true;
            this.textBoxDecode.Size = new System.Drawing.Size(498, 70);
            this.textBoxDecode.TabIndex = 2;
            this.textBoxDecode.Text = "Ваше сообщение появится здесь";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(8, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // buttonLoadSourceImage
            // 
            this.buttonLoadSourceImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadSourceImage.Location = new System.Drawing.Point(44, 6);
            this.buttonLoadSourceImage.Name = "buttonLoadSourceImage";
            this.buttonLoadSourceImage.Size = new System.Drawing.Size(235, 54);
            this.buttonLoadSourceImage.TabIndex = 5;
            this.buttonLoadSourceImage.Text = "Загрузить исходное изображение";
            this.buttonLoadSourceImage.UseVisualStyleBackColor = true;
            this.buttonLoadSourceImage.Click += new System.EventHandler(this.buttonLoadSourceImage_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDecode.Location = new System.Drawing.Point(285, 82);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(228, 41);
            this.buttonDecode.TabIndex = 6;
            this.buttonDecode.Text = "Декодировать";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage4.Controls.Add(this.textBox8);
            this.tabPage4.Controls.Add(this.textBoxBinCode);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 521);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "ДЕМОНСТРАЦИЯ";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.DarkGray;
            this.textBox8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox8.Location = new System.Drawing.Point(3, 42);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(199, 37);
            this.textBox8.TabIndex = 1;
            this.textBox8.Text = "Ваше сообщение в двоичном представление: ";
            // 
            // textBoxBinCode
            // 
            this.textBoxBinCode.BackColor = System.Drawing.Color.DarkGray;
            this.textBoxBinCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBinCode.Location = new System.Drawing.Point(208, 3);
            this.textBoxBinCode.Multiline = true;
            this.textBoxBinCode.Name = "textBoxBinCode";
            this.textBoxBinCode.ReadOnly = true;
            this.textBoxBinCode.Size = new System.Drawing.Size(576, 129);
            this.textBoxBinCode.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Gray;
            this.tabPage5.Controls.Add(this.textBox3);
            this.tabPage5.Controls.Add(this.textBox7);
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.textBox6);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(792, 521);
            this.tabPage5.TabIndex = 3;
            this.tabPage5.Text = "СПРАВКА";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Gray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(3, 198);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(781, 59);
            this.textBox3.TabIndex = 3;
            this.textBox3.Text = "4. Если вы хотите сохранить сообщение из загруженного изображения нажмите кнопку " +
    "Сохранить сообщение.\r\n";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.Gray;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox7.Location = new System.Drawing.Point(3, 68);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(781, 59);
            this.textBox7.TabIndex = 2;
            this.textBox7.Text = "2. Если вы хотите сохранить изображение с зашифрованным сообщением нажмите кнопку" +
    " Сохранить изображение.";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(3, 133);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(781, 59);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "3. Чтобы декодировать скрытое сообщение с изображения, просто выберите изображени" +
    "е и нажмите кнопку Декодировать";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.Gray;
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox6.Location = new System.Drawing.Point(3, 3);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(781, 59);
            this.textBox6.TabIndex = 0;
            this.textBox6.Text = "1. Чтобы закодировать сообщение в изображение, выберите изображение, которое вы х" +
    "отите использовать, введите свой текст и нажмите кнопку Кодировать.";
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.tabControl1);
            this.Name = "Steganography";
            this.Text = "Steganography";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPixel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageRixel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.Button buttonCode;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.PictureBox pictureBoxImageRixel;
        private System.Windows.Forms.PictureBox pictureBoxPixel;
        private System.Windows.Forms.TextBox textBoxDecode;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button buttonLoadSourceImage;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button buttonSaveImage;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button buttonSaveMassage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxBinCode;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.PictureBox pictureBoxProcessImage;
        private System.Windows.Forms.PictureBox pictureBoxSourceImage;
        private System.Windows.Forms.Button buttonLoadProcessImage;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

