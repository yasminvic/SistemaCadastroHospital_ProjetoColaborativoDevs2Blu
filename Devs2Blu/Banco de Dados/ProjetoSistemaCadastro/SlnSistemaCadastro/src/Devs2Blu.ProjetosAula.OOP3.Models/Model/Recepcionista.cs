using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Recepcionista : Pessoa
    {
        public Int32 Id { get; set; }
        public String Setor { get; set; } 
    }
}
