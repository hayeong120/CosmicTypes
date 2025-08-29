namespace CosmicTypes
{
    partial class FormResult
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
            lbResult = new ListBox();
            btnHome = new Button();
            SuspendLayout();
            // 
            // lbResult
            // 
            lbResult.FormattingEnabled = true;
            lbResult.ItemHeight = 15;
            lbResult.Location = new Point(12, 12);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(360, 379);
            lbResult.TabIndex = 0;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(12, 397);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(360, 42);
            btnHome.TabIndex = 1;
            btnHome.Text = "테스트 다시하기";
            btnHome.UseVisualStyleBackColor = true;
            // 
            // FormResult
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 451);
            Controls.Add(btnHome);
            Controls.Add(lbResult);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormResult";
            Text = "CosmicTypes 3111장하영";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbResult;
        private Button btnHome;
    }
}