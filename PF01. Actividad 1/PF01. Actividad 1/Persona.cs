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
}
