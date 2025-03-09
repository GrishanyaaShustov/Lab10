namespace Car;

public class CarYearComparer : IComparer<Car>
{
    public int Compare(Car x, Car y)
    {
        if (x == null || y == null)
            throw new ArgumentException("Оба объекта должны быть не null.");

        return x.Year.CompareTo(y.Year);
    }
}