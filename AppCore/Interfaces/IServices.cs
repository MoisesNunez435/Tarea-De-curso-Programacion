using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore
{
	public interface IServices<T>
	{
		void Create(T t);
		void Delete(T t);
		void Update(T t);
		List<T> Read();
	}
}
