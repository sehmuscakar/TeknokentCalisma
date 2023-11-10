using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Entities
{
    public class Teknokent
    {
        // teknkentlerin bulunduğu şehir ,isim , bulunan oda sayısı, ilgili teknokente bulunan şirket sayısı verilerini veren program yazıyoruz.
        public int ID { get; set; }//id 
        public string Name { get; set; }//isim
        public string City { get; set; }//bulunduğu şehir
        public int Room { get; set; }//oda sayısı
        public int CompanyCount { get; set; }//şirket sayısı
    }
}
