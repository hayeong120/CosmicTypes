namespace CosmicTypes
{
    public partial class Form1 : Form
    {
        List<string> results;
        public Form1()
        {
            InitializeComponent();
            LoadResults();
        }
        private void LoadResults()
        {
            try
            {
                string filename = "results.csv";
                results = File.ReadAllLines(filename).ToList();
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show($"파일이 없습니다.\n{ex.Message}", "파일이 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"파일에 접근 권한이 없습니다.\n{ex.Message}", "파일 권한 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"알 수 없는 오류가 발생했습니다.\n{ex.Message}", "알 수 없는 오류!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string zodiac = tbZodiac.Text;
            string blood = tbBlood.Text;
        }


        private void 내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormHistory form = Application.OpenForms["FormHistory"] as FormHistory;
            if (form != null)
            {
                form.Activate();
            }
            else
            {
                form = new FormHistory(this);
                form.Show();
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
