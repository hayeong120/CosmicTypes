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
                MessageBox.Show($"������ �����ϴ�.\n{ex.Message}", "������ ���� ����!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            string zodiac = tbZodiac.Text;
            string blood = tbBlood.Text;
        }


        private void �����ҷ�����ToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
