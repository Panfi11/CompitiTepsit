using System;

namespace CompitiTepsit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //2^31 -1 perchè il valore massimo di un int è 2^31 -1 (un bit è per il segno e un valore è lo 0)
            try
            {
                Console.WriteLine(a + 1); //-2^31 perchè aggiungendo 1 il numero con trentuno 1 diventa negativo
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            int b = -128;
            int c = -b; //viene trasformato da -b in +b
            Console.WriteLine(Convert.ToString(b, 2)); //viene convertito in binario "b"
            Console.WriteLine(Convert.ToString(c, 2)); //viene convertito in binario "c"
            Console.WriteLine("Inserisci un numero intero: ");
            int value = int.Parse(Console.ReadLine());
            int somma = value;
            value = ~value + 1; // NOt
            // value = value +1;
            somma = somma + value;
            Console.WriteLine($"Il valore opposto a quello inserito è {value} e la somma tra il valore inserito e quello opposto è {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2)); //viene convertito in binario il valore "number"
            short number1 = (short)number; //viene covertito il valore "number " da long a short 
            Console.WriteLine(number1); //viene trasformato in short
            Console.ReadLine();
        }
    }
}
