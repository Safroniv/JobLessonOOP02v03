namespace JobLessonOOP02Part02v03
{
    class Program
    {
        static void Main()
        {
            BankAccount firstBankAccount = new BankAccount();
            firstBankAccount.NumberBankAccount = 0000_0000_1000_0000;
            firstBankAccount.BallanceBankAccount = 999999.99;
            firstBankAccount.TypeBankAccound = TypeBankAccound.deposite;
            firstBankAccount.GetInfo();
        }
    }
}
