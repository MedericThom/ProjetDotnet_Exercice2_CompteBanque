using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bank;

public class Courant : Compte
{

    private double _LigneDeCredit;
    public double ligneDeCredit
    {
        get { return _LigneDeCredit; }
        set {_LigneDeCredit = value >= 0 ? value : _LigneDeCredit; }
    }

    protected override double CalculInteret()
    {
        if (Solde > 0)
            return Solde * 3 / 100;
        else
            return Solde * 9.75 / 100;
    }

    public override void Retrait(double montant)
    {
        if ((Solde + ligneDeCredit) < (Solde - montant))
        {

            Console.WriteLine($"Retrait de {montant} accepté. Le montant actuel est de : {Solde - montant}");
        }

        if (ligneDeCredit > (0 - montant))
        {
            Console.WriteLine($"Retrait de {montant} accepté. Le montant actuel est de : {ligneDeCredit - montant}");
        }

        else
        {
            Console.WriteLine("Solde insuffisant");
        }

    }

    public override void Depot(double montant)
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
            Console.WriteLine($"Depot de {montant} accepté. Le montant actuel est de {Solde + montant}");
        }

    }

}
