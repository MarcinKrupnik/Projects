using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MarcinKrupnikLab3Zadanie.Repositories
{
	internal interface IClothesMagazineGeneric<T> where T : class
	{
		List<T> GetAll();

		IQueryable<T> Get();

		T GetById(int Id);

		void DeleteById(int Id);

		void Update(T entity);

		void Create(T entity);

		void Save();
	}
}
