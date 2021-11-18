using Domaain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
	public interface IEmpleadoModel:Imodel<Empleado>
	{
		Empleado GetEmpleadoById(int id);
	}
}
