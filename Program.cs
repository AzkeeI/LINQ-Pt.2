// // See https://aka.ms/new-console-template for more information
// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//     new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//     new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//     new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
//     new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };


// var personasOrdenadasPorEdad = personas.OrderBy(x => x.Edad).ThenByDescending(x => x.Nombre);

// foreach (var persona in personasOrdenadasPorEdad)
// {
//     Console.WriteLine($"{persona.Nombre} tiene {persona.Edad} años de edad");
// }

// // Sintaxis de queries
// var personasOrdenadasPorEdad_2 = from p in personas
//                                 orderby p.Edad, p.Nombre descending
//                                 select p;



//------------------------------------------------------------------------------------VIDEO 13 -----------------------------------------------\\

// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Edad = 30, FechaIngresoALaEmpresa = new DateTime(2021, 1, 2), Soltero = true },
//     new Persona { Nombre = "Nidia", Edad = 19, FechaIngresoALaEmpresa = new DateTime(2015, 11, 22), Soltero = true },
//     new Persona { Nombre = "Alejandro", Edad = 45, FechaIngresoALaEmpresa = new DateTime(2020, 4, 12), Soltero = false },
//     new Persona { Nombre = "Valentina", Edad = 24, FechaIngresoALaEmpresa = new DateTime(2021, 7, 8), Soltero = false },
//     new Persona { Nombre = "Roberto", Edad = 61, FechaIngresoALaEmpresa = DateTime.Now.AddDays(-1), Soltero = false },
// };

// var nombres = personas.Select(p => p.Nombre).ToList();
// var nombresYEdades = personas.Select(p => new { Nombre = p.Nombre, Edad = p.Edad }).ToList();
// var personasDTOs = personas.Select(p => new PersonaDTO { Nombre = p.Nombre, Edad = p.Edad }).ToList();
// var numeros = Enumerable.Range(1, 5).ToList();
// var numerosDuplicados = numeros.Select(n => 2 * n).ToList();
// var personasConIndice = personas.Select((p, indice) => new { Persona = p, Indice = indice + 1 }).ToList();
// foreach (var item in personasConIndice)
// {
//     Console.WriteLine($"{item.Indice}) {item.Persona.Nombre}");
// }


// // Sintaxis de queries
// var nombres_2 = (from p in personas
//                  select p.Nombre).ToList();
// var nombresYEdades_2 = from p in personas
//                        select new { Nombre = p.Nombre, Edad = p.Edad };
// var numerosDuplicados_2 = from n in numeros
//                           select 2 * n;
// // No podemos hacer el ejemplo del índice con sintaxis de queries


//-----------------------------------------------------------------------------------------VIDEO 14-------------------------------------------------------------------------\\



// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Soltero = true },
//     new Persona { Nombre= "Nidia", Soltero = true },
//     new Persona { Nombre= "Alejandro", Soltero = true },
//     new Persona { Nombre = "Valentina", Soltero = false }
// };

// Console.WriteLine($"La cantidad de personas es {personas.Count()}");
// Console.WriteLine($"La cantidad de personas solteras es {personas.Count(p => p.Soltero)}");
// Console.WriteLine($"Int max = {int.MaxValue.ToString("N")}");

// //personas.LongCount();

// // Sintaxis de queries

// var conteoSolteros = (from p in personas
//                         where p.Soltero
//                         select p).Count();





// //-----------------------------------------------------------------------------------------VIDEO 15-------------------------------------------------------------------------\\



// using LINQpt2;



// var personas = new List<Persona>() {
// new Persona { Nombre = "Eduardo", Edad = 19, },
// new Persona { Nombre = "Nidia", Edad = 25 },
// new Persona { Nombre= "Alejandro", Edad = 30 },
// new Persona { Nombre = "Valentina", Edad = 22 }
// };
// var numeros = Enumerable.Range(1, 5);
// Console.WriteLine($"La suma de los numeros es {numeros.Sum()}");
// Console.WriteLine($"La suma de las edades es {personas.Sum(p => p.Edad)}");
// Console.WriteLine($"La edad máxima de las personas es {personas.Max(x => x.Edad)}");
// Console.WriteLine($"La edad mínima de las personas es {personas.Min(x => x.Edad)}");


//-----------------------------------------------------------------------------------------VIDEO 19-------------------------------------------------------------------------\\



// using LINQpt2;

// var numeros = Enumerable.Range(1, 5);

// var resultado = numeros.Aggregate((a, b) => a * b); // 1x2x3x4x5

// Console.WriteLine("resultado es: " + resultado);

// var resultadoConValorInicial = numeros.Aggregate(10, (a, b) => a * b);

// Console.WriteLine("El resultado con el valor semilla es: " + resultadoConValorInicial);

//-----------------------------------------------------------------------------------------VIDEO 21-------------------------------------------------------------------------\\



// using LINQpt2;


// var numeros = Enumerable.Range(1, 5);

// var estaElNumero3 = numeros.Contains(3);

// var estaElNumero20 = numeros.Contains(20);

// var a = 2;

//-----------------------------------------------------------------------------------------VIDEO 22-------------------------------------------------------------------------\\



// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Edad = 19, Soltero = true },
//     new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
//     new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
//     new Persona { Nombre = "Valentina", Edad = 22, Soltero = false }
// };
// var existeMenor = personas.Any(p => p.Edad < 18);
// var existeMayorDe20 = personas.Any(p => p.Edad > 20);
// var a = 2;


//-----------------------------------------------------------------------------------------VIDEO 27-------------------------------------------------------------------------\\



// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Edad = 19, Soltero= true },
//     new Persona { Nombre= "Nidia", Edad = 25, Soltero = true },
//     new Persona { Nombre= "Alejandro", Edad = 30, Soltero = true },
//     new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
//     new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
//     new Persona { Nombre= "Eugenia", Edad = 27, Soltero = false },
//     new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
// };


// var agrupamientoPorSolteria = personas.GroupBy(p => p.Soltero);
// foreach (var grupo in agrupamientoPorSolteria)
// {
//     Console.WriteLine($"Grupo de las personas donde Soltero = {grupo.Key} (Total: {grupo.Count()})");
//     foreach (var persona in grupo)
//     {
//         Console.WriteLine($"- {persona.Nombre}");
//     }
// }

// // sintaxis de queries
// var agrupamientoPorSoltera_2 = from p in personas
//                                 group p by p.Soltero into grupos
//                                 select grupos;






// //-----------------------------------------------------------------------------------------VIDEO 28-------------------------------------------------------------------------\\



// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Edad = 19, Soltero= true },
//     new Persona { Nombre = "Nidia", Edad = 25, Soltero = true },
//     new Persona { Nombre = "Alejandro", Edad = 30, Soltero = true },
//     new Persona { Nombre = "Valentina", Edad = 17, Soltero = false },
//     new Persona { Nombre = "Roberto", Edad = 18, Soltero = true },
//     new Persona { Nombre = "Eugenia", Edad = 27, Soltero = false },
//     new Persona { Nombre = "Esmerlin", Edad = 45, Soltero = false }
// };
// var agrupamientoPorRangoEdad = personas.GroupBy(p => p.Edad / 5);
// foreach (var item in agrupamientoPorRangoEdad)
// {
//     Console.WriteLine($"Grupo de las personas en el rango de edad {item.Key * 5} - {(item.Key * 5 + 5 - 1)}");
//     foreach (var persona in item)
//     {
//         Console.WriteLine($"- {persona.Nombre} (edad: {persona.Edad})");
//     }
// }

// // Sintaxis de queries
// var agrupamientoPorRangoEdad_2 = from p in personas
// group p by p.Edad / 5 into grupos
// select grupos;






//-----------------------------------------------------------------------------------------VIDEO 29-------------------------------------------------------------------------\\



// using LINQpt2;


// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Empresald = 1, },
//     new Persona { Nombre= "Nidia", Empresald = 1 },
//     new Persona { Nombre = "Alejandro", Empresald = 3 },
//     new Persona { Nombre= "Valentina", Empresald = 2 },
//     new Persona { Nombre = "Roberto", Empresald = 3 },
//     new Persona { Nombre= "Eugenia"},
//     new Persona { Nombre = "Esmerlin", Empresald = 3 }
// };
// var empresas = new List<Empresa>()
// {
//     new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
//     new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
//     new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"}
// };
// var personasYEmpresas = personas.Join (empresas, p => p. Empresald, e => e.Id, (persona, empresa) => new
// {
//     Persona = persona,
//     Empresa = empresa
// });

// foreach (var item in personasYEmpresas)
// {
//     Console.WriteLine($"{item.Persona.Nombre} trabaja en {item.Empresa.Nombre}");
// }

// // Sintaxis de queries
// var personasYEmpresas_2 = from persona in personas
//                          join empresa in empresas on persona.Empresald equals empresa.Id
//                          select new
//                          {
//                              Persona = persona,
//                              Empresa = empresa
//                          };




//-----------------------------------------------------------------------------------------VIDEO 30-------------------------------------------------------------------------\\


// using LINQpt2;


// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Empresald = 1, },
//     new Persona { Nombre= "Nidia", Empresald = 1 },
//     new Persona { Nombre = "Alejandro", Empresald = 3 },
//     new Persona { Nombre= "Valentina", Empresald = 2 },
//     new Persona { Nombre = "Roberto", Empresald = 3 },
//     new Persona { Nombre= "Eugenia"},
//     new Persona { Nombre = "Esmerlin", Empresald = 3 }
// };

// var empresas = new List<Empresa>()
// {
//     new Empresa{Id = 1, Nombre = "Electrodomésticos Felipe"},
//     new Empresa{Id = 2, Nombre = "Bicicletas Valentina"},
//     new Empresa{Id = 3, Nombre = "Gimnasio Esmerlin"},
//     new Empresa{Id = 4, Nombre = "Ferreteria Lorenzo"}
// };

// var empresasYSusEmpleados = empresas.GroupJoin(personas, e => e.Id, p => p.Empresald,
// (empresa, personas) => new { Empresa = empresa, Personas = personas });

// foreach (var item in empresasYSusEmpleados)
// {
//     Console.WriteLine($"Las siguientes personas trabajan en {item.Empresa.Nombre}");
//     foreach (var persona in item.Personas)
//     {
//         Console.WriteLine($"- {persona.Nombre}");
//     }
// }


// //-----------------------------------------------------------------------------------------VIDEO 31-------------------------------------------------------------------------\\


// using LINQpt2;

// var personas = new List<Persona>() {
//     new Persona { Nombre = "Eduardo", Empresald = 1, },
//     new Persona { Nombre = "Nidia", Empresald = 1 },
//     new Persona { Nombre = "Eduardo"},
//     new Persona { Nombre = "Esmerlin", Empresald = 3 }
// };
// int[] numeros = {1, 2, 3, 1, 1, 6};
// var numerosSinRepeticiones = numeros.Distinct();
// var personasSinNombresRepetidos = personas.DistinctBy(x => x.Nombre);
// // Sintaxis de queries
// var numerosSinRepeticiones_2 = from n in numeros.Distinct()
//     select n;
// var personasSinNombresRepetidos_2 = from p in personas.DistinctBy(x => x.Nombre)
//     select p;
// var a = 3;


//-----------------------------------------------------------------------------------------VIDEO 32-------------------------------------------------------------------------\\


using LINQpt2;

// var personasA = new List<Persona>() {
// new Persona { Nombre = "Eduardo", Empresald = 1, },
// new Persona { Nombre = "Nidia", Empresald = 1 },
// new Persona { Nombre = "Esmerlin", Empresald = 3 }
// };

// var personasB = new List<Persona>()
// {
// new Persona{Nombre = "Fernando", Edad = 25},
// new Persona { Nombre = "Eduardo", Empresald = 1, },
// };

// int[] numerosA = {1, 2, 3, 1, 1, 6};

// int[] numerosB={1, 2, 15 };

// var unionNumeros = numerosA.Union(numerosB);

// var unionPersonas = personasA.UnionBy(personasB, p => p.Nombre);
// var a = 4;


//-----------------------------------------------------------------------------------------VIDEO 35-------------------------------------------------------------------------\\


using LINQpt2;

int[] A = { 1, 2, 3 };

int[] B = { 4, 5, 6 };

var resultado = A.Concat(B);

var a = 4;