class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40;

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int TimeAlreadyPassed)
    => ExpectedMinutesInOven() - TimeAlreadyPassed;

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int NumberOfLayers)
    => NumberOfLayers * 2;
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int NumberOfLayers, int TimeAlreadyPassed)
    => PreparationTimeInMinutes(NumberOfLayers) + TimeAlreadyPassed;
}