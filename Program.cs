using System;
using System.Diagnostics;

public class GamePlatform
{
    public static double CalculateFinalSpeed(double initalSpeed, int[] inclinations)
    {

        double affectedSpeed = initalSpeed;
        foreach (var inclination in inclinations)
        {
            if (inclination == 30)
            {
                affectedSpeed -= 30;
            } else if (inclination == -45)
            {
                affectedSpeed += 45;
            }
        }
        return affectedSpeed;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(CalculateFinalSpeed(60, new int[] { 0, 30, 0, -45, 0}));
    }
}