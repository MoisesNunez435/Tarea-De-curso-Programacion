using System;
using System.Collections.Generic;
using System.Text;

namespace Infraestructure
{
	public interface Imodel<T>
	{
		void Create(T t);
		void Delete(T t);
		void Update(T t);
		List<T> Read();
	}
}
