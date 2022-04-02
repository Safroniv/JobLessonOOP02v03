namespace JobLessonOOP02Part03v03
{
    class Program
    {
        static void Main()
        {
            BankAccount firstBankAccount = new BankAccount();            
            firstBankAccount.BallanceBankAccount = 999999.99;
            firstBankAccount.TypeBankAccound = TypeBankAccound.deposite;
            firstBankAccount.GetInfo();
        }
    }
}
