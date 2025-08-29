namespace CosmicTypes
{
    public partial class Form1 : Form
    {
        private List<string> results = new List<string>();
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
                // 파일 존재 여부 확인으로 FileNotFoundException 방지
                if (File.Exists(filename))
                {
                    results = File.ReadAllLines(filename).ToList();
                }
                else
                {
                    // 파일이 없으면 빈 리스트로 초기화하고 사용자에게 알림
                    MessageBox.Show($"파일이 없습니다.\n{filename}", "파일 오류",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            string zodiac = tbZodiac.Text.Trim();
            string blood = tbBlood.Text.Trim().ToUpper(); // 혈액형은 대문자 처리

            if (string.IsNullOrWhiteSpace(zodiac) || string.IsNullOrWhiteSpace(blood))
            {
                MessageBox.Show("별자리와 혈액형을 모두 입력하세요!", "입력 오류",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // results 리스트가 null이 아닌 빈 리스트이므로 안전하게 FirstOrDefault 사용 가능
            string result = results.FirstOrDefault(r =>
            {
                var cols = r.Split('|');
                // cols가 2개 미만일 경우 IndexOutOfRangeException 방지
                if (cols.Length < 3) return false;
                return cols[0].Trim() == zodiac && cols[1].Trim() == blood;
            });

            if (result != null)
            {
                string advice = result.Split('|')[2].Trim();

                // FormResult 폼을 직접 띄움
                FormResult resultForm = new FormResult(zodiac, blood, advice);
                resultForm.ShowDialog(); // Show() 대신 ShowDialog()를 사용하여 모달 창으로 표시

                // history.csv에 저장
                File.AppendAllText("history.csv", $"{DateTime.Now}|{zodiac}|{blood}|{advice}{Environment.NewLine}");
            }
            else
            {
                MessageBox.Show("해당 별자리와 혈액형에 맞는 결과가 없습니다.", "검색 실패",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void 내역불러오기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormHistory form = new FormHistory())
            {
                form.ShowDialog();
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cosmicTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout form = new FormAbout();
            form.ShowDialog();
        }
    }
}
