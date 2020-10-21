using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using MarcinKrupnikLab7Zadanie.Models;

namespace MarcinKrupnikLab7Zadanie.Repositories
{
    internal class ApplicationDbGeneric<T> : IApplicationDbGeneric<T> where T : class
    {
        private readonly AppDbContext _context;
        public ApplicationDbGeneric()
        {
            _context = new AppDbContext();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Create(T entity)
        {
            _context.Set<T>().Add(entity);//TODO spr
        }


    }
}