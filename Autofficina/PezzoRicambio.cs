using System;

namespace Autofficina
{
    class PezzoRicambio
    {
        
        private string codice;
        private decimal costo;
        private string descrizione;

        public PezzoRicambio()
        {
        }

        public PezzoRicambio(string codice, decimal costo, string descrizione)
        {
            this.codice = codice;
            if (costo > 0)
                this.costo = costo;
            else
                Console.WriteLine("Costo non valido!");
            this.descrizione = descrizione;
        }

        public string Codice {
            get => codice;      
            set                 
            {
                if (value.Length < 4)
                    Console.WriteLine("Codice non valido!");
                else
                    codice = value;
            }
        }

        public decimal Costo
        {
            get => costo;
            set
            {
                if (value < 0)
                    Console.WriteLine("Costo non valido!");
                else
                    costo = value;
            }
        }

        public string Descrizione {
            get
            {
                return "----"+ descrizione+"----";
            } 
            set
            {
                if (value.Equals(""))
                    Console.WriteLine("Descrizione non valida!");
                else
                    descrizione = value;

            }
        }
    }
}
