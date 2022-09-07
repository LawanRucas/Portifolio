using System.Diagnostics;

internal class NewBaseType
{
    static void Main(string[] args)
    {
   
      bool isWoman = false;
      string mulher = "n";

 Console.WriteLine("Mulheres maiores de 18 não pagam");

            Console.WriteLine("Vc é mulher? (s/n)");
            mulher = Convert.ToString(Console.ReadLine());
            if (mulher == "s")
            {
                isWoman = true;
            }
           Console.WriteLine("Qual sua idade? ");
           int idademulher = Convert.ToInt32(Console.ReadLine());
            if (idademulher > 18 && isWoman == true)
            {
                Console.WriteLine("vc é mulher e maior de 18");
            }
            Console.WriteLine("Pode entrar");
    }
}
