using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TogaAbadiClassHitung
{
    public class Pekerjas
    {
        private int nama;
        private int idPekerjas;

        public Pekerjas(int nama, int idPekerjas)
        {
            Nama = nama;
            IdPekerjas = idPekerjas;
        }

        public int Nama { get => nama; set => nama = value; }
        public int IdPekerjas { get => idPekerjas; set => idPekerjas = value; }

        
    }
    
}