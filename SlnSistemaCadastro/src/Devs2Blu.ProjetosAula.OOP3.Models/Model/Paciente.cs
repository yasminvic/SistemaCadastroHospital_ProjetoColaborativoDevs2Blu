using Devs2Blu.ProjetosAula.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Paciente 
    {
        public Int32 Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public Convenio Convenio { get; set; }
        public Int32 NumProntuario { get; set; }
        public String PacienteRisco { get; set; }
        public FlStatus Status { get; set; }
        public Int32 FlObito { get; set; }

        public Paciente()
        {
            Pessoa = new Pessoa(); // criando objeto da classe pessoa
            Convenio = new Convenio();
            Status = FlStatus.A;
            FlObito = 0;
            Pessoa.TipoPessoa = TipoPessoa.PF;
        }

        public Paciente(Pessoa pessoa, Convenio convenio, int numProntuario, string pacienteRisco)
        {

            Pessoa = pessoa;
            Convenio = convenio;
            NumProntuario = numProntuario;
            PacienteRisco = pacienteRisco;
            Status = FlStatus.A;
            FlObito = 0;
        }
    }
}
