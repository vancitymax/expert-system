using ExpertSystem;

Console.OutputEncoding = System.Text.Encoding.UTF8;//For ukrainian

Oracle expertSys = new Oracle();

while (expertSys.GetCurrentQuestion().Count()!=0)
{
    List<int> inputs = new();
    List<string> q = expertSys.GetCurrentQuestion().ToList();
    for (int i = 0; i < q.Count; i++)
    {
        if (i != 0) { Console.Write($"{i}. "); }
        if (q[i].StartsWith("?"))
        {
            inputs.Add(i);
            Console.WriteLine($"Будь ласка введіть: {q[i].Remove(0,1)}");
            continue;
        }
        Console.WriteLine(q[i]);
    }
    if (inputs.Count==0)
    {
        Console.WriteLine("Оберіть відповідь (вкажіть номер відповіді):");
        int input = Int32.Parse(Console.ReadLine())-1;
        expertSys.Answer(input);
    }
    else
    {
        for(int i = 0; i< inputs.Count; i++)
        {
            Console.WriteLine($"Введіть {inputs[i]}:");
            int input = Int32.Parse(Console.ReadLine())-1;

            if (i==inputs.Count-1)
            {
                expertSys.Answer(inputs[i]-1, input, true);
                break;
            }

            expertSys.Answer(inputs[i] - 1, input);
        }
    }

    inputs.Clear();
}

Console.WriteLine("Результат:");
Console.WriteLine(expertSys.GetAnswer());