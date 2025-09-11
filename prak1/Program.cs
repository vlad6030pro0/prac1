internal class Program
{
    private static void Main(string[] args)
    {
        string startMessage = "Добро пожаловать в калькулятор! Введите операцию (+, -, *, /,%, 1/x, x^2, sqrt, MS, M+, M-, MR) и два значения.\n" +
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
            //При вводе exit в начале цикла работы программа не завершится, а будет ожидать ввода num1
            oper = Console.ReadLine();
            if (oper == "clear")
            {
                isClear = true;
                Console.Clear();
                Console.WriteLine(startMessage);
                oper = Console.ReadLine();
            }
            if (isClear)
            {
                num1 = float.Parse(Console.ReadLine());
                result.Item1 = num1;
                isClear = false;
            }
            switch (oper)
            {
                case ("+"):
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 + num2;
                    break;
                case ("-"):
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 - num2;
                    break;
                case ("*"):
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 * num2;
                    break;
                case ("/"):
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 / num2;
                    break;
                case ("%"):
                    num2 = float.Parse(Console.ReadLine());
                    result.Item1 = result.Item1 % num2;
                    break;
                case ("1/x"):
                    result.Item1 = 1 / result.Item1;
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
                    break;
                default:
                    result.Item2 = "Введены некорректные данные. Повторите ввод данных.\n";
                    break;
            }

            if (result.Item2 == "OK") {
                Console.WriteLine($"Ответ: {result.Item1}");
            } else {
                Console.Write(result.Item2);
                result.Item2 = "OK";
            }
        }
    }
}