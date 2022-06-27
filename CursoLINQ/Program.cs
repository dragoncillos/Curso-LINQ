
using CursoLINQ.Modulo_12;

// Podemos empezar a trabajar en la clase program.cs agregando dos personas de ejemplo a la bbdd
//using (var context = new ApplicationDbContext())
//{
//    // No incluimos el Id pq lo agregará la bbdd de forma automática
//    var persona1 = new Persona() {Nombre = "Felipe" };
//    var persona2 = new Persona() {Nombre = "Claudia" };

//    context.AddRange(persona1, persona2);
//    context.SaveChanges();
//}

// Instanciar DbContext para consultar en la bbdd las personas creadas en la tabla Personas
using (var context = new ApplicationDbContext())
{
    var personas = context.Personas.ToList();
    var personasNombre = context.Personas.Select(p => p.Nombre).ToList();

    // Sintaxis de métodos (lambda)
    // Usando filtros en la tabla, estas dos consultas dan el mismo resultado
    // La diferencia es que el where si no encuentra a Felipe da 0 y el FirstOrDefault null
    var felipe = context.Personas.Where(p => p.Nombre == "Felipe").ToList();
    var felipe2 = context.Personas.FirstOrDefault(p => p.Nombre == "Felipe");

    // Sintaxis de queries
    var felipeQ = (from p in context.Personas select p).ToList();
    var felipe2Q = (from p in context.Personas
                    where p.Nombre == "Felipe"
                    select p).FirstOrDefault();
    // Las sentencias LINQ el EF las traduce a la correspondiente consulta SQL,
    // ojo porque no todas son traducibles en cuyo caso dan error. Por ejemplo esta daría error:
    // (la única forma de hacerlo es bajar todos los registros de la tabla al cliente = algo ineficiente si hay miles)
    //var segmentos = context.Personas.Chunk(1).ToList();
}

Console.WriteLine("Hola Mundo");