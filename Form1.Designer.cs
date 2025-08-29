namespace CosmicTypes
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            btnShowResult = new Button();
            tbBlood = new TextBox();
            label2 = new Label();
            tbZodiac = new TextBox();
            label1 = new Label();
            imageList1 = new ImageList(components);
            menuStrip1 = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            내역불러오기ToolStripMenuItem = new ToolStripMenuItem();
            끝내기ToolStripMenuItem = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            cosmicTypesToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(btnShowResult);
            groupBox1.Controls.Add(tbBlood);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbZodiac);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(360, 411);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "사용자 입력";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(107, 37);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // btnShowResult
            // 
            btnShowResult.Location = new Point(55, 341);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Size = new Size(262, 51);
            btnShowResult.TabIndex = 4;
            btnShowResult.Text = "결과 보러가기";
            btnShowResult.UseVisualStyleBackColor = true;
            // 
            // tbBlood
            // 
            tbBlood.Location = new Point(55, 293);
            tbBlood.Name = "tbBlood";
            tbBlood.Size = new Size(262, 23);
            tbBlood.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 275);
            label2.Name = "label2";
            label2.Size = new Size(119, 15);
            label2.TabIndex = 2;
            label2.Text = "혈핵형을 입력하세요";
            // 
            // tbZodiac
            // 
            tbZodiac.Location = new Point(55, 234);
            tbZodiac.Name = "tbZodiac";
            tbZodiac.Size = new Size(262, 23);
            tbZodiac.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 216);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 0;
            label1.Text = "별자리를 입력하세요";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 도움말ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 내역불러오기ToolStripMenuItem, 끝내기ToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(43, 20);
            파일ToolStripMenuItem.Text = "파일";
            // 
            // 내역불러오기ToolStripMenuItem
            // 
            내역불러오기ToolStripMenuItem.Name = "내역불러오기ToolStripMenuItem";
            내역불러오기ToolStripMenuItem.Size = new Size(180, 22);
            내역불러오기ToolStripMenuItem.Text = "내역 불러오기";
            // 
            // 끝내기ToolStripMenuItem
            // 
            끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            끝내기ToolStripMenuItem.Size = new Size(180, 22);
            끝내기ToolStripMenuItem.Text = "끝내기";
            // 
            // 도움말ToolStripMenuItem
            // 
            도움말ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cosmicTypesToolStripMenuItem });
            도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            도움말ToolStripMenuItem.Size = new Size(55, 20);
            도움말ToolStripMenuItem.Text = "도움말";
            // 
            // cosmicTypesToolStripMenuItem
            // 
            cosmicTypesToolStripMenuItem.Name = "cosmicTypesToolStripMenuItem";
            cosmicTypesToolStripMenuItem.Size = new Size(180, 22);
            cosmicTypesToolStripMenuItem.Text = "Cosmic types";
            cosmicTypesToolStripMenuItem.Click += cosmicTypesToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 451);
            Controls.Add(groupBox1);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            Text = "CosmicTypes 3111장하영";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbZodiac;
        private Label label1;
        private Button btnShowResult;
        private TextBox tbBlood;
        private Label label2;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 내역불러오기ToolStripMenuItem;
        private ToolStripMenuItem 끝내기ToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem cosmicTypesToolStripMenuItem;
    }
}
