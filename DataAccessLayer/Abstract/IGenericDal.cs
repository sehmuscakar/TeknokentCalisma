using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class // T generic bir entity olacak ve class olma şartı sağladık.
    {
        void Insert(T t);// bunu eklemede 
        void Delete(T t);//bunu silmede
        void Update(T t);//bunu günceleme
        List<T> GetAll();// bunu listelemede

        T GetByID (int id);// bunuda idimzi tutmak için kullanacaz.


    }
}
