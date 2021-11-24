﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    public abstract class Conta

    {

        private decimal saldo; 
        private string titular;


        //public int numero { get; set; }
        //public double Valor { get; set; }

        //public decimal saldo { get; set; }
        //private string titular;

        public Conta(string t)
        {
            titular = t;
        }

            public decimal Saldo
            {
                get { return saldo; }
            }

            public string Titular
            {
                get { return titular; }
            }
            public abstract string Id
            {
                get;
            }
            public virtual void Depositar(decimal valor)
            {
                saldo += valor;
            }

            public virtual void Sacar(decimal valor)
            {
                saldo -= valor;
            }

            public override bool Equals(object obj)
            {
                return obj is Conta conta &&
                       Titular == conta.Titular;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Titular);
            }
    }
}
