using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    internal class KetQuaThi
    {
        public String HoTen { get; set; }
        public String LinhVuc { get; set; }
        public String DiemThi { get; set; }
        public KetQuaThi()
        {
            this.HoTen = String.Empty;
            this.LinhVuc = String.Empty;
            this.DiemThi = String.Empty;
        }

        public KetQuaThi(String _HoTen, String _LinhVuc, String _DiemThi)
        {
            this.HoTen = _HoTen;
            this.LinhVuc = _LinhVuc;
            this.DiemThi = _DiemThi;
        }

        public override string ToString()
        {
            return this.DiemThi + "|" + this.LinhVuc + "|" + this.DiemThi;
        }
    }
}
