/// <summary>
/// This class demonstrates immutability versus mutability (the ability for an object to mutate or not.)
/// </summary>
public class Money
{
    // These fields, have no "setters" (set) avaiable, meaning, they cannot be "mutated" or have "invalid" states or undesired behavour.
    public double Amount { get; }
    public string Currency { get; } = "EUR";

    public Money(double amount, string currency)
    {
        Amount = amount;
        Currency = currency;
    }
}