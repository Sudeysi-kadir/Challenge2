using Calculator.Console.Model;

namespace Calculator.Console.Input;

public class InputHandler
{
    public double GetInput(string message, InputTypeEnum inputType)
    {
        while (true)
        {
            if (inputType == InputTypeEnum.Menu)
            {
                System.Console.Write(message);
                string input = System.Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    System.Console.WriteLine("Input cannot be empty.");
                    continue;
                }
                if (!int.TryParse(input, out int choice))
                {
                    System.Console.WriteLine("Please enter a valid choice.");
                    continue;
                }
                return choice;
            }
            else if (inputType == InputTypeEnum.Number)
            {
                System.Console.Write(message);
                string input = System.Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    System.Console.WriteLine("Input cannot be empty. Please enter a number");
                    continue;
                }
                if (!double.TryParse(input, out double number))
                {
                    System.Console.WriteLine("Please enter a number");
                    continue;
                }
                return number;
            }
        }
    }
}