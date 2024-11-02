using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    public class Personel
    {
        public string AdSoyad { get; set; }
        public string CalistigiBirim {  get; set; }
        public int Cinsiyet {  get; set; } // enum
        public int Turu {  get; set; }
        public int CalismaGunleri { get; set; } // birden fazla seçenek olduğu için Flag olarak saklanacak
        public int SaglikSigortasi { get; set; } // sadece iki farklı seçenek olduğu için Enum olarak saklanacak 
    }
}
