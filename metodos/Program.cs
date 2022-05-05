using System;

namespace MinhaAplicacao
{
    class Programa
    {
        static void Main(string[] args)
        {
            //metodo1();
            //metodo2();
            //metodo3("ANDREA SILVESTRE PEREIRA DA SILVA");
            //metodo_pais("Argentina");
            //metodo_pais();
            //metodo_pais("Estados Unidos");
            //metodo_nome_idade("Juliana Paulina", 32);
            //Console.WriteLine("A média das notas é: " + media_nota(7,8));
            //Console.WriteLine("Soma: " + soma(33, 20));
            //criancas(crianca3: "Andrea", crianca1: "Marisa", crianca2: "Geovane"); 

            int myNum1 = soma(8, 5);
            double myNum2 = soma(4.3, 6.26);
            Console.WriteLine("Int: " + myNum1);
            Console.WriteLine("Double: " + myNum2.ToString("F"));
        }


        //metodos
        static void metodo1()
        {
            Console.WriteLine("Meu primmeiro método.");
        }

        static void metodo2()
        { 
            Console.WriteLine("A soma dos números 2,5,3,10 é: " + (2+5+3+10));
        }

        static void metodo3(string nome_completo)
        {
            Console.WriteLine("O nome completo informado é: " + nome_completo);
        }

        static void metodo_pais(string pais = "Brasil")
        {
            Console.WriteLine(pais);
        }

        static void metodo_nome_idade(string nome, int idade)
        {
            Console.WriteLine("A idade de " + nome + " é " + idade + " anos");
        }

        static double media_nota(double nota1, double nota2)
        {
            return (nota1 + nota2)/2;
        }
        static int soma(int num1, int num2) //igual ao metodo de baixo, muda só o tipo de variavel
        {
            return num1 + num2;
        }
        static double soma(double num1, double num2) //mesmo metodo de cima, so muda o tipo
        {
            return num1 + num2;
        }
        static void criancas(string crianca1, string crianca2, string crianca3)
        {
            Console.WriteLine("A criança 3 é: " + crianca3);
        }
    }
}