public class BankAccount
{
    // Encapsulation, using a private setter & public getter
    public double AccountBalance { get; private set; }

    // When we think of encapsulation, we make the field accesible using a method.
    // Rather than allowing it's value, to be changed directly.

    public void DepositFunds(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException("Cannot make an empty deposit to in your account!");
        }
        // We increment the private field, by taking "ownership" using the amount parameter argument.
        AccountBalance += amount;
    }

    public double GetCurrentBalance()
    {
        return AccountBalance;
    }
}