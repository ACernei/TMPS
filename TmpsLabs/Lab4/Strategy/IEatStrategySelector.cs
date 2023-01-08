namespace Lab4.Strategy;

public interface IEatStrategySelector
{
    IEatStrategy SelectEatStrategy(int freeTime);
}
