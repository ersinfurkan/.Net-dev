using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÜniversiteIK
{
    public interface IOgrenciDersSınıfı
    {
        public int Dersno { get; set; }
        public int OgrenciNo { get; set; }
        public void OgrenciDersEkle();
        public void OgrenciDersSil();
        
    }
}
