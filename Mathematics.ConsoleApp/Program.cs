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

                validateArguments(args, out operation, out operand1, out operand2);

                BasicMath basicMath = new BasicMath();
                int result;
                string operationDes;

                switch (operation)
                {

                    case "+":
                        {
                            result = basicMath.Add(operand1, operand2);
                            operationDes = "plus";
                            break;
                        }
                    case "-":
                        {
                            result = basicMath.Subtract(operand1, operand2);
                            operationDes = "minus";
                            break;
                        }
                    case "*":
                        {
                            result = basicMath.Multiply(operand1, operand2);
                            operationDes = "multiply by";
                            break;
                        }
                    case "/":
                        {
                            result = basicMath.Divide(operand1, operand2);
                            operationDes = "divided by";
                            break;
                        }
                    default:
                        {
                            throw new ArgumentException("An unexpected error ocurred");
                            break;
                        }
                }

                Console.WriteLine($"{operand1}{operationDes}{operand2} is equal to {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[ERROR] something went wrong: {ex.Message.ToString()}");
            }
        }




        private static void validateArguments(string[] args, out string operation, out int operand1, out int operand2)
        {
            if (args.Length < 3)
            {
                throw new ArgumentOutOfRangeException("Not Enough argumens were passed to perform the operation")
            }

            if (args[0] != "+" || args[0] != "-" || args[0] != "*" || args[0] != "/")
            {
                throw new ArgumentException("First argunment must be a math operatior.");
            }
            if (!int.TryParse(args[1], out operand1))
            {
                throw new ArgumentException("Second argument argunment must be a math operatior.");
            }
            if (!int.TryParse(args[1], out operand2))
            {
                throw new ArgumentException("Second argument argunment must be a math operatior.");
            }
            operation = args[0]

        }

    }
}