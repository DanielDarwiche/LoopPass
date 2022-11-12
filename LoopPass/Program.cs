using System;
using System.Diagnostics;

namespace LoopPass
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Loop för att skriva ut alla siffror från 0-9.     i 3-siffer-intervall
            //for (int i1 = 0; i1 <= 9; i1++)
            //{
            //    for (int i2 = 0; i2 <= 9; i2++)
            //    {
            //        for (int i3 = 0; i3 <= 9; i3++)
            //        {
            //            Console.WriteLine($"{i1},{i2},{i3}");
            //        }
            //    }
            //}



            ////Loop för att skriva ut alla siffror från 0-9.     i 4-siffer-intervall
            /////Panelen visar dock inte allt?
            //for (int i1 = 0; i1 <= 9; i1++)               
            //{
            //    for (int i2 = 0; i2 <= 9; i2++)
            //    {
            //        for (int i3 = 0; i3 <= 9; i3++)
            //        {
            //            for (int i4 = 0; i4 <= 9; i4++)
            //            {
            //                Console.WriteLine($"{i1},{i2},{i3},{i4}");
            //            }
            //        }
            //    }
            //}

            //////Loop för att skriva ut alla siffror från 0-9.     i 8-siffer-intervall
            //for (int i1 = 0; i1 <= 9; i1++)               
            //{
            //    for (int i2 = 0; i2 <= 9; i2++)
            //    {
            //        for (int i3 = 0; i3 <= 9; i3++)
            //        {
            //            for (int i4 = 0; i4 <= 9; i4++)
            //            {
            //                for (int i5 = 0; i5 <= 9; i5++)
            //                {
            //                    for (int i6 = 0; i6 <= 9; i6++)
            //                    {
            //                        for (int i7 = 0; i7<= 9; i7++)
            //                        {
            //                            for (int i8 = 0; i8 <= 9; i8++)
            //                            {
            //                                Console.WriteLine($"{i1},{i2},{i3},{i4},{i5},{i6},{i7},{i8}");

            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
            string[] bok = new string[29];
            bok[0] = "a";
            bok[1] = "b";
            bok[2] = "c";
            bok[3] = "d";
            bok[4] = "e";
            bok[5] = "f";
            bok[6] = "g";
            bok[7] = "h";
            bok[8] = "i";
            bok[9] = "j";
            bok[10] = "k";
            bok[11] = "l";
            bok[12] = "m";
            bok[13] = "n";
            bok[14] = "o";
            bok[15] = "p";
            bok[16] = "q";
            bok[17] = "r";
            bok[18] = "s";
            bok[19] = "t";
            bok[20] = "u";
            bok[21] = "v";
            bok[22] = "w";
            bok[23] = "y";
            bok[24] = "x";
            bok[25] = "z";
            bok[26] = "å";
            bok[27] = "ä";
            bok[28] = "ö";

            //for (int i1 = 0; i1 <= 28; i1++)
            //{
            //    for (int i2 = 0; i2 <= 28; i2++)
            //    {
            //        for (int i3 = 0; i3 <= 28; i3++)
            //        {
            //            Console.WriteLine($"{bok[i1]},{bok[i2]},{bok[i3]}");
            //        }
            //    }
            //}
            ////samma med bokstäver från a - ö, i 3-bokstavs-intervaller
            Stopwatch timer = new Stopwatch();


            timer.Start();

            for (int i1 = 0; i1 <= 28; i1++)
            {
                for (int i2 = 0; i2 <= 28; i2++)
                {
                    for (int i3 = 0; i3 <= 28; i3++)
                    {
                        for (int i4 = 0; i4 <= 28; i4++)
                        {
                            for (int i5 = 0; i5 <= 28; i5++)
                            {
                                for (int i6 = 0; i6 <= 28; i6++)
                                {
                                    for (int i7 = 0; i7 <= 28; i7++)
                                    {
                                        for (int i8 = 0; i8 <= 28; i8++)
                                        {
                                            for (int i9 = 0; i9 <= 28; i9++)
                                            {
                                                for (int i10 = 0; i10 <= 28; i10++)
                                                {
                                                    Console.WriteLine($"{bok[i1]},{bok[i2]}," +
                                                        $"{bok[i3]},{bok[i4]},{bok[i5]},{bok[i6]}," +
                                                        $"{bok[i7]},{bok[i8]},{bok[i9]},{bok[i10]}");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine("Saved to DB - " + timer.Elapsed.ToString());
            timer.Stop();
            ////samma med bokstäver från a - ö , i 10-bokstavs-intervaller
        }
    }
}
