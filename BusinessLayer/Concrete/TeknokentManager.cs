using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class TeknokentManager : ITeknokentService
    {

      
        private readonly ITeknokentDal _teknokentDal;  //Bu sefer dal daki generic yapıda tanımladığımız metotlarımıza erişmemiz lazım bunun için dalı burada olamsı lazım. bu yontemle

        public TeknokentManager(ITeknokentDal teknokentDal)
        {
            _teknokentDal = teknokentDal;
        }

        public void TDelete(Teknokent t)
        {
            _teknokentDal.Delete(t);
        }

        public Teknokent TGetByID(int id)
        {
           return _teknokentDal.GetByID(id);
        }

        public List<Teknokent> TGetList()
        {
            return _teknokentDal.GetAll();
        }

        public void TInsert(Teknokent t)
        {
            _teknokentDal.Insert(t);
        }

        public void TUpdate(Teknokent t)
        {
            _teknokentDal.Update(t);
        }
    }
}
