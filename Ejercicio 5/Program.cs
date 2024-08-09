string[,] matriz = new string[5,5];
int cont = 0;

for(int i=0; i<matriz.GetLength(0); i++)
{
    for(int f=0; f < matriz.GetLength(1); f++)
    {   
        cont++;
        if (cont % 2 != 0)
        {
            matriz[i, f] = "i";
        }
        else matriz[i, f] = "p";
    }

}



for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int f = 0; f < matriz.GetLength(1); f++)
    {
        Console.Write(matriz[i,f] + "\t");
    }
    Console.WriteLine();

}