namespace TpC_02_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numEntrada = 0;
            Console.WriteLine("Informe um numero");
            numEntrada = int.Parse(Console.ReadLine());

            if (verificaPrimo(numEntrada))
            {
                Console.WriteLine($"{numEntrada} é primo");
            }
            else
            {
                Console.WriteLine($"{numEntrada} não é primo");
            }

            //--------------------------------------
            static bool verificaPrimo(int numEntrada)
            {
                if (numEntrada <= 1 || numEntrada % 2 == 0) return false;
                if(numEntrada == 2) return true;

                int raiz = (int)Math.Sqrt(numEntrada);
                for (int i = 3; i <=  raiz; i+=2) 
                {
                    if (numEntrada % i == 0) return false;
                }
                return true;
            }
        }
    }
}
