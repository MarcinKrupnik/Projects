using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MarcinKrupnikLab3Zadanie.Models;

namespace MarcinKrupnikLab3Zadanie.Repositories
{
	internal class ClothesMagazineGeneric<T> : IClothesMagazineGeneric<T> where T : class
	{
		private readonly ClothesMagazineContext _context;

		public ClothesMagazineGeneric()
		{
			_context = new ClothesMagazineContext();
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="entity"></param>
		public void Create(T entity)
		{
			_context.Set<T>().Add(entity);//TODO spr
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="Id"></param>
		public void DeleteById(int Id)
		{
			T entities = _context.Set<T>().Find(Id);
			_context.Set<T>().Remove(entities);//TODO Sprawdz

		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public IQueryable<T> Get()
		{
			return _context.Set<T>().AsQueryable();
		}

		/// <summary>
		///
		/// </summary>
		/// <returns></returns>
		public List<T> GetAll()
		{
			return _context.Set<T>().ToList();
		}

		/// <summary>
		///
		/// </summary>
		/// <param name="Id"></param>
		/// <returns></returns>
		public T GetById(int Id)
		{
			return _context.Set<T>().Find(Id);
		}

		/// <summary>
		///
		/// </summary>
		public void Save()
		{
			_context.SaveChanges();
		}

		public void Update(T entity)
		{
			_context.Entry(entity).CurrentValues.SetValues(entity);
		}
	}
}
