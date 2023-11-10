using DataAccessLayer.Abstract;
using DataAccessLayer.Context;
using DataAccessLayer.Entities;

namespace DataAccessLayer.Repositories
{
    public class TeknokentDal : GenericRepository<Teknokent>, ITeknokentDal
    {
        //veritabanına erişmesi lazım bu yuzden Constructor (Yapıcı Metod) uyguladık
        //ctrl + nokta yparak ilgili yerde yani TeknokentDal yazan yerde yapıcı fonsiyon yapma yeri gelir.
        public TeknokentDal(ProjeContext context) : base(context)
        {

        }
    }
}
