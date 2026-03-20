using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace CreerClasseP._63.Classe;

public class Banque
{
    public string? Nom { get; set; } // Nom banque
    public Dictionary<string, Compte> dictionnaireCompte = new Dictionary<string, Compte>();



    public void Ajouter(Compte compte)
    {
        dictionnaireCompte.Add("BE06454545454545", compte);
    }


    public void Supprimer(string Numero)
    {
        dictionnaireCompte.Remove(Numero);
    }

}

