using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidades
{
    internal class Metrica
    {
        private int id_metrica;
        private string nombre_metrica;
        private string simbolo;

        public int Id_metrica { get => id_metrica; set => id_metrica = value; }
        public string Nombre_metrica { get => nombre_metrica; set => nombre_metrica = value; }
        public string Simbolo { get => simbolo; set => simbolo = value; }
    }
}
