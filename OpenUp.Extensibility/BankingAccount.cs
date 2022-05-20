namespace OpenUp.Extensibility
{
    public abstract class BankingAccount
    {
        public Balance AccountBalance; // COMPOSICAO

        public CreditCard card; //Agregacao
    }
}