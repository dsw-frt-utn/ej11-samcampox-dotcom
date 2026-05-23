using Dsw2026Ej11.Domain; 
namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary
{
    private Dictionary<int, Alumno> _alumnos = new Dictionary<int, Alumno>();
    public void Agregar(Alumno alumno)
    {
        //_alumnos[alumno.Id] = alumno;
        _alumnos.Add(alumno.Id, alumno);
    }
    public Alumno? Buscar(int legajo)
    {
        if (_alumnos.ContainsKey(legajo))
            return _alumnos[legajo];
        return null;
    }
    public Dictionary<int, Alumno> ObtenerTodos()
    {
        return _alumnos;
    }
    public void Eliminar (int legajo)
    {
        _alumnos.Remove(legajo);
    }
}

