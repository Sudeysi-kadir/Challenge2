using Calculator.Console.Input;
using Calculator.Console.Logic;
using Calculator.Console.Model;
namespace Calculator.Console.Handler;

public class MenuHandler
{
    CalculatorLogic calculatorLogic = new CalculatorLogic();
    InputHandler inputHandler = new InputHandler();
    public void Start()
    {
        while (true)
        {
            System.Console.WriteLine($"1. Addition \n2. Subtraction \n3. Multiplication \n4. Division \n5. Exit");
            double choice = inputHandler.GetInput("Enter your choice: ", InputTypeEnum.Menu);
            if (choice == 5)
            {
                break;
            }
            else if (choice > 5 || choice < 1)
            {
                System.Console.WriteLine("Please enter a number between 1 and 5.");
                continue;
            }
            double number1 = inputHandler.GetInput("Enter the first number: ", InputTypeEnum.Number);
            double number2 = inputHandler.GetInput("Enter the second number: ", InputTypeEnum.Number);
            Operation op = (Operation)(choice - 1);
            double result = 0;
            switch (op)
            {
                case Operation.Add:
                    result = calculatorLogic.Addition(number1, number2);
                    break;
                case Operation.Subtraction:
                    result = calculatorLogic.Subtraction(number1, number2);
                    break;
                case Operation.Multiplication:
                    result = calculatorLogic.Multiplication(number1, number2);
                    break;
                case Operation.Division:
                    try
                    {
                        result = calculatorLogic.Division(number1, number2);
                    }
                    catch(System.DivideByZeroException)
                    {
                        System.Console.WriteLine("Cannot divide by zero.");
                    }
                    break;
            }
            System.Console.WriteLine($"{number1} {OperationToString.OperationConverter(op)} {number2} = {result}");
        }
    }
}