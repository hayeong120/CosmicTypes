
namespace CosmicTypes
{
    partial class FormAbout
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
            menuStrip1 = new MenuStrip();
            파일ToolStripMenuItem = new ToolStripMenuItem();
            내역불러오기ToolStripMenuItem = new ToolStripMenuItem();
            끝내기ToolStripMenuItem = new ToolStripMenuItem();
            도움말ToolStripMenuItem = new ToolStripMenuItem();
            cosmicTypesToolStripMenuItem = new ToolStripMenuItem();
            listBox1 = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일ToolStripMenuItem, 도움말ToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(384, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            파일ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 내역불러오기ToolStripMenuItem, 끝내기ToolStripMenuItem });
            파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            파일ToolStripMenuItem.Size = new Size(43, 20);
            파일ToolStripMenuItem.Text = "파일";
            파일ToolStripMenuItem.Click += 파일ToolStripMenuItem_Click;
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
            cosmicTypesToolStripMenuItem.Size = new Size(148, 22);
            cosmicTypesToolStripMenuItem.Text = "Cosmic Types";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "🌌 CosmicTypes", "CosmicTypes는 별자리(12)와 혈액형(4)을 조합해", "총 144가지 성격 분석과 조언을 제공하는 프로젝트입니다. ✨", "", "🔮 특징", "🌠 별자리 × 혈액형 기반 성격 분석", "💫 144가지 고유한 성격 해석", "📜 짧은 키워드가 아닌 조언 형태의 긴 글 제공", "🎨 포춘텔러 감성의 상징적 디자인", "", "🚀 사용 방법", "본인의 별자리 선택 (양자리 → 물고기자리)", "본인의 혈액형 선택 (A, B, O, AB)", "결과로 맞춤형 성격 해석과 조언 확인", "", "⚠️ 안내", "이 프로젝트는 재미와 엔터테인먼트용으로 제작되었습니다.", "과학적 근거가 없으니 참고용으로만 즐겨주세요!" });
            listBox1.Location = new Point(12, 27);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(360, 409);
            listBox1.TabIndex = 1;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 451);
            Controls.Add(listBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormAbout";
            Text = "CosmicTypes 3111장하영";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일ToolStripMenuItem;
        private ToolStripMenuItem 내역불러오기ToolStripMenuItem;
        private ToolStripMenuItem 끝내기ToolStripMenuItem;
        private ToolStripMenuItem 도움말ToolStripMenuItem;
        private ToolStripMenuItem cosmicTypesToolStripMenuItem;
        private ListBox listBox1;
    }
}