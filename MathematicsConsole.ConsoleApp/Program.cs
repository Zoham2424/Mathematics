using Mathematics;

namespace Mathmatics.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string operation;
                int operand1, operand2;

                ValidateArguments(args, out operation, out operand1, out operand2);

                BasicMath basicMath = new BasicMath();
                double result;
                string operationDesc;

                switch (operation)
                {
                    case "+":
                        {
                            result = basicMath.AddNumbers(operand1, operand2);
                            operationDesc = "plus";
                            break;
                        }
                    case "-":
                        {
                            result = basicMath.SubtractNumbers(operand1, operand2);
                            operationDesc = "minus";
                            break;
                        }
                    case "*":
                        {
                            result = basicMath.MultiplyNumbers(operand1, operand2);
                            operationDesc = "multiplied by";
                            break;
                        }
                    case "/":
                        {
                            result = basicMath.DivideNumbers(operand1, operand2);
                            operationDesc = "divided by";
                            break;
                        }
                    default:
                        {
                            throw new Exception("An unexpected error occurred");
                        }
                }

                Console.WriteLine($"{operand1} {operationDesc} {operand2} is equal to {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] Something went wrong: {ex.Message}");
            }
        }


        private static void ValidateArguments(string[] args, out string operation, out int operand1, out int operand2)
        {
            if (args.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Not enough arguments were passed to perform the operation.");
            }

            if (args[0] != "+" && args[0] != "-" && args[0] != "*" && args[0] != "/")
            {
                throw new ArgumentException("First argument must be a math operator.");
            }

            if (!int.TryParse(args[1], out operand1))
            {
                throw new ArgumentException("Second argument must be a valid integer.");
            }

            if (!int.TryParse(args[2], out operand2))
            {
                throw new ArgumentException("Third argument must be a valid integer.");
            }

            operation = args[0];
        }
    }
}
