//Dada las edades de 20 personas guardadas en una lista, imprimir por pantalla cuántos son mayores de edad y cuántos no.


List<int> personasEdades = new List<int> { 15, 17, 20, 14, 25, 18, 19, 16, 21, 23, 22, 30, 13, 29, 24, 27, 28, 26, 32, 12 };

int mayor = 0;
int menor = 0;

foreach (int a in personasEdades)
{
    if (a >= 18) mayor++;
    else menor++;
}

Console.WriteLine("La cantidad de personas mayores es de: " +  mayor);
Console.WriteLine("La cantidad de personas menores es de: " +  menor);