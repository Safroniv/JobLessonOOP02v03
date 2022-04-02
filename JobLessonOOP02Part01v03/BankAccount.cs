using System;

namespace JobLessonOOP02Part01v03
{
    public class BankAccount
    {
        private int _numberBankAccount;
        private double _ballanceBankAccount;
        private TypeBankAccound _typeBankAccound;

        public int NumberBankAccount
        {
            get {return _numberBankAccount;}
            set{_numberBankAccount = value;}
        }
        public double BallanceBankAccount
        {
            get{return _ballanceBankAccount;}
            set{_ballanceBankAccount = value;}
        }
        public TypeBankAccound TypeBankAccound
        {
            get{return _typeBankAccound;}
            set{_typeBankAccound = value;}
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
