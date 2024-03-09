namespace P3
{
    internal class Program
    {
        static void Main()
        {
            const double precioPorKilo = 3000;
            const double descuento = 0.15;
            const int pesoMinimoDescuento = 10;
            const int cantidadClientes = 15;

            double totalIngresos = 0;

            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.WriteLine($"Cliente {i + 1}");
                Console.Write("Ingrese la cantidad de kilos de naranjas comprados: ");
                int kilos = Convert.ToInt32(Console.ReadLine());

                double precioTotal = kilos * precioPorKilo;

                if (kilos > pesoMinimoDescuento)
                {
                    double descuentoAplicado = precioTotal * descuento;
                    precioTotal -= descuentoAplicado;
                }

                Console.WriteLine($"El cliente debe pagar: ${precioTotal}");
                totalIngresos += precioTotal;
            }

            Console.WriteLine($"La tienda percibirá un total de: ${totalIngresos}");
        }
    }
}
