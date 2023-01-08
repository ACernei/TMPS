namespace Lab4.Strategy;

public class EatStrategySelector : IEatStrategySelector
{
    public IEatStrategy SelectEatStrategy(int freeTime)
    {
        if (freeTime < 20)
        {
            return new EatFastStrategy();
        }

        return new EatSlowStrategy();
    }
}
