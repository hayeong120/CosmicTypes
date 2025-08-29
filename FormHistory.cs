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
    public partial class FormHistory : Form
    {
        List<string> history;
        Form1 form1;
        public FormHistory(Form1 form)
        {
            form1 = form;
            InitializeComponent();
            UpdateHistory();
        }

        private void LoadHistory()
        {
            try
            {
                string filename = "history.csv";
                if (File.Exists(filename))
                {
                    history = File.ReadAllLines(filename).ToList();
                }
                else
                {
                    history = new List<string>();
                    // 파일이 없어도 에러 메시지는 띄우지 않고, 빈 리스트로 초기화
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근 권한이 없습니다.\n{ex.Message}", "파일 권한 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                history = new List<string>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                history = new List<string>();
            }
        }

        private void UpdateHistory()
        {
            LoadHistory();
            lbHistory.Items.Clear();
            if (history != null)
            {
                lbHistory.Items.AddRange(history.ToArray());
            }
        }

        private void cosmicTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
