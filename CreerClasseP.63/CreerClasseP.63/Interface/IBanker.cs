using CreerClasseP._63.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreerClasseP._63.Interface
{
    public interface IBanker
    {
        public void Retrait(double montant);
        public void Depot(double montant);

        public double AppliquerInteret();

        public Personne? Titulaire { get; }

        public string? NumeroCarte { get; }

    }
}
