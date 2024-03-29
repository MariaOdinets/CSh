﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.HomeWork_lecture5
{
    /// <summary>
    /// Создать класс CreditCard c полями номер счета, текущая сумма на счету.
    // Добавьте метод, который позволяет начислять сумму на кредитную  карточку
    // Добавьте метод, который позволяет снимать с карточки некоторую сумму 
    // Добавьте метод, который выводит текущую информацию о карточке.
    // Напишите программу, которая создает три объекта класса CreditCard у которых заданы номер счета и начальная сумма
    // Тестовый сценарий для проверки:
    // Положите деньги на первые две карточки и снимите с третьей.
    // Выведите на экран текущее состояние всех трех карточек.
    internal class CreditCard
    {
        public long accountNumber;
        public int availableBalance;

        public CreditCard(long accountNumber, int availableBalance)
        {
            this.accountNumber = accountNumber;
            this.availableBalance = availableBalance;
        }

        public void ReplenishCardAccount(int sum)
        {
            availableBalance += sum;
        }

        public void WithdrawMoney(int sum)
        {
            availableBalance -= sum;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Account number: {accountNumber}, available balance: ${availableBalance}");
        }
    }
}
