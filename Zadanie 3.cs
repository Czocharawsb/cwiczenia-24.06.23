namespace Zadanie_1
{   //Pojawia się błąd podczas wypełniania tablicy, program bazowałem na tym co było na wykładzie i niestety nie potrafię sam go naprawić
    internal class Program
    {


        static void Main(string[] args)

        {
            int wys_tab;
            
            while (true) 
            {
                  wys_tab = int.Parse(Console.ReadLine());
                if (wys_tab == 0 || wys_tab < 0)
                {
                    Console.WriteLine("Złe dane!");
                }
                else
                    break;
            }
            Console.WriteLine("Tablica z zadania 1 :1 \nTablica z zadania 2: 2");
            int input=int.Parse(Console.ReadLine());
            



            int szer_tab = wys_tab;

            switch(input)
            {
                case 1:
                    int[,] tab = new int[wys_tab, szer_tab];
                    int licznik = 0;
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
                            {
                                if (wys_temp >= 2)
                                {

                                    licznik--;
                                    wys_temp = 0;
                                }
                                if (szer == 0)
                                {
                                    licznik += 10;
                                }
                                tab[wys, szer] = licznik;
                                if (szer != 9)
                                    licznik--;
                                if (szer == szer_tab - 1)
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
                    break;

                case 2:
                    int[,] tablica = new int[wys_tab, szer_tab];

                    // Zmienne pomocnicze do poruszania się po tablicy
                    int n = 1;      // Aktualna liczba do wstawienia
                    int x = 0;      // Aktualna kolumna
                    int y = 0;      // Aktualny wiersz
                    int kierunek = 0;   // Aktualny kierunek (0 - w prawo, 1 - w dół, 2 - w lewo, 3 - w górę)

                    // Pętla wypełniająca tablicę
                    for (int i = 0; i < wys_tab*szer_tab; i++)
                    {
                        tablica[y, x] = n;

                        if (kierunek == 0)
                        {
                            if (x + 1 < szer_tab && tablica[y, x + 1] == 0)
                                x++;
                            else
                                kierunek = 1;
                        }
                        else if (kierunek == 1)
                        {
                            if (y + 1 < szer_tab && tablica[y + 1, x] == 0)
                                y++;
                            else
                                kierunek = 2;
                        }
                        else if (kierunek == 2)
                        {
                            if (x - 1 >= 0 && tablica[y, x - 1] == 0)
                                x--;
                            else
                                kierunek = 3;
                        }
                        else if (kierunek == 3)
                        {
                            if (y - 1 >= 0 && tablica[y - 1, x] == 0)
                                y--;
                            else
                                kierunek = 0;
                        }

                        n++;
                    }

                    // Wypisanie tablicy
                    for (int i = 0; i < szer_tab; i++)
                    {
                        for (int j = 0; j < szer_tab; j++)
                        {
                            Console.Write(tablica[i, j] + " ");
                        }
                        Console.WriteLine();
                    }

                    break;


                default:
                    Console.WriteLine("Niewłaściwy wybór!");
                    break;
            }
            



            }
                
        
    }
}