using CursoLINQ;
using CursoLINQ.Modulo_2;

var personas = new List<Persona>() {
    new Persona { Nombre = "Eduardo", EmpresaId = 1, },
    new Persona { Nombre = "Nidia",  EmpresaId = 1 },
    new Persona { Nombre = "Alejandro", EmpresaId = 3 },
    new Persona { Nombre = "Valentina",  EmpresaId = 2 },
    new Persona { Nombre = "Roberto",  EmpresaId = 3 },
    new Persona { Nombre = "Eugenia"},
    new Persona { Nombre = "Esmerlin", EmpresaId = 3 }
};

var empresas = new List<Empresa>(){
    new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
    new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
    new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
};

var a = 1;