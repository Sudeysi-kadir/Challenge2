using Calculator.Console.Model;

namespace Calculator.Console.Input;

public class InputHandler
{
    public double GetInput(string message, InputTypeEnum inputType)
    {
        while (true)
        {
            System.Console.Write(message);
            string input = System.Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                System.Console.WriteLine("Input cannot be empty.");
                continue;
            }
            if (inputType == InputTypeEnum.Menu)
            {
                if (!int.TryParse(input, out int choice))
                {
                    System.Console.WriteLine("Please enter a valid choice.");
                    continue;
                }
                return choice;
            }
            else if (inputType == InputTypeEnum.Number)
            {
                if (!double.TryParse(input, out double number))
                {
                    System.Console.WriteLine("Please enter a number.");
                    continue;
                }
                return number;
            }
        }
    }
}