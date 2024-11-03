using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelTakip
{
    public static class ListBoxExtension
    {
        public static void VeriBagla(this ListBox lb, List<Personel>liste, string valueMember, string DisplayMember)
        {
            lb.DataSource = null;
            //Datasource liste kutusunda veri bağlamak için kullanılır
            lb.DataSource = DosyaYardimcisi.PersonelleriGetir();
            lb.DisplayMember = "AdSoyad";
            lb.ValueMember = "Id";
        }
    }
}
