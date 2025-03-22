namespace NachtWiesel.Tools.Numbers;

public static class NokExtensions
{
    public static int NOK(int a, int b)
        => Math.Abs(a * b) / NodExtensions.NOD(a, b);

    public static int NOK(this int[] values)
    {
        if (values.Length == 0)
        {
            return 0;
        }
        int first = values[0];
        if (values.Length == 1)
        {
            return first;
        }
        for (int i = 1; i < values.Length; i++)
        {
            first = NOK(first, values[i]);
        }
        return first;
    }
}
