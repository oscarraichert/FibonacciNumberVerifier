Console.WriteLine(VerifyNumber(55));

string VerifyNumber(int inputNumber)
{
    var currentNumber = 0;

    List<int> fibonacci = new()
    {
        0, 1
    };

    var array = fibonacci.ToArray();

    while (inputNumber > currentNumber)
    {
        var lastTwoNumbers = fibonacci.GetRange(fibonacci.Count - 2, 2);

        currentNumber = lastTwoNumbers[0] + lastTwoNumbers[1];

        fibonacci.Add(currentNumber);

        Console.WriteLine(currentNumber);
    }

    if (currentNumber == inputNumber)
    {
        return "\nO número está na sequência de fibonacci";
    }

    return "\nO número não está na sequência de fibonacci";
}