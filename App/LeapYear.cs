namespace App;

public static class LeapYear
{
    public static bool IsLeapYear(int year) 
    {
        //TODO напишите тут свое решение
        return Random.Shared.NextInt64() % 2 == 0;
    }
}