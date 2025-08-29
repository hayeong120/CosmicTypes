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
                // ���� ���� ���� Ȯ������ FileNotFoundException ����
                if (File.Exists(filename))
                {
                    results = File.ReadAllLines(filename).ToList();
                }
                else
                {
                    // ������ ������ �� ����Ʈ�� �ʱ�ȭ�ϰ� ����ڿ��� �˸�
                    MessageBox.Show($"������ �����ϴ�.\n{filename}", "���� ����",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show($"���Ͽ� ���� ������ �����ϴ�.\n{ex.Message}", "���� ���� ����!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"�� �� ���� ������ �߻��߽��ϴ�.\n{ex.Message}", "�� �� ���� ����!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShowResult_Click(object sender, EventArgs e)
        {
            string zodiac = tbZodiac.Text.Trim();
            string blood = tbBlood.Text.Trim().ToUpper(); // �������� �빮�� ó��

            if (string.IsNullOrWhiteSpace(zodiac) || string.IsNullOrWhiteSpace(blood))
            {
                MessageBox.Show("���ڸ��� �������� ��� �Է��ϼ���!", "�Է� ����",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // results ����Ʈ�� null�� �ƴ� �� ����Ʈ�̹Ƿ� �����ϰ� FirstOrDefault ��� ����
            string result = results.FirstOrDefault(r =>
            {
                var cols = r.Split('|');
                // cols�� 2�� �̸��� ��� IndexOutOfRangeException ����
                if (cols.Length < 3) return false;
                return cols[0].Trim() == zodiac && cols[1].Trim() == blood;
            });

            if (result != null)
            {
                string advice = result.Split('|')[2].Trim();

                // FormResult ���� ���� ���
                FormResult resultForm = new FormResult(zodiac, blood, advice);
                resultForm.ShowDialog(); // Show() ��� ShowDialog()�� ����Ͽ� ��� â���� ǥ��

                // history.csv�� ����
                File.AppendAllText("history.csv", $"{DateTime.Now}|{zodiac}|{blood}|{advice}{Environment.NewLine}");
            }
            else
            {
                MessageBox.Show("�ش� ���ڸ��� �������� �´� ����� �����ϴ�.", "�˻� ����",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void �����ҷ�����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormHistory form = new FormHistory())
            {
                form.ShowDialog();
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
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
