namespace P2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Niño = 0;
            int Joven = 0;
            int Adulto = 0;
            int Viejo = 0;
            int numNiños = 0;
            int numJovenes = 0;
            int numAdultos = 0;
            int numViejos = 0;

            Console.WriteLine("Ingrese el número de personas:");
            int numPersonas = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numPersonas; i++)
            {
                Console.WriteLine("Ingrese la edad de la persona:");
                int edad = Convert.ToInt32(Console.ReadLine());

                if (edad > 0 && edad <= 12)
                {
                    Console.WriteLine("Ingrese el peso del niño:");
                    int pesoNiño = Convert.ToInt32(Console.ReadLine());
                    Niño += pesoNiño;
                    numNiños++;
                }
                else if (edad >= 13 && edad <= 29)
                {
                    Console.WriteLine("Ingrese el peso del joven:");
                    int pesoJoven = Convert.ToInt32(Console.ReadLine());
                    Joven += pesoJoven;
                    numJovenes++;
                }
                else if (edad > 30 && edad <= 59)
                {
                    Console.WriteLine("Ingrese el peso del adulto:");
                    int pesoAdulto = Convert.ToInt32(Console.ReadLine());
                    Adulto += pesoAdulto;
                    numAdultos++;
                }
                else if (edad > 60)
                {
                    Console.WriteLine("Ingrese el peso del viejo:");
                    int pesoViejo = Convert.ToInt32(Console.ReadLine());
                    Viejo += pesoViejo;
                    numViejos++;
                }
                else
                {
                    Console.WriteLine("Error: Edad no válida");
                    i--;
                }
            }

            double promedioNiños = numNiños > 0 ? (double)Niño / numNiños : 0;
            double promedioJovenes = numJovenes > 0 ? (double)Joven / numJovenes : 0;
            double promedioAdultos = numAdultos > 0 ? (double)Adulto / numAdultos : 0;
            double promedioViejos = numViejos > 0 ? (double)Viejo / numViejos : 0;

            Console.WriteLine("Resultados:");
            Console.WriteLine("Promedio de peso de niños: " + promedioNiños);
            Console.WriteLine("Promedio de peso de jóvenes: " + promedioJovenes);
            Console.WriteLine("Promedio de peso de adultos: " + promedioAdultos);
            Console.WriteLine("Promedio de peso de viejos: " + promedioViejos);
        }
    }
}
