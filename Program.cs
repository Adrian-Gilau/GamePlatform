using System;
using System.Diagnostics;

public class GamePlatform
{
    public static double CalculateFinalSpeed(double initalSpeed, int[] inclinations)
    {

        double affectedSpeed = initalSpeed;
        int characterLife = 10;

        foreach (var inclination in inclinations)
        {
            affectedSpeed = affectedSpeed + (inclination * -1);
            if (affectedSpeed < 0)
            {
                characterLife--;
                affectedSpeed = 0;
                break;
            }
        }
        

        return affectedSpeed;
    }
    public static void Main(string[] args)
    {
        Console.WriteLine(CalculateFinalSpeed(60, new int[] { 0, 30, 0, -45, 0}));
    }
}