/*  Almacenar en una matriz las tablas del 1 al 9, teniendo en cuenta que en la primera fila y la primera columna se debe guardar los números (de 0 a 9),
  estando el cero en la primera posición (fila 0, columna 0). 
  El resto de los lugares debe ser calculado usando los números que se dispone, por ejemplo, en la fila 1, calcular 1*1, 1*2, 1*3, etc.
  usando las posiciones del array o arreglo. Al finalizar el cálculo, mostrar la matriz por pantalla
*/



int[,] tablas = new int [10,11];
int calculo=0;

for (int i = 0; i< tablas.GetLength(0); i++)
{
    for (int j = 0; j < tablas.GetLength(1); j++)
    {
        if (i == 0 && j == 0) tablas[i, j] = 0;
        else if (i == 0)
        {
            tablas[i, j] = j;
        }
    }
  
        tablas[i, 0] = i;
   
}


for (int i = 1; i < tablas.GetLength(0); i++)
{
    for (int j = 1; j < tablas.GetLength(1); j++)
    {
        calculo = calcularTablas(tablas, j, i);

        tablas[i, j] = calculo;
    }

    tablas[i, 0] = i;

}




for (int i = 0; i < tablas.GetLength(0); i++)
{
    for (int j = 0; j < tablas.GetLength(1); j++)
    {
        Console.Write(tablas[i, j] + "\t");
    }
    Console.WriteLine();
}



static int calcularTablas(int[,] vec, int j, int i)
{
    int fila = vec[i,0];
    int columna = vec[0,j];

    int multiplicacion= fila * columna;

    return multiplicacion;
}