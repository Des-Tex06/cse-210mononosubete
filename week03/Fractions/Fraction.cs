public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
        //Console.WriteLine($"{_top}/{_bottom}"); This line is unnecessary.
    }
    public Fraction(int wholeNumber)
    {

        _top = wholeNumber; //This line initializes the wholeNumber as the top number in the fraction.
        _bottom = 1; //This line initializes the bottom to 1.
        //Console.WriteLine($"{wholeNumber}/{_bottom}"); This line is unnecessary.
        

    } 

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
        //Console.WriteLine($"{top}/{bottom}"); Don't use this line.
    }
    public int GetTop()
    {
        return _top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        return _bottom;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fractionLine = $"{_top}/{_bottom}";
        return fractionLine;
    }
                
                
    public double GetDecimalValue()
    {
        return (double)_top / (double) _bottom;    
    }

}