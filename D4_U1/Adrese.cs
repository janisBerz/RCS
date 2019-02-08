using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_U1
{
    class Adrese
    {
        public string Valsts;
        public string Pilseta;
        public string Iela;

        public Adrese(string Valsts, string Pilseta, string Iela)
        {
            this.Valsts = Valsts;
            this.Pilseta = Pilseta;
            this.Iela = Iela;

        }

        public Adrese()
        {
              
        }


        public string PilnaAdrese()
        {
            return string.Format("{0}, {1}, {2)", Valsts, Pilseta, Iela);
        }



    }
}
