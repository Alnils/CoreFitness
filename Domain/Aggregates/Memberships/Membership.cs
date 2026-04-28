namespace Domain.Aggregates.Memberships;

public sealed class Membership
{
    private Membership(string id, string title, string description, List<string> benefits, decimal price, int monthlyClasses)
    {
        Id = Required(id, nameof(Id));
        Title = Required(title, nameof(Title));
        Description = Required(description, nameof(Description));
        Benefits = benefits;
        Price = CheckValue(price, nameof(Price));
        MonthlyClasses = monthlyClasses;
    }

        public string Id { get; } 
        public string Title { get; private set; } 
        public string Description { get; private set; } 
        public List<string> Benefits { get; private set; }
        public decimal Price { get; private set; }
        public int MonthlyClasses { get; private set; }

    private static string Required(string value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentException($"'{propertyName}' is required.", propertyName);
        return value.Trim();
    }

    private static decimal CheckValue(decimal value, string propertyName)
    {
        if (value < 0)
            throw new ArgumentException($"'{propertyName}' cannot be negative.", propertyName);
        return value;
    }

    public static Membership Create(string title, string description, List<string> benefits, decimal price, int monthlyClasses)
    {
        return new Membership(Guid.NewGuid().ToString(), title, description, benefits, price, monthlyClasses);
    }

    public static Membership Create(string id, string title, string description, List<string> benefits, decimal price, int monthlyClasses)
    {
        return new Membership(id, title, description, benefits, price, monthlyClasses);
    }
}
