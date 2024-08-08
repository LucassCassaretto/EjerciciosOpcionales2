// See https://aka.ms/new-console-template for more information


//Dado que se tiene almacenado en una lista, los resultados de los últimos 10 exámenes de un alumno,
//calcular su promedio y mostrar por pantalla las 10 notas de los exámenes y el promedio resultante.


List<int> notas = new List<int>();

    notas.Add(7);
    notas.Add(10);
    notas.Add(9);
    notas.Add(10);
    notas.Add(10);
    notas.Add(8);
    notas.Add(4);
    notas.Add(5);
    notas.Add(4);
    notas.Add(4);

double suma = 0;
int cont = 0;

foreach (int i in notas)
{   
    cont++;
   Console.WriteLine("Nota del parcial: "+cont + " es: " +i);
    suma += i;
}

double cantidadDeNotas = notas.Count;

double promedio = suma / cantidadDeNotas ;

Console.WriteLine("La nota promedio de todas las notas es : " + promedio );
