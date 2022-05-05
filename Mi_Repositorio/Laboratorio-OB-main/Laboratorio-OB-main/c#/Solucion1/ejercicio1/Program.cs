using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace consola01
{
internal class Program
{
static void Main(string[] args)
{
// instanciacion de la clase
persona objPersona = new persona();
// carga de informacion
Console.WriteLine(&quot;Ingrese el nombre&quot;);
objPersona.nombre = Console.ReadLine();
Console.WriteLine(&quot;Ingrese el apellido&quot;);
objPersona.apellido = Console.ReadLine();
Console.WriteLine(&quot;Ingrese la edad&quot;);
objPersona.edad = Convert.ToInt32( Console.ReadLine() );
Console.WriteLine(&quot;Ingrese la altura&quot;);
objPersona.altura = Convert.ToInt32(Console.ReadLine());
// salida de informacion
objPersona.saludar();
objPersona.mostrarDatos();
}

public class persona {
// constructor
public persona() {
}
// atributos
public string nombre;
public string apellido;
public int edad;
public int altura;
// metodos
public void saludar() {
Console.WriteLine(&quot;Buenos días&quot;);
}
public void mostrarDatos() {
Console.WriteLine(&quot;El sr/a {0} {1} tiene {2} años y mide {3}cm&quot;, nombre, apellido,edad,altura);
}
}
}
}