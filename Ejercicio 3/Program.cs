//Dado una lista de nombres de estudiantes, imprimir el que tenga más letras, y el que tenga menos letras de todos.

using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Schema;

List<string> names = new List<string> { "Zoe", "Luis", "Josefina", "Carlos", "Elena" };

string mayor = names.OrderByDescending(name => name.Length).FirstOrDefault();
string menor = names.OrderBy(name => name.Length).FirstOrDefault();

Console.WriteLine(mayor);
Console.WriteLine(menor);   

