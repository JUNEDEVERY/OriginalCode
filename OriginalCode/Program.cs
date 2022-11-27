using System;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Programm
    {
        public static void genModel(double[,] kolresnaedproduc1, double[] function1, double[] zapas1)
        {
            Console.WriteLine("Для вас представлена математическая модель\n");
            Console.Write("F = "); //Формирование целевой функции из введенных данных
            for (int i = 0; i < function1.Length; i++)
            {
                Console.Write($"{function1[i]}x{i + 1} ");
                if (i != function1.Length - 1) // i - индекса x.
                                               // если индекса икса не равен длине введенных коэффициентов функции, в которой вычли -1
                                               // условно говоря, осуществляется проверка на последний х
                                               // если икс последний ставим ему +макс
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("-> max");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++) // 0 строки
            {
                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++) // 1 - столбцы
                {

                    Console.Write($"{kolresnaedproduc1[i, j]}x{j + 1} "); // т.к индекс массива с нуля. мы ставим +1 для того чтобы в уравнении начинать не с х0, а с х1

                    if (j != kolresnaedproduc1.GetLength(1) - 1) // j - индекс икса помощь от андрея с обьясниненим в painte
                                                                 // аналогичная проверка, что и выше. если индекс последнего икса не будет равен количеству ресурсов на ед. продукции, у которой вычли -1, ставим +
                                                                 // условно говоря, если икс не последний, то плюс иначе <=
                    {
                        Console.Write("+ ");

                    }
                    else
                    {
                        Console.WriteLine($"<= {zapas1[i]}");

                    }

                }

            }
            for (int i = 0; i < function1.Length; i++) // цикл который идет до длины целевой функции, от которой вычли -1.
                                                       // т.к если мы не вычтем -1, то он продолжит ставить индексы к иксу. т.к у нас всего х1 и х2, нам необходимо поставить -1, дабы он не начал ставить х3.
            {
                Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                if (i != function1.Length - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(" >=0; ");


                // цикл без i <= function.Length -1 позволяет добавлять х1,х2 и х3 взависимости от того, сколько указано значений в переменной function(целевая функция)

                //Console.Write($"x{i + 1} >= 0 "); // вывод строки с граничными условиями
            }
        }

        public static void genmodel2(double[,] kolresnaedproduc1, double[] function1, double[] zapas1)
        {
            Console.WriteLine("Для вас представлена математическая модель\n");
            Console.Write("F = "); //Формирование целевой функции из введенных данных
            for (int i = 0; i < function1.Length; i++)
            {
                Console.Write($"{function1[i]}x{i + 1} ");
                if (i != function1.Length - 1) // i - индекса x.
                                               // если индекса икса не равен длине введенных коэффициентов функции, в которой вычли -1
                                               // условно говоря, осуществляется проверка на последний х
                                               // если икс последний ставим ему +макс
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("-> max");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++) // 0 строки
            {
                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++) // 1 - столбцы
                {

                    Console.Write($"{kolresnaedproduc1[i, j]}x{j + 1} "); // т.к индекс массива с нуля. мы ставим +1 для того чтобы в уравнении начинать не с х0, а с х1

                    if (j != kolresnaedproduc1.GetLength(1) - 1) // j - индекс икса помощь от андрея с обьясниненим в painte
                                                                 // аналогичная проверка, что и выше. если индекс последнего икса не будет равен количеству ресурсов на ед. продукции, у которой вычли -1, ставим +
                                                                 // условно говоря, если икс не последний, то плюс иначе <=
                    {
                        Console.Write("+ ");

                    }
                    else
                    {
                        Console.WriteLine($"<= {zapas1[i]}");

                    }

                }

            }
            for (int i = 0; i < function1.Length; i++) // цикл который идет до длины целевой функции, от которой вычли -1.
                                                       // т.к если мы не вычтем -1, то он продолжит ставить индексы к иксу. т.к у нас всего х1 и х2, нам необходимо поставить -1, дабы он не начал ставить х3.
            {
                Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                if (i != function1.Length - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(" >=0; ");


                // цикл без i <= function.Length -1
                позволяет добавлять х1,х2 и х3 взависимости от того, сколько указано значений в переменной function(целевая функция)
            
//Console.Write($"x{i + 1} >= 0 "); // вывод строки с граничными условиями
}

            Console.Write("\n\nF` = -(");
            for (int i = 0; i < function1.Length; i++)
            {
                Console.Write($"{function1[i]}x{i + 1}");
                if (i != function1.Length - 1) // i - индекса x
                                               // аналогичная проверка что и выше
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(") -> min");
                }

            }
            Console.WriteLine();
            int fict1 = kolresnaedproduc1.GetLength(1) + 1; // индекс фиктивной переменной с количеством столбцов
                                                            // для создания фиктивной переменной нам необходимо получить индекс последней переменной и к ней прибавить +1

            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
            {
                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++)
                {
                    Console.Write($"{kolresnaedproduc1[i, j]}x{j + 1}");
                    if (j != kolresnaedproduc1.GetLength(1) - 1) // j - индекс икса
                    {
                        Console.Write(" + ");
                    }
                    else
                    {

                        Console.WriteLine($" + x{fict1} = {zapas1[i]}");
                        // для того, чтобы в каждой строке прибавлялся индекс фиктивной переменной +1
                        fict1 = 1 + fict1; // тоже попросить андрея в paint

                    }




                }


            }
            for (int i = 0; i <= function1.Length - 1; i++) // аналогичный цикл с условием выше
            {
                Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                if (i != function1.Length - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(" >=0; ");
            }

            for (int i = kolresnaedproduc1.GetLength(1) + 1; i < zapas1.Length + kolresnaedproduc1.GetLength(1) + 1; i++)
            // т.к у нас всего х1 и х2, нам необходимо начать цикл со следующего - т.е х3
            //цикл продолжаем до последнего х

            {

                Console.Write($"x{i}"); // вывод строки с граничными условиями
                if (i != zapas1.Length + kolresnaedproduc1.GetLength(1))
                {
                    Console.Write(", ");

                }
                else Console.Write(" - любое");

            }
            // Этап формирования таблицы
            Console.WriteLine();
            double[,] table1 = new double[zapas1.Length + 1, kolresnaedproduc1.GetLength(1) + kolresnaedproduc1.GetLength(0) + 1];
            // количество строк зависит от запаса ( видов ресурсов) +1 для получения строки оценок
            // kolresnaedproduc.GetLength(1) - первый 2 столбца зависят от количества видов продукции (p1 и p2)
            // kolresnaedproduc.GetLength(0) - следующие три столбца для фиктивных переменных. они формируются от количества видов ресурсов
            // сколько строк столько и столбцов с фиктивными переменными
            // +1 добавление столбца запаса ресурсов

            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
            {

                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++)
                {
                    table1[i, j] = kolresnaedproduc1[i, j];
                    // приравниваем значения первых двух столбцов

                }


            }
            for (int i = 0; i < function1.Length; i++) // заполнение строки оценок
            {
                table1[table1.GetLength(0) - 1, i] = function1[i];

                //
            }

            for (int i = 0; i < zapas1.Length; i++)
            {



                table1[i, table1.GetLength(1) - 1] = zapas1[i];

            }
            for (int i = 0; i < table1.GetLength(0) - 1; i++)
            {
                // цикл по i берет все кроме последней строки оценок
                for (int j = kolresnaedproduc1.GetLength(1); j < kolresnaedproduc1.GetLength(0) * 2 - 1; j++)
                {
                    if (i == j - kolresnaedproduc1.GetLength(1)) table1[i, j] = 1;

                }
                // цикл по j

            }
            Console.WriteLine();
            for (int i = 0; i < table1.GetLength(0); i++)
            {

                for (int j = 0; j < table1.GetLength(1); j++)
                {
                    Console.Write(table1[i, j] + " ");


                }
                Console.WriteLine();
            }
        }

        public static void genmodel3(double[,] kolresnaedproduc1, double[] function1, double[] zapas1)
        {
            Console.WriteLine("Для вас представлена математическая модель\n");
            Console.Write("F = "); //Формирование целевой функции из введенных данных
            for (int i = 0; i < function1.Length; i++)
            {
                Console.Write($"{function1[i]}x{i + 1} ");
                if (i != function1.Length - 1) // i - индекса x.
                                               // если индекса икса не равен длине введенных коэффициентов функции, в которой вычли -1
                                               // условно говоря, осуществляется проверка на последний х
                                               // если
                    икс последний ставим ему +макс
            {
                    Console.Write("+ ");
                }
else
                {
                    Console.Write("-> max");
                }

            }
            Console.WriteLine();
            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++) // 0 строки
            {
                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++) // 1 - столбцы
                {

                    Console.Write($"{kolresnaedproduc1[i, j]}x{j + 1} "); // т.к индекс массива с нуля. мы ставим +1 для того чтобы в уравнении начинать не с х0, а с х1

                    if (j != kolresnaedproduc1.GetLength(1) - 1) // j - индекс икса помощь от андрея с обьясниненим в painte
                                                                 // аналогичная проверка, что и выше. если индекс последнего икса не будет равен количеству ресурсов на ед. продукции, у которой вычли -1, ставим +
                                                                 // условно говоря, если икс не последний, то плюс иначе <=
                    {
                        Console.Write("+ ");

                    }
                    else
                    {
                        Console.WriteLine($"<= {zapas1[i]}");

                    }

                }

            }
            for (int i = 0; i < function1.Length; i++) // цикл который идет до длины целевой функции, от которой вычли -1.
                                                       // т.к если мы не вычтем -1, то он продолжит ставить индексы к иксу. т.к у нас всего х1 и х2, нам необходимо поставить -1, дабы он не начал ставить х3.
            {
                Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                if (i != function1.Length - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(" >=0; ");


                // цикл без i <= function.Length -1 позволяет добавлять х1,х2 и х3 взависимости от того, сколько указано значений в переменной function(целевая функция)

                //Console.Write($"x{i + 1} >= 0 "); // вывод строки с граничными условиями
            }

            Console.Write("\n\nF` = -(");
            for (int i = 0; i < function1.Length; i++)
            {
                Console.Write($"{function1[i]}x{i + 1}");
                if (i != function1.Length - 1) // i - индекса x
                                               // аналогичная проверка что и выше
                {
                    Console.Write(" + ");
                }
                else
                {
                    Console.Write(") -> min");
                }

            }
            Console.WriteLine();
            int fict1 = kolresnaedproduc1.GetLength(1) + 1; // индекс фиктивной переменной с количеством столбцов
                                                            // для создания фиктивной переменной нам необходимо получить индекс последней переменной и к ней прибавить +1

            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
            {
                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++)
                {
                    Console.Write($"{kolresnaedproduc1[i, j]}x{j + 1}");
                    if (j != kolresnaedproduc1.GetLength(1) - 1) // j - индекс икса
                    {
                        Console.Write(" + ");
                    }
                    else
                    {

                        Console.WriteLine($" + x{fict1} = {zapas1[i]}");
                        // для того, чтобы в каждой строке прибавлялся индекс фиктивной переменной +1
                        fict1 = 1 + fict1; // тоже попросить андрея в paint

                    }




                }


            }
            for (int i = 0; i <= function1.Length - 1; i++) // аналогичный цикл с условием выше
            {
                Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                if (i != function1.Length - 1)
                {
                    Console.Write(", ");
                }
                else Console.Write(" >=0; ");
            }

            for (int i = kolresnaedproduc1.GetLength(1) + 1; i < zapas1.Length + kolresnaedproduc1.GetLength(1) + 1; i++)
            // т.к у нас всего х1 и х2, нам необходимо начать цикл со следующего - т.е х3
            //цикл продолжаем до последнего х

            {

                Console.Write($"x{i}"); // вывод строки с граничными условиями
                if (i != zapas1.Length + kolresnaedproduc1.GetLength(1))
                {
                    Console.Write(", ");

                }
                else Console.Write(" - любое");

            }
            // Этап формирования таблицы
            Console.WriteLine();
            double[,] table1 = new double[zapas1.Length + 1, kolresnaedproduc1.GetLength(1) + kolresnaedproduc1.GetLength(0) + 1];
            // количество строк зависит от запаса ( видов ресурсов) +1 для получения строки оценок
            // kolresnaedproduc.GetLength(1) - первый 2 столбца зависят от количества видов продукции (p1 и p2)
            // kolresnaedproduc.GetLength(0) - следующие три столбца для фиктивных переменных. они формируются от количества видов ресурсов
            // сколько строк столько и столбцов с фиктивными переменными
            // +1 добавление столбца запаса ресурсов

            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
            {

                for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++)
                {
                    table1[i, j] = kolresnaedproduc1[i, j];
                    // приравниваем значения первых двух столбцов
                }


            }
            for (int i = 0; i < function1.Length; i++) // заполнение строки оценок
            {
                table1[table1.GetLength(0) - 1, i] = function1[i];

                //
            }

            for (int i = 0; i < zapas1.Length; i++)
            {



                table1[i, table1.GetLength(1) - 1] = zapas1[i];

            }
            for (int i = 0; i < table1.GetLength(0) - 1; i++)
            {
                // цикл по i берет все кроме последней строки оценок
                for (int j = kolresnaedproduc1.GetLength(1); j < kolresnaedproduc1.GetLength(0) * 2 - 1; j++)
                {
                    if (i == j - kolresnaedproduc1.GetLength(1)) table1[i, j] = 1;

                }
                // цикл по j

            }
            Console.WriteLine();
            for (int i = 0; i < table1.GetLength(0); i++)
            {

                for (int j = 0; j < table1.GetLength(1); j++)
                {
                    Console.Write(table1[i, j] + " ");


                }
                Console.WriteLine();
            }
            // Вывод промежуточных результатов

            Console.WriteLine("\nПромежуточные результаты");
            Console.WriteLine($"F`={table1[table1.GetLength(0) - 1, table1.GetLength(1) - 1]}");
            Console.WriteLine($"F={Math.Abs(table1[table1.GetLength(0) - 1, table1.GetLength(1) - 1])}");
            for (int d = 0; d < function1.Length; d++)
            {
                Console.WriteLine($"x{d + 1} = 0");
            }
            for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
            {
                Console.WriteLine($"x{kolresnaedproduc1.GetLength(1) + 1 + i} = {zapas1[i]} ");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\t\tЗдравствуйте!");
            Console.WriteLine("\t\t\tДля вас была разработана обучающая программа по теме");
            Console.WriteLine("\t\t\tПостроение канонической задачи минимазации (КЗМ) и результатов первой симплекс-таблицы");
            Console.WriteLine("\t\tПрограмма, помимо решения определенной задачи, также содержит тестирование, в котором Вы можете проверить свои знания");
            Console.WriteLine("\t\t\t\tТяжело в учении, легко в бою! Желаем удачи!");
            Console.WriteLine("\t\t\t\tНажмите любую клавишу для перехода в меню");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("1 - Решение задачи по построению канонической задачи минимизации и результатов первой симплекс-таблицы");
            Console.WriteLine("2 - Проверить себя");
            int change = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (change)
            {
                case 1:
                    //Console.WriteLine("Введите количество продукции = >");
                    //int kolprod = Convert.ToInt32(Console.ReadLine());
                    //Console.WriteLine("Введите количество видов ресурсов = >");
                    //int kolvidres = Convert.ToInt32(Console.ReadLine());

                    //double[,] kolresnaedproduc = new double[kolvidres,kolprod ]; // задаем размерность по строке и столбцам
                    //double[] function = new double[kolprod];
                    //double[] zapas = new double[kolvidres];


                    // строкой является кол-во видов ресурсов, а столбцом кол-во продукции


                    //Console.WriteLine("Введите доход от реализации ед.продукции => ");
                    //for (int i = 0; i < function.Length; i++)
                    //{
                    // Console.Write($"Введите {i + 1} элемент целевой функции"); // I+1 т.к отсчет начинается с нуля
                    // function[i] = Convert.ToDouble(Console.ReadLine());

                    //}
                    //Console.WriteLine("Введите запас ресурсов => ");
                    //for (int i = 0; i < zapas.Length; i++)
                    //{
                    // Console.Write($"Введите {i + 1} элемент запасов ресурсов");
                    // zapas[i] = Convert.ToDouble(Console.ReadLine());

                    //}

                    //for (int i = 0; i < kolresnaedproduc.GetLength(0); i++)
                    //{

                    // for (int j = 0; j < kolresnaedproduc.GetLength(1); j++)
                    // {
                    // Console.Write($"Введите количество {i + 1} вида ресурсов на производство {j + 1} продукции => ");
                    // kolresnaedproduc[i, j] = Convert.ToDouble(Console.ReadLine());


                    // }

                    //}
                    double[,] kolresnaedproduc = new double[,] { { 6, 6 }, { 4, 2 }, { 4, 8 } }; // двумерный массив для хранения двух столбцов. она же - матрица
                    double[] function = new double[] { 12, 15 }; // одномерный массив для хранения данных целевой функции
                    double[] zapas = new double[] { 36, 20, 40 }; // одномерный массив для храненый данных о запасе ресурсов

                    Console.Write("F = "); //Формирование целевой функции из введенных данных
                    for (int i = 0; i < function.Length; i++)
                    {
                        Console.Write($"{function[i]}x{i + 1} ");
                        if (i != function.Length -
                        1) // i - индекса x.
                           // если индекса икса не равен длине введенных коэффициентов функции, в которой вычли -1
                           // условно говоря, осуществляется проверка на последний х
                           // если икс последний ставим ему +макс
                        {
                            Console.Write("+ ");
                        }
                        else
                        {
                            Console.Write("-> max");
                        }

                    }
                    Console.WriteLine();
                    for (int i = 0; i < kolresnaedproduc.GetLength(0); i++) // 0 строки
                    {
                        for (int j = 0; j < kolresnaedproduc.GetLength(1); j++) // 1 - столбцы
                        {

                            Console.Write($"{kolresnaedproduc[i, j]}x{j + 1} "); // т.к индекс массива с нуля. мы ставим +1 для того чтобы в уравнении начинать не с х0, а с х1

                            if (j != kolresnaedproduc.GetLength(1) - 1) // j - индекс икса помощь от андрея с обьясниненим в painte
                                                                        // аналогичная проверка, что и выше. если индекс последнего икса не будет равен количеству ресурсов на ед. продукции, у которой вычли -1, ставим +
                                                                        // условно говоря, если икс не последний, то плюс иначе <=
                            {
                                Console.Write("+ ");

                            }
                            else
                            {
                                Console.WriteLine($"<= {zapas[i]}");

                            }

                        }

                    }
                    for (int i = 0; i < function.Length; i++) // цикл который идет до длины целевой функции, от которой вычли -1.
                                                              // т.к если мы не вычтем -1, то он продолжит
                                                              // ставить индексы к иксу. т.к у нас всего х1 и х2, нам необходимо поставить - 1, дабы он не начал ставить х3.
                    {
                        Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                        if (i != function.Length - 1)
                        {
                            Console.Write(", ");
                        }
                        else Console.Write(" >=0; "); // попросить андрея обьяснить подробнее


                        // цикл без i <= function.Length -1 позволяет добавлять х1,х2 и х3 взависимости от того, сколько указано значений в переменной function(целевая функция)

                        //Console.Write($"x{i + 1} >= 0 "); // вывод строки с граничными условиями
                    }

                    // Построение канонической задачи минимизации


                    Console.Write("\n\nF` = -(");
                    for (int i = 0; i < function.Length; i++)
                    {
                        Console.Write($"{function[i]}x{i + 1}");
                        if (i != function.Length - 1) // i - индекса x
                                                      // аналогичная проверка что и выше
                        {
                            Console.Write(" + ");
                        }
                        else
                        {
                            Console.Write(") -> min");
                        }

                    }
                    Console.WriteLine();
                    int fict = kolresnaedproduc.GetLength(1) + 1; // индекс фиктивной переменной с количеством столбцов
                                                                  // для создания фиктивной переменной нам необходимо получить индекс последней переменной и к ней прибавить +1

                    for (int i = 0; i < kolresnaedproduc.GetLength(0); i++)
                    {
                        for (int j = 0; j < kolresnaedproduc.GetLength(1); j++)
                        {
                            Console.Write($"{kolresnaedproduc[i, j]}x{j + 1}");
                            if (j != kolresnaedproduc.GetLength(1) - 1) // j - индекс икса
                            {
                                Console.Write(" + ");
                            }
                            else
                            {

                                Console.WriteLine($" + x{fict} = {zapas[i]}");
                                // для того, чтобы в каждой строке прибавлялся индекс фиктивной переменной +1
                                fict = 1 + fict; // тоже попросить андрея в paint

                            }




                        }


                    }
                    for (int i = 0; i <= function.Length - 1; i++) // аналогичный цикл с условием выше
                    {
                        Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                        if (i != function.Length - 1)
                        {
                            Console.Write(", ");
                        }
                        else Console.Write(" >=0; ");
                    }

                    for (int i = kolresnaedproduc.GetLength(1) + 1; i < zapas.Length + kolresnaedproduc.GetLength(1) + 1; i++)
                    // т.к у нас всего х1 и х2, нам необходимо начать цикл со следующего - т.е х3
                    //цикл продолжаем до последнего х

                    {

                        Console.Write($"x{i}"); // вывод строки с граничными условиями
                        if (i != zapas.Length + kolresnaedproduc.GetLength(1))
                        {
                            Console.Write(", ");

                        }
                        else Console.Write(" - любое");

                    }





                    // Этап формирования таблицы
                    Console.WriteLine();
                    double[,] table = new double[zapas.Length + 1, kolresnaedproduc.GetLength(1) + kolresnaedproduc.GetLength(0) + 1];
                    // количество строк зависит от запаса ( видов ресурсов) +1 для получения строки оценок
                    // kolresnaedproduc.GetLength(1) - первый 2 столбца зависят от количества видов продукции (p1 и p2)
                    // kolresnaedproduc.GetLength(0) - следующие три столбца для фиктивных переменных. они формируются от количества видов ресурсов
                    // сколько строк столько и столбцов с фиктивными переменными
                    //
                    +1 добавление столбца запаса ресурсов
            
for (int i = 0; i < kolresnaedproduc.GetLength(0); i++)
                    {

                        for (int j = 0; j < kolresnaedproduc.GetLength(1); j++)
                        {
                            table[i, j] = kolresnaedproduc[i, j];
                            // приравниваем значения первых двух столбцов

                        }


                    }
                    for (int i = 0; i < function.Length; i++) // заполнение строки оценок
                    {
                        table[table.GetLength(0) - 1, i] = function[i];

                        //
                    }

                    for (int i = 0; i < zapas.Length; i++)
                    {



                        table[i, table.GetLength(1) - 1] = zapas[i];

                    }
                    for (int i = 0; i < table.GetLength(0) - 1; i++)
                    {
                        // цикл по i берет все кроме последней строки оценок
                        for (int j = kolresnaedproduc.GetLength(1); j < kolresnaedproduc.GetLength(0) * 2 - 1; j++)
                        {
                            if (i == j - kolresnaedproduc.GetLength(1)) table[i, j] = 1;

                        }
                        // цикл по j

                    }
                    Console.WriteLine();
                    for (int i = 0; i < table.GetLength(0); i++)
                    {

                        for (int j = 0; j < table.GetLength(1); j++)
                        {
                            Console.Write(table[i, j] + " ");


                        }
                        Console.WriteLine();
                    }
                    // Вывод промежуточных результатов

                    Console.WriteLine("\nПромежуточные результаты");
                    Console.WriteLine($"F`={table[table.GetLength(0) - 1, table.GetLength(1) - 1]}");
                    Console.WriteLine($"F={Math.Abs(table[table.GetLength(0) - 1, table.GetLength(1) - 1])}");
                    for (int d = 0; d < function.Length; d++)
                    {
                        Console.WriteLine($"x{d + 1} = 0");
                    }
                    for (int i = 0; i < kolresnaedproduc.GetLength(0); i++)
                    {
                        Console.WriteLine($"x{kolresnaedproduc.GetLength(1) + 1 + i} = {zapas[i]} ");
                    }
                    break;
                // Проверь себя
                case 2:
                    Console.WriteLine("\nБаллы по тестированию выставляются следующим образом");
                    Console.WriteLine("9-10 правильных ответов - оценка отлично");
                    Console.WriteLine("7-8 правильных ответов - оценка хорошо");
                    Console.WriteLine("5-6 правильных ответов - оценка удовлетворительно");
                    Console.WriteLine("0-3 правильных ответов - оценка неудовлетворительно");
                    Console.WriteLine("\nНажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    Random rnd = new Random();
                    int x = rnd.Next(2, 5), y = rnd.Next(4, 8);
                    double[,] kolresnaedproduc1 = new double[y, x]; // двумерный массив для хранения двух столбцов. она же - матрица
                    double[] function1 = new double[x]; // одномерный массив для хранения данных целевой функции
                    double[] zapas1 = new double[y]; // одномерный массив для храненый данных о запасе ресурсов
                    for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
                    {
                        for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++)
                        {
                            kolresnaedproduc1[i, j] = rnd.Next(1, 10);
                            function1[j] = rnd.Next(1, 15);


                        }
                        zapas1[i] = rnd.Next(20, 50);

                    }
                    int pravda = 0;
                    genModel(kolresnaedproduc1, function1, zapas1);

                    Console.WriteLine("\n Вопрос 1. К чему будет стремится целевая функция в канонической задаче минимизации(КЗМ) ? ");
                    string otv = Convert.ToString(Console.ReadLine());
                    if (otv == "min")
                    {
                        Console.WriteLine("Ответ верный");
                        pravda = pravda + 1;

                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный. Целевая функция стремится к min");
                    }

                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    genModel(kolresnaedproduc1, function1, zapas1);
                    Console.WriteLine("\n Вопрос 2. Сколько используется видов продукции?");
                    int vidprod = Convert.ToInt32(Console.ReadLine());
                    if (vidprod == function1.Length)
                    {
                        Console.WriteLine($"Ответ верный! Всего видов продукции {function1.Length}");
                        pravda = pravda + 1;


                    }
                    else
                    {
                        Console.WriteLine($"Ответ неверный Всего видов продукции {function1.Length}");

                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    genModel(kolresnaedproduc1, function1, zapas1);
                    Console.WriteLine("\n Вопрос 3.Сколько фиктивных переменных используется в построенной математической модели?");
                    int fictive = Convert.ToInt32(Console.ReadLine());
                    if (y == fictive)
                    {
                        Console.WriteLine("Ответ верный. Всего фиктивных переменных");
                        pravda = pravda + 1;
                        Console.WriteLine("Нажмите любую клавишу для
                        продолжения!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine($"Ответ не верный, т.к количество фиктивных переменных {y}");
                        Console.WriteLine("Нажмите любую клавишу для продолжения!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    genmodel2(kolresnaedproduc1, function1, zapas1);
                    Console.WriteLine($"\n Вопрос 4. Чему равно х {kolresnaedproduc1.GetLength(1) + kolresnaedproduc1.GetLength(0)}?");
                    int x1 = Convert.ToInt32(Console.ReadLine());
                    if (x1 == zapas1[zapas1.Length - 1])
                    {
                        Console.WriteLine("Ответ верный! ");
                        pravda = pravda + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный, т.к ");
                        Console.WriteLine($"X = {zapas1[kolresnaedproduc1.GetLength(1)]}");
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n Вопрос 5.Какой знак ставится в процессе формирования канонической задачи минимизации целевой функции?");
                    string otv11 = Convert.ToString(Console.ReadLine());
                    if (otv11 == "-")
                    {
                        Console.WriteLine("Ответ верный");
                        pravda = pravda + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный, т.к в процессе формирования канонической задачи минимизации целевой функции перед коэффициентами ставится знак - (минус)");
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    genmodel3(kolresnaedproduc1, function1, zapas1);
                    Console.WriteLine("\n Вопрос 6. Является ли данное решение окончательным?");
                    string otv111 = Convert.ToString(Console.ReadLine());
                    if ((otv111 == "Да") || (otv111 == "ДА") || (otv111 == "да"))
                    {
                        Console.WriteLine("Ответ неверный");
                        Console.WriteLine("Данное решение не явлется окончательным, т.к формируется математическая модель,КЗМ и первая симплекс таблица");
                    }
                    else if ((otv111 == "НЕТ") || (otv111 == "Нет") || (otv111 == "нет"))
                    {
                        Console.WriteLine("Ответ верный!");
                        pravda = pravda + 1;
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n Вопрос 7. Чему равна целевая функция после построения первой симплекс таблицы?");
                    string otv1111 = Convert.ToString(Console.ReadLine());
                    if (otv1111 == "0")
                    {
                        Console.WriteLine("Ответ верный");
                        pravda = pravda + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный!");
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n Вопрос 8. Чему равна F` после построения первой симплекс таблицы?");
                    string otv11111 = Convert.ToString(Console.ReadLine());
                    if (otv11111 == "0")
                    {
                        Console.WriteLine("Ответ верный");
                        pravda = pravda + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный!");
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    Console.WriteLine("\n Вопрос 9. Какой знак будут иметь ограничения в КЗМ?");

                    string otv111111 = Convert.ToString(Console.ReadLine());
                    if (otv111111 == "=")
                    {
                        Console.WriteLine("Ответ верный");
                        pravda = pravda + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный!");
                    }
                    Console.WriteLine("Нажмите любую клавишу для продолжения!");
                    Console.ReadKey();
                    Console.Clear();
                    genmodel3(kolresnaedproduc1, function1, zapas1);
                    Console.WriteLine("\n Вопрос 10. Сколько строк и стобцов содержит первая симпекс таблица?");
                    Console.WriteLine("Ответ представить ввиде суммы строк и столбцов (m+n)");
                    int otv1111111 = Convert.ToInt32(Console.ReadLine());
                    if (otv1111111 == x + y + y + 2)
                    {
                        Console.WriteLine("Ответ верный");
                        pravda = pravda + 1;
                    }
                    else
                    {
                        Console.WriteLine("Ответ неверный!");
                        Console.WriteLine("Сумма строк и столбцов равна = " + x + y + y + 2);
                    }
                    Console.WriteLine("Тестирование закончилось.");
                    Console.WriteLine("Загрузка результатов тестирования..");
                    Console.WriteLine("Загрузка результатов тестирования...");
                    Console.WriteLine("Загрузка результатов тестирования.....");


                    Console.WriteLine($"В результате тестирования вы набрали {pravda}
                    баллов из 10");
            if (pravda >= 9)
                    {
                        Console.WriteLine("Вы получили оценку 5. Вы молодец!");
                    }
                    else if (pravda >= 7)
                    {
                        Console.WriteLine("Вы получили оценку 4. Не плохо!");
                    }
                    else if (pravda >= 5)
                    {
                        Console.WriteLine("Вы получили оценку 3. Могло быть и лучше!");
                    }
                    else if (pravda >= 3)
                    {
                        Console.WriteLine("Вы получили оценку 2. Может быть в другой раз....");
                    }
                    // является ли решением окончательным?
                    // какой знак ставится перед -
                    // сколько неравенств зависит от количества переменных



                    //// Построение канонической задачи минимизации


                    //Console.Write("\n\nF` = -(");
                    //for (int i = 0; i < function1.Length; i++)
                    //{
                    // Console.Write($"{function1[i]}x{i + 1}");
                    // if (i != function1.Length - 1) // i - индекса x
                    // // аналогичная проверка что и выше
                    // {
                    // Console.Write(" + ");
                    // }
                    // else
                    // {
                    // Console.Write(") -> min");
                    // }

                    //}
                    //Console.WriteLine();
                    //int fict1 = kolresnaedproduc1.GetLength(1) + 1; // индекс фиктивной переменной с количеством столбцов
                    // // для создания фиктивной переменной нам необходимо получить индекс последней переменной и к ней прибавить +1

                    //for (int i = 0; i < kolresnaedproduc1.GetLength(0); i++)
                    //{
                    // for (int j = 0; j < kolresnaedproduc1.GetLength(1); j++)
                    // {
                    // Console.Write($"{kolresnaedproduc1[i, j]}x{j + 1}");
                    // if (j != kolresnaedproduc1.GetLength(1) - 1) // j - индекс икса
                    // {
                    // Console.Write(" + ");
                    // }
                    // else
                    // {

                    // Console.WriteLine($" + x{fict1} = {zapas1[i]}");
                    // // для того, чтобы в каждой строке прибавлялся индекс фиктивной переменной +1
                    // fict1 = 1 + fict1; // тоже попросить андрея в paint

                    // }




                    // }


                    //}
                    //for (int i = 0; i <= function1.Length - 1; i++) // аналогичный цикл с условием выше
                    //{
                    // Console.Write($"x{i + 1}"); // вывод строки с граничными условиями
                    // if (i != function1.Length - 1)
                    // {
                    // Console.Write(", ");
                    // }
                    // else Console.Write(" >=0; ");
                    //}

                    //for (int i = kolresnaedproduc1.GetLength(1) + 1; i < zapas1.Length + kolresnaedproduc1.GetLength(1) + 1; i++)
                    //// т.к у нас всего х1 и х2, нам необходимо начать цикл со следующего - т.е х3
                    ////цикл продолжаем до последнего х

                    //{

                    // Console.Write($"x{i}"); // вывод строки с граничными условиями
                    // if (i != zapas1.Length + kolresnaedproduc1.GetLength(1))
                    // {
                    // Console.Write(", ");

                    // }
                    // else Console.Write(" - любое");

                    //}


                    break;
            }






        }
    }
}