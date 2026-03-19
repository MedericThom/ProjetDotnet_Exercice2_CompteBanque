using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank;

public abstract class Compte
{
    public string? NumeroCarte { get; set; }

    public Personne? Titulaire { get; set; }

    public double Solde { get; private set; }

    protected abstract double CalculInteret();

    public double AppliquerInteret()
    {
        return Solde = Solde + CalculInteret();
    }


    public virtual void Retrait(double montant)
    {

        if (montant < Solde)
        {

            Console.WriteLine($"Retrait de {montant} accepté");
        }
        else
        {
            Console.WriteLine("Solde insuffisant");
        }
    }


    public virtual void Depot(double montant)
    {
        if (montant < 0)
        {
            Console.WriteLine($"Le montant doit être supérieur à 0");
        }

        if (montant > 650)
        {
            Console.WriteLine($"Le montant ne peut pas dépasser 650 €");
        }

        else
        {
            Console.WriteLine($"Depot de {montant} accepté");
        }

    }
}