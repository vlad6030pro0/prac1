internal class Program
{
    private static void Main(string[] args)
    {
        string startMessage = "Добро пожаловать в калькулятор! Введите операцию (+, -, *, /,%, 1/x, x^2, sqrt, MS, M+, M-, MR) и одно/два значения.\n" +
            "После первой операции вводите операцию и одно число, либо команду clear для сброса.\n" +
            "Введите команду exit для выхода";
        string oper = "start";
        float num1 = 0;
        float num2;
        (float, string) result = (0, "OK");
        bool isClear = true;
        float m = 0;

        Console.WriteLine(startMessage);

        while(oper != "exit")
        {
            Console.Write("Введите операцию: ");
            oper = Console.ReadLine();
            if (oper == "clear")
            {
                isClear = true;
                Console.Clear();
                Console.WriteLine(startMessage);
                Console.Write("Введите операцию: ");
                oper = Console.ReadLine();
            }
            if (isClear)
            {
                Console.Write("Введите число: ");
                num1 = float.Parse(Console.ReadLine());
                result.Item1 = num1;
                isClear = false;
            }
            switch (oper)
            {
                case ("+"):
                    Console.Write("Введите число: ");
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 + num2;
                    break;
                case ("-"):
                    Console.Write("Введите число: ");
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 - num2;
                    break;
                case ("*"):
                    Console.Write("Введите число: ");
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 * num2;
                    break;
                case ("/"):
                    Console.Write("Введите число: ");
                    num2 = float.Parse(Console.ReadLine());
                    if (num2 == 0)
                    {
                        result.Item2 = "Деление на ноль!";
                    }else{
                        result.Item1 = result.Item1 / num2;
                    }
                    break;
                case ("%"):
                    Console.Write("Введите число: ");
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 % num2;
                    break;
                case ("1/x"):
                    if (result.Item1 == 0)
                    {
                        result.Item2 = "Деление на ноль!";
                    }
                    else
                    {
                        result.Item1 = 1 / result.Item1;
                    }
                    break;
                case ("sqrt"):
                    result.Item1 = (float)Math.Sqrt(result.Item1);
                    break;
                case ("x^2"):
                    result.Item1 = result.Item1 * result.Item1;
                    break;
                case ("MS"):
                    m = result.Item1;
                    result.Item2 = "";
                    break;
                case ("MR"):
                    Console.WriteLine(result.Item1);
                    result.Item2 = "";
                    break;
                case ("M+"):
                    result.Item1 = result.Item1 + m;
                    break;
                case ("M-"):
                    result.Item1 = result.Item1 - m;
                    break;
                case ("exit"):
                    continue;
                default:
                    result.Item2 = "Введены некорректные данные. Повторите ввод данных.\n";
                    break;
            }
            Console.WriteLine("123");
            if (result.Item2 == "OK") {
                Console.WriteLine($"Ответ: {result.Item1}");
            } else {
                Console.Write(result.Item2);
                result.Item2 = "OK";
            }
        }
    }
}