/* Se tiene una matriz de 5x7, donde 5 representa la semana de un mes y 7 los días de la semana.
 * La estructura es para registrar la temperatura diaria de una cabina de pago, estos oscilan entre los 7 y 38 grados.
 * Deberá llenar la matriz de forma aleatoria para el mes de mayo donde el primer día inicia en lunes y el último (31) se ubica en el miércoles
 * (la matriz puede ser inicializada con valores aleatorios desde el principio del programa, no es necesario pedir los valores al usuario para cada posición). 
 * Se nos pide hacer lo siguiente:
 * Obtener la temperatura más alta y baja de la semana y que día se produjo (lunes, martes, etc.)
 * Promedio de temperatura de la semana.
 * Temperatura más alta del mes y su día.
*/


using System.Runtime.CompilerServices;

int[,] calendario = new int [5,7];
int[] vec1 = new int[7];
int[] vec2 = new int[7];
int[] vec3 = new int[7];
int[] vec4 = new int[7];
int[] vec5 = new int[7];
int cont = 0;


for (int i = 0; i < calendario.GetLength(0); i++)
{
    /// i es igual a semanas
   

    for (int j = 0; j < calendario.GetLength(1); j++)
        ///j es igual a dias 
    {
        cont++;
        if (cont <= 31)
        {
            Random clima = new Random();
            int temp = clima.Next(7, 38);

            calendario[i, j] = temp;
        }
        else calendario[i, j] = 0;
        if (i == 0)
        {
            vec1[j] = calendario[i, j];
        }
        if (i == 1)
        {
            vec2[j] = calendario[i, j];
        }
        if (i == 2)
        {
            vec3[j] = calendario[i, j];
        }
        if (i == 3)
        {
            vec4[j] = calendario[i, j];
        }
        if (i == 4)
        {
            if (calendario[i,j] != 0)
            {
                vec5[j] = calendario[i, j];
            }
        }

    }
}


int valorMaximo = 0;
string diaMaximoCalor = "";
int cont2= 0;
int MaximoCalor = 0;
for (int i = 0; i < calendario.GetLength(0); i++)
{
    //int semana = i + 1;
    //Console.WriteLine("semana: " + semana);

    for (int j = 0; j< calendario.GetLength(1); j++)
    {
        cont2++;
        int d = j + 1;
        if (i == 0 && j == 0)
        {
             valorMaximo = calendario[i, j];
              diaMaximoCalor=dia(d);
            MaximoCalor = cont2;
        } else if (valorMaximo <= calendario[i,j])
        {
            valorMaximo = calendario[i, j];
            diaMaximoCalor = dia(d);
            MaximoCalor = cont2;
        }


        Console.Write(calendario[i, j]+ "\t");
    }
    Console.WriteLine();
}



temperaturaSemana(vec1, 1);
temperaturaSemana(vec2, 2);
temperaturaSemana(vec3, 3);
temperaturaSemana(vec4, 4);
temperaturaSemana(vec5, 5);


Console.WriteLine("La temperatura mas alta durante todo el mes es de "+ valorMaximo +" grados el dia " +diaMaximoCalor+ MaximoCalor );    



static void temperaturaSemana(int[] vec, int semana)
{
    int[] vec1 = vec.Where(x => x != 0).ToArray();

    int maximo = vec1.Max();
    string indiceMaximo = dia(Array.IndexOf(vec1, maximo) + 1);
    int minimo = vec1.Min();
    string indiceMinimo = dia(Array.IndexOf(vec1, minimo) + 1);
  
    Console.WriteLine();
    Console.WriteLine("La temperatura mas alta de la semana "+semana+" es: " + maximo + " y se encuentra en el dia " + indiceMaximo);
    Console.WriteLine("La temperatura mas baja de la semana "+semana+" es: " + minimo + " y se encuentra en el dia " + indiceMinimo);
   

    int suma=0;

    foreach(int i in vec1)
    {
        suma += i;
    }
    double promedio = suma/ vec1.Length;

    Console.WriteLine("El primedio de temperatura de la semana "+ semana+ " es de : "+ promedio+ " grados");
    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
}

static string dia(int dia)
{
    switch (dia)
    {
        case 1 : return ("Lunes ");
        case 2 : return ("Martes ");
        case 3: return ("Miercoles ");
        case 4: return ("Jueves ");
         case 5:return ("Viernes ");
        case 6:return ("sabado "); 
        case 7:return("Domingo ");
        default: return "Día inválido ";
    }

}