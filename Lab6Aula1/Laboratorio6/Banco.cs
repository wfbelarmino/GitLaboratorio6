using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio6
{
    class Banco
    {
        private List<Conta> contas;
        private object pessoa;
        private double valor;

        public Banco() 
        {
            contas = new List<Conta>();
        }

        public void AddConta(Pessoa p) 
        {
            contas.Add(p.Money);
        }
        public void Depositar(Pessoa p, double v) 
        {
            for (int i = 0; i < contas.Count; i++)
            {
                if (contas[i].ID==p.Money.ID)
                {
                    contas[i].Valor += valor;
                }
                
            }
        }
        public double Saldo(Pessoa p) 
        {
            double saldo = 0.0;
            for (int i = 0; i < contas.Count; i++)
            {
                if (contas[i].ID == p.Money.ID) 
                {
                    saldo = contas[i].Valor;
                }
            }
            return saldo;
        }

    }
}
