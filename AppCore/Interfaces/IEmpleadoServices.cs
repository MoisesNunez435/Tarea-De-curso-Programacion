using Domaain;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore
{
	public interface IEmpleadoServices: IServices<Empleado>
	{
		Empleado GetEmpleadoById(int id);
	}
}
