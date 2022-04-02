namespace JobLessonOOP02Part02v03
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
