using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class //entityframework hazır metotlarını burda kullanacaz 
    {
        private readonly ProjeContext _context;// Constructor(Yapıcı Metod) uyguladık

        public GenericRepository(ProjeContext context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
           return _context.Set<T>().ToList();
           
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);//find:bulmak idyi buluyor yani
        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}
