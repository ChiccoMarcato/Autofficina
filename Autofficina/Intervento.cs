using System.Collections.Generic;

namespace Autofficina
{
    class Intervento
    {
        private int oreDiLavoro;
        private List<PezzoRicambio> pezziUtilizzati = new List<PezzoRicambio>();

        public int OreDiLavoro {
            get => oreDiLavoro;
            set => oreDiLavoro = value;
        }
        internal List<PezzoRicambio> PezziUtilizzati { get => pezziUtilizzati; set => pezziUtilizzati = value; }

        public decimal CalcolaCosto()
        {
            decimal Totale;

            Totale = 40 * OreDiLavoro;

            foreach (PezzoRicambio p in PezziUtilizzati)
               Totale += p.Costo;

            return Totale;
        }     
    }
}
