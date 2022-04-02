using System;

namespace JobLessonOOP02Part03v03
{
    public class BankAccount
    {
        private int _numberBankAccount;
        private double _ballanceBankAccount;
        private TypeBankAccount _typeBankAccount;

        public BankAccount()
        {
            int numberAccount = GenerateNumberBankAccount();
            _numberBankAccount = numberAccount;
            _ballanceBankAccount = 100_000;
            _typeBankAccount = TypeBankAccount.current;
        }
        public BankAccount(double ballance) : this()
        {
            _numberBankAccount = GenerateNumberBankAccount();
            _ballanceBankAccount = ballance;
        }
        public BankAccount(TypeBankAccount typeAccount) : this()
        {
            _numberBankAccount = GenerateNumberBankAccount();
            _typeBankAccount = typeAccount;
        }
        public BankAccount(double ballance, TypeBankAccount typeAccount) : this()
        {
            _numberBankAccount = GenerateNumberBankAccount();
            _ballanceBankAccount = ballance;
            _typeBankAccount = typeAccount;
        }

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
            Console.WriteLine($"Банковский счёт пользователя: # {_numberBankAccount} " + "\n" +
            $"Количество средств пользователя: {_ballanceBankAccount} руб." + "\n" +
            $"Тип счёта: {_typeBankAccount} " + "\n" +
            $"=============================================================");
        }

    }
}
