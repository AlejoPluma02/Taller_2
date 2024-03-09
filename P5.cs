namespace P5
{
    internal class Program
    {
        static void Main()
        {
            int elefantes = 20;
            int jirafas = 15;
            int chimpances = 40;

            Console.WriteLine("Ingrese la opción de animal a estudiar (elefantes, jirafas o chimpancés):");
            string animal = Console.ReadLine().ToLower();

            int totalMuestras = 0;
            int menos1año = 0;
            int mas1yMenos3 = 0;
            int mas3oMas = 0;

            if (animal == "elefantes")
            {
                totalMuestras = elefantes;
            }
            else if (animal == "jirafas")
            {
                totalMuestras = jirafas;
            }
            else if (animal == "chimpancés")
            {
                totalMuestras = chimpances;
            }
            else
            {
                Console.WriteLine("Animal no válido.");
                return;
            }

            for (int i = 0; i < totalMuestras; i++)
            {
                Console.WriteLine($"Ingrese la edad del {animal.Substring(0, animal.Length - 1)} {i + 1}:");
                int edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 0 && edad <= 1)
                {
                    menos1año++;
                }
                else if (edad > 1 && edad < 3)
                {
                    mas1yMenos3++;
                }
                else if (edad >= 3)
                {
                    mas3oMas++;
                }
                else
                {
                    Console.WriteLine("Edad no válida.");
                    i--;
                }
            }

            double porcentajeMenos1año = (double)menos1año / totalMuestras * 100;
            double porcentajeMas1yMenos3 = (double)mas1yMenos3 / totalMuestras * 100;
            double porcentajeMas3oMas = (double)mas3oMas / totalMuestras * 100;

            Console.WriteLine($"Porcentaje de animales de 0 a 1 año: {porcentajeMenos1año}%");
            Console.WriteLine($"Porcentaje de animales de más de 1 año y menos de 3: {porcentajeMas1yMenos3}%");
            Console.WriteLine($"Porcentaje de animales de 3 o más años: {porcentajeMas3oMas}%");
        }
    }
}
