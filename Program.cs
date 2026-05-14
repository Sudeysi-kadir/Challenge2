using Calculator.Console.Handler;
namespace Calculator.Console;
public class Program
{
    public static void Main()
    {
        MenuHandler menu = new MenuHandler();
        menu.Start();
    }
}