// Tworzenie tablicy 10x10
int[,] tablica = new int[10, 10];
//Pojawia się błąd podczas wypełniania tablicy, program bazowałem na tym co było na wykładzie i niestety nie potrafię sam go naprawić
// Zmienne pomocnicze do poruszania się po tablicy
int n = 1;      // Aktualna liczba do wstawienia
int x = 0;      // Aktualna kolumna
int y = 0;      // Aktualny wiersz
int kierunek = 0;   // Aktualny kierunek (0 - w prawo, 1 - w dół, 2 - w lewo, 3 - w górę)

// Pętla wypełniająca tablicę
for (int i = 0; i < 100; i++)
{
    tablica[y, x] = n;

    if (kierunek == 0)
    {
        if (x + 1 < 10 && tablica[y, x + 1] == 0)
            x++;
        else
            kierunek = 1;
    }
    else if (kierunek == 1)
    {
        if (y + 1 < 10 && tablica[y + 1, x] == 0)
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
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.Write(tablica[i, j] + " ");
    }
    Console.WriteLine();
}
