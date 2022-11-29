while (true)
{
    Console.Clear();
    Console.WriteLine("Консольный калькулятор C#");
    double firstValue, secondValue;
    string action;


    try
    {
        Console.WriteLine("Введи 1 число");
        firstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Введи операцию + - * / ");
        action = Console.ReadLine();
        Console.WriteLine("Введи 2 число");
        secondValue = double.Parse(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Введено неверное число или оператор");
        Console.ReadLine();
        continue;
    }
    /*
    switch (action)
    {
        case "+":
            Console.WriteLine("Ответ");
            Console.WriteLine(firstValue + secondValue);
            break;

        case "-":
            Console.WriteLine("Ответ");
            Console.WriteLine(firstValue - secondValue);
            break;

        case "*":
            Console.WriteLine("Ответ");
            Console.WriteLine(firstValue * secondValue);
            break;

        case "/":
            Console.WriteLine("Ответ");
            if (secondValue == 0)                   
                Console.WriteLine(0);                    
            else           
               Console.WriteLine(firstValue / secondValue);
            break;
        default:
            Console.WriteLine("Введено неверное число или оператор");
            break;
    }  */

    if (action == "+")
    {
        Console.WriteLine("Ответ");
        Console.WriteLine(firstValue + secondValue);
    }
    else if (action == "-")
    {
        Console.WriteLine("Ответ");
        Console.WriteLine(firstValue - secondValue);
    }
    else if (action == "*")
    {
        Console.WriteLine("Ответ");
        Console.WriteLine(firstValue * secondValue);
    }
    else if (action == "/")
    {
        Console.WriteLine("Ответ");
        if (secondValue == 0)
            Console.WriteLine(0);
        else
            Console.WriteLine(firstValue / secondValue);
    }
    else
    {
        Console.WriteLine("Введено неверное число или оператор");
    }
    Console.ReadLine();
}
