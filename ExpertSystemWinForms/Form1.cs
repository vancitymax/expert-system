using ExpertSystem;

namespace ExpertSystemWinForms
{
    public partial class Form1 : Form
    {
        private Oracle expertSys = new Oracle();
        private bool mainMenuState = false;
        private bool isMultiAnswer = false;
        List<int> inputs = new();
        public Form1()
        {
            InitializeComponent();
        }

        void ToggleMainMenu()
        {
            mainMenuState = !mainMenuState;
            label1.Visible = !label1.Visible;
            StartBTN.Visible = !StartBTN.Visible;
            if (mainMenuState)
            {
                ExitBTN.Location = new Point(664, 393);
                ExitBTN.Width = 124;
                ExitBTN.Height = 45;
                ExitBTN.Font = new Font(FontFamily.GenericMonospace, 12);
                return;
            }
            ExitBTN.Location = new Point(255, 260);
            ExitBTN.Width = 284;
            ExitBTN.Height = 96;
            ExitBTN.Font = new Font("Segoe UI Black", 36);
            return;
        }
        void ToggleQuestionMenu()
        {
            QuestionLabel.Visible = !QuestionLabel.Visible;
            AnswerList.Visible = !AnswerList.Visible;
            AnswerBTN.Visible = !AnswerBTN.Visible;
        }
        void ToggleResult()
        {
            ResultLabel.Visible = !ResultLabel.Visible;
            ResultList.Visible = !ResultList.Visible;
        }
        void ToggleInputAnswer(bool state)
        {
            PhysikDMGInput.Visible = state;
            PhysikDMGText.Visible = state;
            MagikDMGInput.Visible = state;
            MagikDMGText.Visible = state;
            AnswerList.Visible = !state;
        }

        private void ExitBTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StartBTN_Click(object sender, EventArgs e)
        {
            ToggleMainMenu();
            ToggleQuestionMenu();
            AnswerList.Items.Clear();
            List<string> q = expertSys.GetCurrentQuestion().ToList();
            List<int> inputs = new();
            for (int i = 0; i < q.Count; i++)
            {
                if (i == 0) { QuestionLabel.Text = $"{q[i]}";  continue; }
                if (q[i].StartsWith("?"))
                {
                    inputs.Add(i);
                    continue;
                }
                AnswerList.Items.Add(q[i]);
            }
        }

        private void AnswerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isMultiAnswer)
                return;
            int iSelectedIndex = AnswerList.SelectedIndex;
            if (iSelectedIndex == -1)
                return;
            for (int iIndex = 0; iIndex < AnswerList.Items.Count; iIndex++)
                AnswerList.SetItemCheckState(iIndex, CheckState.Unchecked);
            AnswerList.SetItemCheckState(iSelectedIndex, CheckState.Checked);
        }

        private void AnswerBTN_Click(object sender, EventArgs e)
        {
            if (AnswerList.SelectedIndex==-1 && !isMultiAnswer)
            {
                return;  
            }

            if (inputs.Count == 0)
            {
                expertSys.Answer(AnswerList.SelectedIndex);
            }
            else
            {
                if (!Int32.TryParse(MagikDMGInput.Text, out _) || !Int32.TryParse(PhysikDMGInput.Text, out _))
                {
                    return;
                }
                for (int i = 0; i < inputs.Count; i++)
                {
                    int input;
                    if (i==0)
                    {
                        input = Int32.Parse(MagikDMGInput.Text);
                    }
                    else
                    {
                        input = Int32.Parse(PhysikDMGInput.Text);
                    }
                    if (i == inputs.Count - 1)
                    {
                        expertSys.Answer(inputs[i]-1, input, true);
                        break;
                    }
                    expertSys.Answer(inputs[i]-1, input);
                    ToggleInputAnswer(false);
                    isMultiAnswer = false;
                }
            }

            inputs.Clear();
            AnswerList.Items.Clear();
            if (expertSys.GetCurrentQuestion().Count() == 0)
            {
                var tmp = expertSys.GetAnswer().Split("\n");
                foreach (var res in tmp)
                {
                    ResultList.Items.Add(res);
                }

                ToggleResult();
                ToggleQuestionMenu();
                return;
            }
            List<string> q = expertSys.GetCurrentQuestion().ToList();
            for (int i = 0; i < q.Count; i++)
            {
                if (i == 0) { QuestionLabel.Text = $"{q[i]}"; continue; }
                if (q[i].StartsWith("?"))
                {
                    ToggleInputAnswer(true);
                    isMultiAnswer = true;
                    inputs.Add(i);
                    continue;
                }
                AnswerList.Items.Add(q[i]);
            }
        }
    }
}