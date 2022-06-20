using CursoLINQ;
using CursoLINQ.Modulo_2;

/*
Sección 3: Ordenando Elementos
Function OrderBy
*/


var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
    new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
    new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
    new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
    new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
    };

var ordenarPorEdad = personas.OrderBy(p => p.Edad);

var ordenarPorEdad2 = from p in personas orderby p.Edad select p;

int[] numeros = { 4, 5, 1, 0, 44, 2 };

foreach(var numero in numeros.OrderBy(x => x))
{
    Console.WriteLine(numero);
}
