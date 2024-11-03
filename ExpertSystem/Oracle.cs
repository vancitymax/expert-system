using ExpertSystemConsole;
using System.Text;

namespace ExpertSystem
{
    public enum QuestionId {
        spammers, farmState, directSpells, dmg, baffType, enemyBaffs, enemyInvis, supportType, canCatch, mainAttribute,
        enemyPassive, heroRole, missing, canDoObjective, canDeffend, canFight, enemyPos, stage, carrySave, enemyOnVision, canBuy, role};
    public class Oracle
    {
        private Question? currentQuestion;
        private Dictionary<QuestionId, Question> answers;
        private int CounterID = 0;
        public Oracle()
        {
            answers = new();
            Init();
        }
        void Init()
        {
            var q22 = new Question("Чи є у ворогів спамери?(брісталбек, скаймаг, тощо)?", QuestionId.spammers);
            q22.AddAnswer(new Answer(null, "Так"));
            q22.AddAnswer(new Answer(null, "Ні"));

            var q21 = new Question("Який у вас герой?", QuestionId.farmState);
            q21.AddAnswer(new Answer(null, "Ближній бій"));
            q21.AddAnswer(new Answer(null, "Стрілець"));
            q21.AddAnswer(new Answer(null, "Маг"));
            q21.AddAnswer(new Answer(null, "Немає часу на фарм"));

            var q20 = new Question("Більшість направлених здібностей?", QuestionId.directSpells);
            q20.AddAnswer(new Answer(null, "Так"));
            q20.AddAnswer(new Answer(null, "Ні"));

            var q19 = new Question("Скільки % отримується урона?", QuestionId.dmg);
            var tmp2 = () => 100 - answers[QuestionId.dmg].PickedAnswers[0].AnswerInput > answers[QuestionId.dmg].PickedAnswers[0].AnswerInput;
            q19.AddAnswer(new Answer("Фізичний", () => tmp2() ? q20 : null, QuestionType.Number));
            q19.AddAnswer(new Answer("Магічний", () => tmp2() ? q20 : null, QuestionType.Number));

            var q18 = new Question("Який баф треба?", QuestionId.baffType);
            q18.AddAnswer(new Answer(null, "Урон"));
            q18.AddAnswer(new Answer(null, "Швидкість атаки"));
            q18.AddAnswer(new Answer(null, "Захист від направлених заклинань"));

            var q17 = new Question("Чи мають ворожі бафи які їх рятують?", QuestionId.enemyBaffs);
            q17.AddAnswer(new Answer(null, "Так"));
            q17.AddAnswer(new Answer(null, "Ні"));

            var q16 = new Question("Чи мають ворожі герої невидимість?", QuestionId.enemyInvis);
            q16.AddAnswer(new Answer(null, "Так"));
            q16.AddAnswer(new Answer(q17, "Ні"));

            var q15 = new Question("Яка підтримка вам треба?", QuestionId.supportType);
            q15.AddAnswer(new Answer(q18, "Баф"));
            q15.AddAnswer(new Answer(q19, "Лікування"));
            q15.AddAnswer(new Answer(null, "Ескейп"));
            q15.AddAnswer(new Answer(q16, "Ловити ворога"));

            var q14 = new Question("Чи можете ви спіймати ціль?", QuestionId.canCatch);
            q14.AddAnswer(new Answer(null, "Так"));
            q14.AddAnswer(new Answer(q16, "Ні"));

            var q13 = new Question("Оберіть ваш основний атрибут:", QuestionId.mainAttribute);
            q13.AddAnswer(new Answer(q14, "Сила"));
            q13.AddAnswer(new Answer(q14, "Вдалість"));
            q13.AddAnswer(new Answer(q14, "Інтелект"));

            var q12 = new Question("Чи є у ворога сильна пасивна здібність", QuestionId.enemyPassive);
            q12.AddAnswer(new Answer(null, "Так"));
            q12.AddAnswer(new Answer(q13, "Ні"));

            var q11 = new Question("Оберіть вашу роль:", QuestionId.heroRole);
            q11.AddAnswer(new Answer(q12, "Вбивця"));
            q11.AddAnswer(new Answer(q13, "Стрілець"));
            q11.AddAnswer(new Answer(q13, "Маг"));
            q11.AddAnswer(new Answer(q13, "Танк"));
            q11.AddAnswer(new Answer(null, "Сплітпушер"));

            var tmp3 = () => answers[QuestionId.stage].PickedAnswers[0].ToString()=="Початок";
            var q10 = new Question("Чого вам не вистачає?", QuestionId.missing);
            q10.AddAnswer(new Answer("Виживання", ()=> tmp3() ? q22 : q19));
            q10.AddAnswer(new Answer(q11, "Урону"));
            q10.AddAnswer(new Answer(null, "Мани"));
            q10.AddAnswer(new Answer(q16, "Підтримки команди"));
            q10.AddAnswer(new Answer(q21, "Фарму"));

            var q9 = new Question("Чи може ваша команда забрати рошана або терментора?", QuestionId.canDoObjective);
            q9.AddAnswer(new Answer(null, "Так"));
            q9.AddAnswer(new Answer(null, "Ні"));

            var q8 = new Question("Чи готові ви захищатися?", QuestionId.canDeffend);
            q8.AddAnswer(new Answer(null, "Так"));
            q8.AddAnswer(new Answer(null, "Ні"));

            var q7 = new Question("Команда готова до битви?", QuestionId.canFight);
            q7.AddAnswer(new Answer(null, "Так"));
            q7.AddAnswer(new Answer(q9, "Ні"));

            var q6 = new Question("На якій стороні вороги знаходяться?", QuestionId.enemyPos);
            q6.AddAnswer(new Answer(q7, "Своїй"));
            q6.AddAnswer(new Answer(q8, "Вашій"));

            var q5 = new Question("Етап гри:", QuestionId.stage);
            q5.AddAnswer(new Answer(q10, "Початок"));
            q5.AddAnswer(new Answer(q10, "Середина"));
            q5.AddAnswer(new Answer(q10, "Лейт"));

            var q4 = new Question("Чи в безпеці кері (фармить під віжном)?", QuestionId.carrySave);
            q4.AddAnswer(new Answer(null, "Так"));
            q4.AddAnswer(new Answer(null, "Ні"));

            var q3 = new Question("Чи видно на мапі ворожих героїв?", QuestionId.enemyOnVision);
            q3.AddAnswer(new Answer(q6, "Так"));
            var tmp = () => answers[QuestionId.role].PickedAnswers[0].ToString();
            q3.AddAnswer(new Answer("Ні", ()=>tmp() == "4" || tmp() == "5" ? q4 : q4));//tmp not work

            var q2 = new Question("Чи достатньо грошей на новий предмет?", QuestionId.canBuy);
            q2.AddAnswer(new Answer(q5, "Так"));
            q2.AddAnswer(new Answer(q3, "Ні"));

            var q1 = new Question("Оберіть вашу роль:", QuestionId.role);
            q1.AddAnswer(new Answer(q2, "1"));
            q1.AddAnswer(new Answer(q2, "2"));
            q1.AddAnswer(new Answer(q2, "3"));
            q1.AddAnswer(new Answer(q2, "4"));
            q1.AddAnswer(new Answer(q2, "5"));
            currentQuestion = q1;
        }
        public IEnumerable<string> GetCurrentQuestion()
        {
            List<string> res = new();

            if (currentQuestion==null)
            {
                return res;
            }

            res.Add(currentQuestion.ToString());
            foreach (Answer a in currentQuestion.Answers)
            {
                res.Add(a.type == QuestionType.SelectForm? a.AnswerText: $"?{a.AnswerText}");
            }
            return res;
        }
        public void Answer(int index)
        {
            answers.Add(currentQuestion.id, currentQuestion);
            currentQuestion.PickedAnswers.Add(currentQuestion.Answers[index]);

            currentQuestion = currentQuestion.Answers[index].NextQuestion();
        }
        public void Answer(int index, int number, bool last = false)
        {
            currentQuestion.Answers[index].AnswerInput = number;
            currentQuestion.PickedAnswers.Add(currentQuestion.Answers[index]);

            if (last)
            {
                answers.Add(currentQuestion.id, currentQuestion);
                currentQuestion = currentQuestion.Answers[index].NextQuestion();
            }
        }
        public string GetAnswer()
        {
            if (currentQuestion!=null)
            {
                throw new Exception("Not all questions have ansvered");
            }
            var results = Results.GetResult(answers);

            float max = results.Max(x=>x.koef);
            results = results.Select(x => (x.res, (x.koef / max)*100));

            var sb = new StringBuilder();
            foreach ((Result, float kof) r in results ) {
                if (r.kof <= 50)
                {
                    break;
                }
                sb.AppendLine($"{r.Item1.Text} {r.kof}%"); 
            }
            return sb.ToString();
        }
    }
}