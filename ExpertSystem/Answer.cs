namespace ExpertSystemConsole
{
    enum QuestionType { SelectForm, Number };
    internal class Answer
    {
        public Func<Question?> NextQuestion;
        public QuestionType type;

        public string AnswerText;
        public int? AnswerInput;
        public Answer(Question? nextQuestion, string answer, QuestionType type = QuestionType.SelectForm)
        {
            AnswerInput = null;
            AnswerText = answer;
            this.type = type;
            NextQuestion = () => (nextQuestion);
        }
        public Answer(string answer, Func<Question> nextQuestion, QuestionType type = QuestionType.SelectForm)
        {
            AnswerInput = null;
            AnswerText = answer;
            this.type = type;
            NextQuestion = nextQuestion;
        }

        public void InputNumber(int AnswerInput) {
            if (type !=QuestionType.Number)
            {
                throw (new Exception("Wrong answer type"));
            }
            this.AnswerInput = AnswerInput;
        }
        public override string ToString()
        {
            return AnswerInput.HasValue ? AnswerInput.ToString() : AnswerText;
        }
    }
}
