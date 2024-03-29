namespace GetRandomPixivPic
{
    partial class Form1 : Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            Btn_GetPicture = new Button();
            Btn_Exit = new Button();
            shutdown_timer = new System.Windows.Forms.Timer(components);
            textbox_Console = new TextBox();
            Windows_Name = new Label();
            Btn_OpenPicURL = new Button();
            Btn_OpenAuthorURL = new Button();
            ProcessBar_GetPic = new ProgressBar();
            Btn_SavePicture = new Button();
            textBox_SaveFolder = new TextBox();
            Btn_SelectFolder = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ComboBox_SafeLevel = new ComboBox();
            Label_SafeLevel = new Label();
            ComboBox_ExcludeAI = new ComboBox();
            Label_ExcludeAI = new Label();
            ComboBox_PictureSize = new ComboBox();
            Lable_PictureSize = new Label();
            textBox_Tags = new TextBox();
            Label_Tags = new Label();
            textBox_UID = new TextBox();
            Label_UID = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackColor = Color.LightBlue;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(12, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(839, 800);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Btn_GetPicture
            // 
            Btn_GetPicture.AutoSize = true;
            Btn_GetPicture.BackColor = Color.FromArgb(128, 255, 108);
            Btn_GetPicture.BackgroundImageLayout = ImageLayout.None;
            Btn_GetPicture.FlatAppearance.BorderColor = Color.Linen;
            Btn_GetPicture.FlatAppearance.BorderSize = 0;
            Btn_GetPicture.FlatAppearance.MouseDownBackColor = Color.FromArgb(98, 235, 88);
            Btn_GetPicture.FlatAppearance.MouseOverBackColor = Color.FromArgb(118, 245, 98);
            Btn_GetPicture.FlatStyle = FlatStyle.Flat;
            Btn_GetPicture.Location = new Point(857, 804);
            Btn_GetPicture.Name = "Btn_GetPicture";
            Btn_GetPicture.Size = new Size(377, 39);
            Btn_GetPicture.TabIndex = 1;
            Btn_GetPicture.Text = "获取图片";
            Btn_GetPicture.UseVisualStyleBackColor = false;
            Btn_GetPicture.Click += Btn_GetPicture_Click;
            // 
            // Btn_Exit
            // 
            Btn_Exit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Exit.AutoSize = true;
            Btn_Exit.BackColor = SystemColors.AppWorkspace;
            Btn_Exit.BackgroundImageLayout = ImageLayout.None;
            Btn_Exit.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 255);
            Btn_Exit.FlatAppearance.BorderSize = 0;
            Btn_Exit.FlatAppearance.MouseOverBackColor = Color.Gray;
            Btn_Exit.FlatStyle = FlatStyle.Flat;
            Btn_Exit.Location = new Point(1198, 7);
            Btn_Exit.Name = "Btn_Exit";
            Btn_Exit.Size = new Size(36, 30);
            Btn_Exit.TabIndex = 2;
            Btn_Exit.Text = "x";
            Btn_Exit.UseVisualStyleBackColor = false;
            Btn_Exit.Click += button2_Click;
            // 
            // shutdown_timer
            // 
            shutdown_timer.Interval = 10;
            // 
            // textbox_Console
            // 
            textbox_Console.BackColor = Color.LightSteelBlue;
            textbox_Console.BorderStyle = BorderStyle.FixedSingle;
            textbox_Console.ForeColor = SystemColors.WindowText;
            textbox_Console.Location = new Point(857, 43);
            textbox_Console.Multiline = true;
            textbox_Console.Name = "textbox_Console";
            textbox_Console.ReadOnly = true;
            textbox_Console.Size = new Size(377, 276);
            textbox_Console.TabIndex = 4;
            // 
            // Windows_Name
            // 
            Windows_Name.Anchor = AnchorStyles.Top;
            Windows_Name.AutoSize = true;
            Windows_Name.FlatStyle = FlatStyle.Flat;
            Windows_Name.Font = new Font("Segoe Print", 9.07563F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Windows_Name.Location = new Point(573, 7);
            Windows_Name.Name = "Windows_Name";
            Windows_Name.Size = new Size(149, 26);
            Windows_Name.TabIndex = 6;
            Windows_Name.Text = "Pixiv 随机图片获取";
            Windows_Name.TextAlign = ContentAlignment.MiddleCenter;
            Windows_Name.MouseDown += DragForm;
            // 
            // Btn_OpenPicURL
            // 
            Btn_OpenPicURL.BackColor = Color.White;
            Btn_OpenPicURL.FlatAppearance.BorderColor = Color.Plum;
            Btn_OpenPicURL.FlatAppearance.BorderSize = 0;
            Btn_OpenPicURL.FlatAppearance.MouseDownBackColor = Color.Plum;
            Btn_OpenPicURL.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            Btn_OpenPicURL.FlatStyle = FlatStyle.Flat;
            Btn_OpenPicURL.ForeColor = Color.Black;
            Btn_OpenPicURL.Location = new Point(857, 395);
            Btn_OpenPicURL.Name = "Btn_OpenPicURL";
            Btn_OpenPicURL.Size = new Size(377, 29);
            Btn_OpenPicURL.TabIndex = 7;
            Btn_OpenPicURL.Text = "打开图片首页";
            Btn_OpenPicURL.UseVisualStyleBackColor = false;
            Btn_OpenPicURL.Click += LinkClicked;
            // 
            // Btn_OpenAuthorURL
            // 
            Btn_OpenAuthorURL.BackColor = Color.White;
            Btn_OpenAuthorURL.FlatAppearance.BorderColor = Color.Plum;
            Btn_OpenAuthorURL.FlatAppearance.BorderSize = 0;
            Btn_OpenAuthorURL.FlatAppearance.MouseDownBackColor = Color.Plum;
            Btn_OpenAuthorURL.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            Btn_OpenAuthorURL.FlatStyle = FlatStyle.Flat;
            Btn_OpenAuthorURL.ForeColor = Color.Black;
            Btn_OpenAuthorURL.Location = new Point(857, 430);
            Btn_OpenAuthorURL.Name = "Btn_OpenAuthorURL";
            Btn_OpenAuthorURL.Size = new Size(377, 29);
            Btn_OpenAuthorURL.TabIndex = 8;
            Btn_OpenAuthorURL.Text = "打开画师主页";
            Btn_OpenAuthorURL.UseVisualStyleBackColor = false;
            Btn_OpenAuthorURL.Click += LinkClicked;
            // 
            // ProcessBar_GetPic
            // 
            ProcessBar_GetPic.Location = new Point(857, 767);
            ProcessBar_GetPic.Name = "ProcessBar_GetPic";
            ProcessBar_GetPic.Size = new Size(377, 31);
            ProcessBar_GetPic.TabIndex = 9;
            // 
            // Btn_SavePicture
            // 
            Btn_SavePicture.BackColor = Color.White;
            Btn_SavePicture.FlatAppearance.BorderColor = Color.Plum;
            Btn_SavePicture.FlatAppearance.BorderSize = 0;
            Btn_SavePicture.FlatAppearance.MouseDownBackColor = Color.Plum;
            Btn_SavePicture.FlatAppearance.MouseOverBackColor = Color.FromArgb(224, 224, 224);
            Btn_SavePicture.FlatStyle = FlatStyle.Flat;
            Btn_SavePicture.ForeColor = Color.Black;
            Btn_SavePicture.Location = new Point(857, 360);
            Btn_SavePicture.Name = "Btn_SavePicture";
            Btn_SavePicture.Size = new Size(377, 29);
            Btn_SavePicture.TabIndex = 10;
            Btn_SavePicture.Text = "保存图片至选择的文件夹";
            Btn_SavePicture.UseVisualStyleBackColor = false;
            Btn_SavePicture.Click += Btn_SavePicture_Click;
            // 
            // textBox_SaveFolder
            // 
            textBox_SaveFolder.Location = new Point(857, 325);
            textBox_SaveFolder.Name = "textBox_SaveFolder";
            textBox_SaveFolder.ReadOnly = true;
            textBox_SaveFolder.Size = new Size(268, 27);
            textBox_SaveFolder.TabIndex = 11;
            // 
            // Btn_SelectFolder
            // 
            Btn_SelectFolder.BackColor = Color.White;
            Btn_SelectFolder.FlatAppearance.BorderSize = 0;
            Btn_SelectFolder.FlatAppearance.MouseDownBackColor = Color.FromArgb(224, 224, 224);
            Btn_SelectFolder.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 255, 255);
            Btn_SelectFolder.FlatStyle = FlatStyle.Flat;
            Btn_SelectFolder.Location = new Point(1131, 325);
            Btn_SelectFolder.Name = "Btn_SelectFolder";
            Btn_SelectFolder.Size = new Size(103, 29);
            Btn_SelectFolder.TabIndex = 12;
            Btn_SelectFolder.Text = "选择文件夹";
            Btn_SelectFolder.UseVisualStyleBackColor = false;
            Btn_SelectFolder.Click += Btn_SelectFolder_Click;
            // 
            // ComboBox_SafeLevel
            // 
            ComboBox_SafeLevel.BackColor = Color.White;
            ComboBox_SafeLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_SafeLevel.FlatStyle = FlatStyle.Flat;
            ComboBox_SafeLevel.ImeMode = ImeMode.NoControl;
            ComboBox_SafeLevel.Items.AddRange(new object[] { "安全", "危险", "混合" });
            ComboBox_SafeLevel.Location = new Point(932, 614);
            ComboBox_SafeLevel.Name = "ComboBox_SafeLevel";
            ComboBox_SafeLevel.Size = new Size(302, 28);
            ComboBox_SafeLevel.TabIndex = 13;
            ComboBox_SafeLevel.SelectedIndexChanged += ComboBox_SafeLevel_SelectedIndexChanged;
            // 
            // Label_SafeLevel
            // 
            Label_SafeLevel.AutoSize = true;
            Label_SafeLevel.ForeColor = Color.FromArgb(64, 255, 64);
            Label_SafeLevel.Location = new Point(857, 617);
            Label_SafeLevel.Name = "Label_SafeLevel";
            Label_SafeLevel.Size = new Size(69, 20);
            Label_SafeLevel.TabIndex = 14;
            Label_SafeLevel.Text = "安全等级";
            // 
            // ComboBox_ExcludeAI
            // 
            ComboBox_ExcludeAI.BackColor = Color.White;
            ComboBox_ExcludeAI.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_ExcludeAI.FlatStyle = FlatStyle.Flat;
            ComboBox_ExcludeAI.Items.AddRange(new object[] { "排除", "包含" });
            ComboBox_ExcludeAI.Location = new Point(932, 666);
            ComboBox_ExcludeAI.Name = "ComboBox_ExcludeAI";
            ComboBox_ExcludeAI.Size = new Size(302, 28);
            ComboBox_ExcludeAI.TabIndex = 15;
            // 
            // Label_ExcludeAI
            // 
            Label_ExcludeAI.AutoSize = true;
            Label_ExcludeAI.ForeColor = Color.White;
            Label_ExcludeAI.Location = new Point(872, 669);
            Label_ExcludeAI.Name = "Label_ExcludeAI";
            Label_ExcludeAI.Size = new Size(54, 20);
            Label_ExcludeAI.TabIndex = 16;
            Label_ExcludeAI.Text = "AI作品";
            // 
            // ComboBox_PictureSize
            // 
            ComboBox_PictureSize.BackColor = Color.White;
            ComboBox_PictureSize.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboBox_PictureSize.FlatStyle = FlatStyle.Flat;
            ComboBox_PictureSize.Items.AddRange(new object[] { "原图", "正常", "小型", "预览", "迷你" });
            ComboBox_PictureSize.Location = new Point(932, 718);
            ComboBox_PictureSize.Name = "ComboBox_PictureSize";
            ComboBox_PictureSize.Size = new Size(302, 28);
            ComboBox_PictureSize.TabIndex = 17;
            // 
            // Lable_PictureSize
            // 
            Lable_PictureSize.AutoSize = true;
            Lable_PictureSize.ForeColor = Color.White;
            Lable_PictureSize.Location = new Point(857, 721);
            Lable_PictureSize.Name = "Lable_PictureSize";
            Lable_PictureSize.Size = new Size(69, 20);
            Lable_PictureSize.TabIndex = 18;
            Lable_PictureSize.Text = "图片规格";
            // 
            // textBox_Tags
            // 
            textBox_Tags.BorderStyle = BorderStyle.FixedSingle;
            textBox_Tags.Location = new Point(857, 485);
            textBox_Tags.Multiline = true;
            textBox_Tags.Name = "textBox_Tags";
            textBox_Tags.Size = new Size(377, 62);
            textBox_Tags.TabIndex = 19;
            // 
            // Label_Tags
            // 
            Label_Tags.AutoSize = true;
            Label_Tags.ForeColor = SystemColors.HotTrack;
            Label_Tags.Location = new Point(920, 462);
            Label_Tags.Name = "Label_Tags";
            Label_Tags.Size = new Size(256, 20);
            Label_Tags.TabIndex = 20;
            Label_Tags.Text = "Tag标签(使用英文逗号隔开多个标签)";
            // 
            // textBox_UID
            // 
            textBox_UID.BorderStyle = BorderStyle.FixedSingle;
            textBox_UID.Location = new Point(857, 573);
            textBox_UID.Name = "textBox_UID";
            textBox_UID.Size = new Size(377, 27);
            textBox_UID.TabIndex = 21;
            textBox_UID.TextAlign = HorizontalAlignment.Center;
            // 
            // Label_UID
            // 
            Label_UID.AutoSize = true;
            Label_UID.ForeColor = SystemColors.HotTrack;
            Label_UID.Location = new Point(1000, 550);
            Label_UID.Name = "Label_UID";
            Label_UID.Size = new Size(84, 20);
            Label_UID.TabIndex = 22;
            Label_UID.Text = "指定画师ID";
            // 
            // Form1
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(1246, 855);
            Controls.Add(Label_UID);
            Controls.Add(textBox_UID);
            Controls.Add(Label_Tags);
            Controls.Add(textBox_Tags);
            Controls.Add(Lable_PictureSize);
            Controls.Add(ComboBox_PictureSize);
            Controls.Add(Label_ExcludeAI);
            Controls.Add(ComboBox_ExcludeAI);
            Controls.Add(Label_SafeLevel);
            Controls.Add(ComboBox_SafeLevel);
            Controls.Add(Btn_SelectFolder);
            Controls.Add(textBox_SaveFolder);
            Controls.Add(Btn_SavePicture);
            Controls.Add(ProcessBar_GetPic);
            Controls.Add(Btn_OpenAuthorURL);
            Controls.Add(Btn_OpenPicURL);
            Controls.Add(Windows_Name);
            Controls.Add(textbox_Console);
            Controls.Add(Btn_Exit);
            Controls.Add(Btn_GetPicture);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pixiv图片获取";
            MouseDown += DragForm;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Btn_GetPicture;
        private Button Btn_Exit;
        private System.Windows.Forms.Timer shutdown_timer;
        private TextBox textbox_Console;
        private Label Windows_Name;
        private Button Btn_OpenPicURL;
        private Button Btn_OpenAuthorURL;
        private ProgressBar ProcessBar_GetPic;
        private Button Btn_SavePicture;
        private TextBox textBox_SaveFolder;
        private Button Btn_SelectFolder;
        private FolderBrowserDialog folderBrowserDialog1;
        private ComboBox ComboBox_SafeLevel;
        private Label Label_SafeLevel;
        private ComboBox ComboBox_ExcludeAI;
        private Label Label_ExcludeAI;
        private ComboBox ComboBox_PictureSize;
        private Label Lable_PictureSize;
        private TextBox textBox_Tags;
        private Label Label_Tags;
        private TextBox textBox_UID;
        private Label Label_UID;
    }
}
