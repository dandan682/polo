﻿using System;
namespace Clase16.Modelo
{
	public class Empleado: Persona
	{
        private int _salarioBruto;

        public string Ocupacion { get; set; }

        public string Empresa { get; set; }

        public string ObraSocial { get; set; }

        public int SalarioBruto
        {
            set => _salarioBruto = value;
        }

        public int SalarioNeto { get => ObtenerSalarioNeto(); }

        public int ObtenerSalarioNeto()
        {
            var salarioNeto = _salarioBruto * 0.85;
            return (int)salarioNeto;
        }
    }
}

