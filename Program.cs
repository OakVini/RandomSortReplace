using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;




namespace AlgoritmosOrdenacao
{

    class Program
    {

        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("{0}:{1}:{2}:{3}", now.Hour, now.Minute, now.Second, now.Millisecond);
            Console.WriteLine();

            // Coloca bytes aleatorios nesse array.
            byte[] array = new byte[10];
            // Usa Random class e NextBytes (Metodos).
            // ... Mostra os Bytes com os seguintes metodos.
            Random random = new Random();
            random.NextBytes(array);
            Display(array);

            DateTime noww = DateTime.Now;
            Console.WriteLine("\n\n" + "{0}:{1}:{2}:{3}", noww.Hour, noww.Minute, noww.Second, noww.Millisecond);
            string nw = Convert.ToString((now - noww));

            if (nw.Contains("-"))

                Console.WriteLine("Tempo gasto: {0}", nw.Replace("-", ""));
            else
                Console.WriteLine("Tempo gasto: {0}", nw);

            Console.ReadLine();
        }

        static void Display(byte[] array)
        {

            int processed = 0;

            // Loop pra mostrar os bytes como array.
            foreach (byte value in array)
            {

                Console.Write(value);
                Console.Write(' ');

                if (++processed == 10)
                {
                    //Definindo um novo Array, so que manualmente e esse é int.
                    int[] arg = new int[10];
                    arg[0] = array[0];
                    arg[1] = array[1];
                    arg[2] = array[2];
                    arg[3] = array[3];
                    arg[4] = array[4];
                    arg[5] = array[5];
                    arg[6] = array[6];
                    arg[7] = array[7];
                    arg[8] = array[8];
                    arg[9] = array[9];
                    //Fim da definição do Array.

                    //Mostra o Array como int.
                    DisplayD(arg);
                    //Fim da 'mostração' do Array como int.

                    //Espaço pra nao ficar tudo junto.
                    Console.WriteLine("\n");
                    //Fim do espaço.

                    //Inicio do Bubble Sort (Super Simples).
                    //Define a variavel temporaria que armazena o numero.
                    int temp = 0;

                    //Cria o for.
                    //Write = 0, se Write < tamanho do Array(arg), faça write++
                    for (int write = 0; write < arg.Length; write++)
                    {
                        //Cria outro for.
                        //Sort = 0, se sort < tamano do Array(arg) - 1, faça sort++
                        for (int sort = 0; sort < arg.Length - 1; sort++)
                        {
                            //Cria um if.
                            //Se Arg[sort], que seria o numero, for maior Arg[sort + 1], ou seja, maior que o proximo, faça.
                            if (arg[sort] > arg[sort + 1])
                            {
                                //Variavel temporaria que armazena o numero temporariamente, armazena o numero atual + 1
                                temp = arg[sort + 1];
                                //Esse numero atual + 1, agora vira o outro numero.
                                arg[sort + 1] = arg[sort];
                                //E o outro numero vai pro temporario.
                                arg[sort] = temp;
                            }//Fim do if.
                        }//Fim do for.
                    }//Fim do outro for.

                    //For pra escrever os numeros ja ordenados.
                    Console.WriteLine("Array Ordenado: ");
                    for (int i = 0; i < arg.Length; i++)
                        Console.Write(arg[i] + " ");
                    //Fim do Bubble Sort (Super Simples).

                    //Aqui ele mata o ForEach caso ja tenha passado 10 repetições.
                    break;

                }//Fim do IF.

            }//Fim do ForEach.

        }//Fim do Display.

        static void DisplayD(int[] array)
        {

            Console.WriteLine('\n');

            // Loop through and display bytes in array.
            foreach (int value in array)
            {

                Console.Write(value);
                Console.Write(' ');

            }
        }

    }

}
