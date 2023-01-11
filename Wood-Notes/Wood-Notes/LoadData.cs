using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wood_Notes
{
    public class LoadData
    {
        private int IdNota { get; set; }
        private string TituloNota { get; set; }
        private string ContenidoNota { get; set; }
        private string FechaNota { get; set; }
        
        public int getIdNota()
        {
            return IdNota;
        }
        public void setIdNota (int IdNota)
        {
            this.IdNota = IdNota;
        }

        public string getTituloNota()
        {
            return TituloNota;
        }
        public void setTituloNota(string TituloNota)
        {
            this.TituloNota = TituloNota;
        }

        public string getContenidoNota()
        {
            return ContenidoNota;
        }
        public void setContenidoNota(string ContenidoNota)
        {
            this.ContenidoNota = ContenidoNota;
        }

        public string getFechaNota()
        {
            return FechaNota;
        }
        public void setFechaNota(string FechaNota)
        {
            this.FechaNota = FechaNota;
        }
        
    }

    
}
