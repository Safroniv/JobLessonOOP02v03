namespace JobLessonOOP02Part03v03
{
    class Program
    {
        static void Main()
        {
            BankAccount firstBankAccount = new (25099.09);
            firstBankAccount.GetInfo();
            BankAccount secondBankAccount = new(TypeBankAccount.credit);
            secondBankAccount.GetInfo();
            BankAccount thirdBankAccount = new(500_000_000.01, TypeBankAccount.deposite);
            thirdBankAccount.GetInfo();

        }
    }
}
