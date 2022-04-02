using System;

namespace JobLessonOOP02Part03v03
{
    public class BankAccount
    {
        public int NumberBankAccount { get; set; } = GenerateNumberBankAccount();
        public double BallanceBankAccount { get; set; }
        public TypeBankAccound TypeBankAccound { get; set; }

        private static int _generateNumberBankAccount = 0000_0000_1000_000;
        public static int GenerateNumberBankAccount()
        {
            int accountID = _generateNumberBankAccount;
            accountID++;
            _generateNumberBankAccount = accountID;
            return _generateNumberBankAccount;
        }
        public void GetInfo()
        {
            Console.WriteLine($"Банковский счёт пользователя: # {NumberBankAccount} " + "\n" +
            $"Количество средств пользователя: {BallanceBankAccount} руб." + "\n" +
            $"Тип счёта: {TypeBankAccound} " + "\n" +
            $"=============================================================");
        }

    }
}
