using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Personne.Models;

namespace Courant.Models
{
    public class Current
    {
        public string cardNumber {  get; set; }
        public decimal currentBalance { get; }

        private int lineCredit;
        public int LineCredit
        {
            get { return lineCredit; }
            set {lineCredit = value >= 0 ? value : lineCredit; }
        }

        public Person holder { get; set; }




        void Retrait(decimal amount)
        {
            if ((currentBalance + lineCredit) < (currentBalance - amount))
            {

                Console.WriteLine($"Retrait de {amount} accepté");
            }
            else
            {
                Console.WriteLine("Solde insuffisant");
            }

        }

        void Depot(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine($"Le montant doit être supérieur à 0");
            }

            if (amount > 650)
            {
                Console.WriteLine($"Le montant ne peut pas dépasser 650 €");
            }

            else
            {
                Console.WriteLine($"Depot de {amount} accepté");
            }

        }
   
    }
}
