using System;

static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        switch (speed)
        {
            case int n when n >= 1 && n <= 4:
                return 1.0;
            case int n when n >= 5 && n <= 8:
                return 0.9;
            case 9:
                return 0.8;
            case 10:
                return 0.77;
            default:
                return 0;
        }
    }

    public static double ProductionRatePerHour(int speed)
    {
        int numberOfCarsPerHour = 221;

        return (numberOfCarsPerHour * speed) * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed) => ((int)(ProductionRatePerHour(speed) / 60));
}
