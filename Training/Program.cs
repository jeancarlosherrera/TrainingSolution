using Training;

Calculator calculator = new(25, 4);

var sumResult = calculator.Sum();

var subsResult = calculator.Substract();

Console.WriteLine($"The sum result is: {sumResult}\n");

Console.WriteLine($"The subtraction result is: {subsResult}\n");