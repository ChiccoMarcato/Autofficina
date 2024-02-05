using System;
using System.Collections.Generic;
namespace Autofficina
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PezzoRicambio> ElencoPezzi = new Dictionary<string, PezzoRicambio>();
            string codice, risposta;
 
            Console.WriteLine("INSERIMENTO ELENCO PEZZI DI RICAMBIO");
            do
            {
                Console.Write("Inserisci il codice del pezzo: ");
                codice = Console.ReadLine();
                if (ElencoPezzi.ContainsKey(codice))
                {
                    Console.WriteLine("Codice già esistente!");
                    risposta = "s";
                }
                else
                {
                    Random r = new Random();
                    //PezzoRicambio pezzo = new PezzoRicambio("0001",20m,"pistone");
                    PezzoRicambio pezzo= new PezzoRicambio();
                    pezzo.Codice = codice;                  
                    Console.Write("Inserisci la descrizione dele pezzo: ");
                    pezzo.Descrizione = Console.ReadLine();
                    Console.Write("Inserisci il costo del pezzo: ");
                    
                    ElencoPezzi.Add(codice, pezzo);
                    Console.Write("Vuoi inserire un altro pezzo (s/n)? ");
                    risposta = Console.ReadLine();
                }
            } while (risposta.ToLower() == "s");
            Console.WriteLine("\nPremi un tasto per continuare...");
            Console.Clear();
            Console.WriteLine("INSERIMENTO INTERVENTO DI RIPARAZIONE");
   
            Intervento i = new Intervento(); 

            Console.Write("Inserire il numero di ore di lavoro: ");
            i.OreDiLavoro = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Inserire il codice dei pezzi utilizzati nell'intervento: ");
            do
            {
                Console.Write("Inserisci il codice del pezzo: ");
                codice = Console.ReadLine();
                if (!ElencoPezzi.ContainsKey(codice))
                {
                    Console.WriteLine("Pezzo non trovato!");
                    risposta = "s";
                }
                else
                {
                    PezzoRicambio pezzo = ElencoPezzi[codice];
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Pezzo: " + pezzo.Descrizione);
                    Console.WriteLine("Costo: " + pezzo.Costo);
                    Console.ForegroundColor = ConsoleColor.White;
                    i.PezziUtilizzati.Add(pezzo);       
                    Console.Write("Vuoi inserire un altro pezzo (s/n)? ");
                    risposta = Console.ReadLine();
                }
            } while (risposta.ToLower() == "s");

            Console.WriteLine("Il totale da pagare è: " + i.CalcolaCosto());
            Console.ReadKey();


        }
    }
}
