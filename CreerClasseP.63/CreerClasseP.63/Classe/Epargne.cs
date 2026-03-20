using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CreerClasseP._63.Classe;

public class Epargne : Compte
{


    public DateTime DernierRetrait { get; set; }


    protected override double CalculInteret()
    {
        return Solde * 4.5 / 100;
    }






    public override void Retrait(double montant)
    {
        if (montant < Solde)
        {

            Console.WriteLine($"Retrait de {montant} accepté. Le montant actuel est de : {Solde - montant}");
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


