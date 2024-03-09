namespace P8
{
    internal class Program
    {
        static void Main()
        {
            const int totalAlumnos = 10;
            const double calificacionMinimaAprobatoria = 70;

            int reprobados = 0;

            for (int i = 0; i < totalAlumnos; i++)
            {
                Console.Write($"Ingrese la calificación del alumno {i + 1}: ");
                double calificacion = Convert.ToDouble(Console.ReadLine());

                if (calificacion < calificacionMinimaAprobatoria)
                {
                    reprobados++;
                }
            }

            double porcentajeReprobados = (double)reprobados / totalAlumnos * 100;

            Console.WriteLine($"El porcentaje de alumnos reprobados es: {porcentajeReprobados}%");
        }
    }
}
