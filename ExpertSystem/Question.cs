using ExpertSystem;

namespace ExpertSystemConsole
{
    internal class Question
    {
        public readonly string questionText;
        public List<Answer>? PickedAnswers;
        public readonly QuestionId id;
        public List<Answer> Answers;
        public Question(string question, QuestionId id)
        {
            PickedAnswers = new();
            this.id = id;
            questionText = question;
            Answers = new();
        }

        public void AddAnswer(Answer a)
        {
            Answers.Add(a);
        }
        
        public override string ToString()
        {
            return questionText;
        }
    }
}
