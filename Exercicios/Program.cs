// See https://aka.ms/new-console-template for more information

bool isWoman;
string mulher = "";

 Console.WriteLine("Mulheres maiores de 18 não pagam");

            Console.WriteLine("Vc é mulher? (s/n)");
            string mulher = Console.ReadLine();
            if (mulher == "s")
            {
                isWoman = true;
            }
            int idademulher = Convert.ToInt32(Console.ReadLine());
            if (idademulher > 18 && isWoman == true)
            {
                Console.WriteLine("vc é mulher e maior de 18");
            }
            else
            {
                Console.WriteLine("vc é homem ou menor de 18");
            }
