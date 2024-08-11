/*Crear una matriz de 10 x 10, y “esconder” varias ‘X’ en lugares aleatorios (la cantidad que el programador decida, pero no más de la mitad de los lugares disponibles en la matriz). 
 * El usuario deberá ingresar el lugar donde cree que hay una X, ingresando la fila y la columna por separado.
 * Informar si acertó o no por cada ingreso. Se debe pedir al usuario ingresar valores por tantas X que se haya guardado. 
 * El usuario tiene 3 intentos para fallar. Al finalizar (Ya sea porque se terminaron los 3 intentos,
 * o el jugador acertó todas las X) imprimir por pantalla la matriz con sus correspondientes X, mostrando un * donde no haya nada.
 */
string[,] matriz = new string[10, 10];
int cont = 0;
bool verificacion1= false;
bool verificacion2 = false;
while (true)
{

    Console.Write("Ingrese la posicion X: ");
    verificacion1   = int.TryParse(Console.ReadLine(), out int X);

    Console.Write("Ingrese la posicion Y: ");
    verificacion2 =int.TryParse(Console.ReadLine(), out int Y);

    if (verificacion1 == false || verificacion2 == false)
    {
        Console.WriteLine("--Debe ingresar un numeros--");
        continue;
    }

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
            matriz[i, j] = "-";

            matriz[8, 4] = "X";
            matriz[2, 4] = "X";
            matriz[7, 3] = "X";
            matriz[1, 1] = "X";
            matriz[2, 5] = "X";
            matriz[4, 4]= "X";
            matriz[5, 6] = "X";
            matriz[1, 4] = "X";
        }

    }

    for (int i = 0; i < matriz.GetLength(0); i++)
    {
        for (int j = 0; j < matriz.GetLength(1); j++)
        {
             if (string.Equals(matriz[X, Y],"X"))
            {
                Console.WriteLine("X encontada!");
                cont=1;
                break;
            }
        }
        if (cont == 1) break;
    }
    if (cont == 1) break;
    else Console.WriteLine("VUELVE A INTENTARLO");
}


for (int i = 0;  i < matriz.GetLength(0); i++)
{
      for (int j = 0;j < matriz.GetLength(1); j++)
    {
        Console.Write(matriz[i, j] + "\t");
    }
      Console.WriteLine();
}
