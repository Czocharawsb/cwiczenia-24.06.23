namespace Zadanie_1
{
    internal class Program
    {


        static void Main(string[] args)

        {
            const int wys_tab = 10;
            const int szer_tab = 10;
            int[,] tab = new int[wys_tab, szer_tab];
            int licznik =0;
            int wys_temp = 0;

            for (int wys = 0; wys < wys_tab; wys++)
            {
                wys_temp = wys;
                for (int szer = 0; szer < szer_tab; szer++)
                {
                    if ((wys + 1) % 2 == 0)
                    {
                        
                        tab[wys, szer] = licznik;
                        licznik++;





                    }
                    else
                    {   if(wys_temp>=2)
                        {

                            licznik--;
                            wys_temp = 0;
                        }
                        if (szer == 0)
                        {
                            licznik += 10;
                        }
                        tab[wys, szer] = licznik;
                        if(szer!=9)
                        licznik--;
                        if (szer == 9)
                        {   
                            licznik += 10;
                        }
                    }
                }


            }

            for (int wys = 0; wys < wys_tab; wys++)
            {
                for (int szer = 0; szer < szer_tab; szer++)
                {


                    Console.Write(tab[wys, szer] + "\t");




                }

                Console.WriteLine("\n");
            }
        }
    }
}