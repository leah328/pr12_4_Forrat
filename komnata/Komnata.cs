using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace komnata
{
    class Komnata
    {
        private int length;
        private int width;
        private int height;
        private int kolvookon;
        private int oheight;
        private int owidth;
        private int rulon;
        public string Ss(int kl, int kw)
        {
            this.length = kl;
            this.width = kw;
            int s = kl * kw;
            return "Площадь комнаты: " + s;
        }
        public string Vv(int kl,int kw, int kh)
        {
            this.length = kl;
            this.width = kw;
            this.height = kh;
            int  v = kl * kw*kh;
            return "Объем комнаты: " + v;
        }

        public string Rulon(int kl,int kw,int kh, int r)
        {
            this.length = kl;
            this.width = kw;
            this.height = kh;
            this.rulon = r;
            double kr;
            if (r == 0)
            {
                kr = Math.Ceiling(((((2 * (Convert.ToDouble(kl)) + (2 * Convert.ToDouble(kw))) * kh) / 10)));
                return "Рулонов на 10 метров, понадобиться: " + kr + " штук";
            }
            else
            { if (r == 1)
                {
                    kr = Math.Ceiling(((((2 * (Convert.ToDouble(kl)) + (2 * Convert.ToDouble(kw))) * kh) / 15)));
                    return "Рулонов на 15 метров, понадобиться: " + kr + " штук";
                }
                else return "error";
            }
        }
        public string Info(int kl, int kw, int kh, int ok, int oh, int ow)
        {
            this.length = kl;
            this.width = kw;
            this.height = kh;
            this.kolvookon = ok;
            this.oheight = oh;
            this.owidth = ow;
            return "\nИнформация о комнате:"+
                "\n"+"Длина: " +kl+
                "\n"+"Ширина: "+kw+
                "\n"+"Высота потолков: "+kh+
                "\n"+"Количество окон: "+ok+
                "\n"+"Высота окон: "+oh+
                "\n"+"Ширина окон: "+ow;
        }



    }
}
