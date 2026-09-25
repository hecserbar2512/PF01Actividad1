using System;

public class Persona
{
	private string _nombre;
	private int _edad;
	private bool _estadoCivil;

	public Persona(string nombre, int edad, bool estadoCivil)
	{
		_nombre = nombre;
		_edad = edad;
		_estadoCivil = estadoCivil;
	}

	public Nombre{
        get { return _nombre; }
        set { _nombre = value; }
    }

	public string MostrarDatos()
	{
		string datos = $"Nombre: {_nombre} \n Edad: {_edad} Estado civil: ";

		if (EstadoCivil())
		{
			datos += "Casado";

		}
		else
		{
			datos += "Soltero";
		}
		return datos;
	}
	public bool EstadoCivil()
    {
		if (_estadoCivil)
		{
			return true
		}
		return false
    }
}
