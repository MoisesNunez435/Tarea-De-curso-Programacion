using Domaain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
	public class EmpleadoModel : IEmpleadoModel
	{
		private List<Empleado> Empleados = new List<Empleado>();
		public void Create(Empleado t)
		{
			if (Empleados == null)
			{
				Empleados.Add(t);
			}
			Empleados.Add(t);
		}

		public void Delete(Empleado t)
		{
			Empleados.Remove(t);
		}

		public Empleado GetEmpleadoById(int id)
		{
			return Empleados.Find(x => x.Id == id);
		}

		public List<Empleado> Read()
		{
			return Empleados;
		}

		public void Update(Empleado t)
		{
			int Indice= Empleados.FindIndex(p => p.Id == t.Id);
			Empleados.Insert(Indice, t);
		}
	}
}
