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
                AdvMath advMath = new AdvMath();
                double result = 0;
                string operationDesc = "";
                string advOperation = "";
                double advResult = 0;

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
                    case "area":
                        {
                            advResult = advMath.CalcArea(operand1, operand2);
                            advOperation = "area with dimensions";
                            break;
                        }
                    case "avg":
                        {
                            List<double> values = new List<double> { operand1, operand2 };
                            advResult = advMath.CalcAverage(values);
                            advOperation = "average of";
                            break;
                        }
                    case "sqr":
                        {
                            advResult = advMath.Squared(operand1);
                            advOperation = "squared value of";
                            operand2 = 0;
                            break;
                        }
                    case "hyp":
                        {
                            advResult = advMath.CalcHypotenuse(operand1, operand2);
                            advOperation = "hypotenuse with sides";
                            break;
                        }
                    default:
                        {
                            throw new Exception("An unexpected error occurred");
                        }
                }

                if (advOperation != null)
                {
                    Console.WriteLine($"{operand1} {advOperation} {operand2} is equal to {advResult}");
                }
                else
                {
                    Console.WriteLine($"{operand1} {operationDesc} {operand2} is equal to {result}");
                }

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

            if (args[0] != "+" && args[0] != "-" && args[0] != "*" && args[0] != "/" &&
                args[0] != "area" && args[0] != "avg" && args[0] != "sqr" && args[0] != "hyp")
            {
                throw new ArgumentException("First argument must be a valid math operator.");
            }

            if (!int.TryParse(args[1], out operand1))
            {
                throw new ArgumentException("Second argument must be a valid integer.");
            }

            if (!int.TryParse(args[2], out operand2) && args[0] != "sqr")
            {
                throw new ArgumentException("Third argument must be a valid integer.");
            }

            operation = args[0];
        }
    }
}
