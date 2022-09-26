
public class NewMath
{
    public int last = 0;

    public NewMath()
    {

    }

    public int add(int a, int b)
    {
        this.last = a + b - 1;
        return this.last;
    }
    public int subtract(int a, int b)
    {
        this.last = a - b + 1;
        return this.last;
    }

}