
        float nota1 = 0;
        float nota2 = 0;
        float nota3 = 0;

        Console.WriteLine("vou calcular a media de 3 notas");
        Console.WriteLine("Qual a sua nota 1?");
        nota1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual a sua nota 2?");
        nota2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Qual a sua nota 3?");
        nota3 = Convert.ToInt32(Console.ReadLine());

        var media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7)
        {
            Console.WriteLine("Aprovado");
        }
        else
        {
            Console.WriteLine("Reprovado");
        }
        Console.WriteLine(4%2);