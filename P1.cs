namespace P1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de votos para el candidato 1: ");
            int vCandidato1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de votos para el candidato 2: ");
            int vCandidato2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de votos para el candidato 3: ");
            int vCandidato3 = Convert.ToInt32(Console.ReadLine());

            int totVotos = vCandidato1 + vCandidato2 + vCandidato3;

            float porCandidato1 = (float)vCandidato1 / totVotos * 100;
            float porCandidato2 = (float)vCandidato2 / totVotos * 100;
            float porCandidato3 = (float)vCandidato3 / totVotos * 100;

            int ganador;
            int maxVotos = Math.Max(vCandidato1, Math.Max(vCandidato2, vCandidato3));

            if (maxVotos == vCandidato1)
            {
                ganador = 1;
            }
            else if (maxVotos == vCandidato2)
            {
                ganador = 2;
            }
            else
            {
                ganador = 3;
            }

            Console.WriteLine("El candidato ganador es el número " + ganador + " con " + maxVotos + " votos, que representa el " + (maxVotos / (double)totVotos) * 100 + "% de los votos totales.");
            Console.WriteLine("Porcentaje de votos del candidato 1: " + porCandidato1 + "%");
            Console.WriteLine("Porcentaje de votos del candidato 2: " + porCandidato2 + "%");
            Console.WriteLine("Porcentaje de votos del candidato 3: " + porCandidato3 + "%");
        }
    }
}
