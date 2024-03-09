namespace P6
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Ingrese la cantidad de autos que entran a la Ciudad de México: ");
            int cantidadAutos = Convert.ToInt32(Console.ReadLine());

            int amarilla = 0, rosa = 0, roja = 0, verde = 0, azul = 0;

            for (int i = 0; i < cantidadAutos; i++)
            {
                Console.Write($"Ingrese el último dígito de la placa del auto {i + 1}: ");
                int ultimoDigito = Convert.ToInt32(Console.ReadLine());

                switch (ultimoDigito)
                {
                    case 1:
                    case 2:
                        amarilla++;
                        break;
                    case 3:
                    case 4:
                        rosa++;
                        break;
                    case 5:
                    case 6:
                        roja++;
                        break;
                    case 7:
                    case 8:
                        verde++;
                        break;
                    case 9:
                    case 0:
                        azul++;
                        break;
                    default:
                        Console.WriteLine("Dígito no válido.");
                        i--;
                        break;
                }
            }

            Console.WriteLine($"Autos con calcomanía amarilla: {amarilla}");
            Console.WriteLine($"Autos con calcomanía rosa: {rosa}");
            Console.WriteLine($"Autos con calcomanía roja: {roja}");
            Console.WriteLine($"Autos con calcomanía verde: {verde}");
            Console.WriteLine($"Autos con calcomanía azul: {azul}");
        }
    }
}
