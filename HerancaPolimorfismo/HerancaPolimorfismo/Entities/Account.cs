﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerancaPolimorfismo.Entities
{
     abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount) // método virtual para permitir sobreposição na subclasse
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        { 
            Balance += amount;
        }
    }
}
