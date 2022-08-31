public class Program
{
    static int[] Notas = { 100, 50, 20, 10, 5, 2 };
    public static void Main()
    {
        Console.WriteLine("Digite o valor desejado:");
        var saque = decimal.Parse(Console.ReadLine());
        int[] nNotas = Notas;
        if (saque <= 0) Console.WriteLine("Valor indisponível");
        else
        {
            for (int i = 0; i <= 2; i++)
            {
                var s = saque;
                Console.WriteLine("/// OPÇÃO DE SAQUE " + (i + 1) + " ///");

                int[] Cdl = new int[nNotas.Length];


                for (int j = 0; j < (nNotas.Length); j++)
                {
                    Cdl[j] = Convert.ToInt32(Math.Floor(s / nNotas[j]));
                    s -= (nNotas[j] * Cdl[j]);
                }

                for (int j = 0; j < (Cdl.Length); j++)
                {
                    if (Cdl[j] != 0)
                        Console.WriteLine(Cdl[j] + " Unidades de Cedula de " + nNotas[j] + " reais");
                }
                nNotas = nNotas.Where(v => v != nNotas[0]).ToArray();
            }

            Console.ReadKey();
        }
    }
}