namespace InterfacesAndDelegates
{
    public interface ICalculateDepositBonuses
    {
        decimal GetBonusForDepositOn(decimal balance, decimal amountOfDeposit);
    }
}