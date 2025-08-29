using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CosmicTypes
{
    public partial class FormResult : Form
    {
        public FormResult(string zodiac, string blood, string message)
        {
            InitializeComponent();
            lbResult.Text = $"{zodiac} {blood}형 결과\n\n{message}";
        }

        private void btnRetry_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // no-op
        }


    }
}
