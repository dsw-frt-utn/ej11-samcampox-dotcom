namespace Dsw2026Ej11.Tests;

using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;

internal class Ejemplos
{
  
        //Agregar 3 alumnos a la list
        //Listar por consola los alumnos
        //Buscar por nombre un alumno que exista y mostrar por consola
        //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
        //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList lista = new CasoList();

        lista.Agregar(new Alumno(1, "Ana García", 8.5));
        lista.Agregar(new Alumno(2, "Luis Martínez", 7.0));
        lista.Agregar(new Alumno(3, "Sofía López", 9.2));

        Console.WriteLine("=== Lista de alumnos ===");
        foreach (Alumno a in lista.ObtenerTodos())
            Console.WriteLine(a);

        Alumno? encontrado = lista.BuscarPorNombre("Luis Martínez");
        Console.WriteLine($"\nBúsqueda 'Luis Martínez': {encontrado}");

        Alumno? noExiste = lista.BuscarPorNombre("Carlos Pérez");
        Console.WriteLine($"Búsqueda 'Carlos Pérez': {(noExiste != null ? noExiste.ToString() : "No existe")}");

        lista.Eliminar(encontrado!);
        Console.WriteLine("\n=== Tras eliminar a Luis Martínez ===");
        foreach (Alumno a in lista.ObtenerTodos())
            Console.WriteLine(a);

        lista.EliminarEnPosicion(0);
        Console.WriteLine("\n=== Tras eliminar el primero ===");
        foreach (Alumno a in lista.ObtenerTodos())
            Console.WriteLine(a);

    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dic = new CasoDictionary();

        dic.Agregar(new Alumno(1, "Ana García", 8.5));
        dic.Agregar(new Alumno(2, "Luis Martínez", 7.0));
        dic.Agregar(new Alumno(3, "Sofía López", 9.2));

       
        Console.WriteLine("=== Diccionario de alumnos ===");
        foreach (KeyValuePair<int, Alumno> par in dic.ObtenerTodos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");

       
        Alumno? encontrado = dic.Buscar(2);
        Console.WriteLine($"\nBúsqueda legajo 2: {encontrado}");

        Alumno? noExiste = dic.Buscar(999);
        Console.WriteLine($"Búsqueda legajo 999: {(noExiste != null ? noExiste.ToString() : "No existe")}");

        
        dic.Eliminar(1);
        Console.WriteLine("\n=== Tras eliminar legajo 1 ===");
        foreach (KeyValuePair<int, Alumno> par in dic.ObtenerTodos())
            Console.WriteLine($"Legajo {par.Key}: {par.Value}");

    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine($"Primero: {linq.GetPrimero()}");
        Console.WriteLine($"Último: {linq.GetUltimo()}");
        Console.WriteLine($"Total precios: {linq.GetTotalPrecios():C}");
        Console.WriteLine($"Promedio precios: {linq.GetPromedioPrecios():C}");

        Console.WriteLine("\n=== Libros con Id mayor a 15 ===");
        foreach (Libro l in linq.GetListById())
            Console.WriteLine(l.Titulo);

        Console.WriteLine("\n=== Títulos y precios ===");
        foreach (string s in linq.GetLibro())
            Console.WriteLine(s);

        Console.WriteLine($"\nMayor precio: {linq.GetMayorPrecio()}");
        Console.WriteLine($"Menor precio: {linq.GetMenorPrecio()}");

        Console.WriteLine("\n=== Libros sobre el promedio ===");
        foreach (Libro l in linq.GetMayorPromedio())
            Console.WriteLine(l.Titulo);

        Console.WriteLine("\n=== Ordenados por título descendente ===");
        foreach (Libro l in linq.GetOrdenadosPorTitulo())
            Console.WriteLine(l.Titulo);
    }

}
