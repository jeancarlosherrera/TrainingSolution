namespace Training;

internal class Calculator
{
    private readonly int _firstDigit, _secondDigit;
    public Calculator(int firstDigit, int secondDigit)
    {
        _firstDigit = firstDigit;
        _secondDigit = secondDigit;
    }

    public int Sum ()
    {
        return _firstDigit + _secondDigit;
    }

    public int Substract ()
    {
        return _firstDigit - _secondDigit;
    }
}