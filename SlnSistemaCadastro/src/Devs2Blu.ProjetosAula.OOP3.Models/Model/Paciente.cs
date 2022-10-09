using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Enums;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Paciente
    {
        public Int32 Id { get; set; }
        public Pessoa Pessoa { get; set; }
        public Convenio Convenio { get; set; }
        public Paciente paciente { get; set; }
        public Int32 NrProntuario { get; set; }
        public String PacienteRisco { get; set; }
        public Int32 FlObito { get; set; }
        public FlStatus Status { get; set; }

        public Paciente()
        {
            Pessoa = new Pessoa();
            Convenio = new Convenio();
            Status = FlStatus.A;
            FlObito = 0;

            Pessoa.TipoPessoa = TipoPessoa.PF;
        }

        public Paciente(int id, Pessoa pessoa, Convenio convenio, int nrProntuario, string pacienteRisco, int flObito, FlStatus status)
        {
            Id = id;
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            PacienteRisco = pacienteRisco;
            FlObito = flObito;
            Status = status;
        }

        public Paciente(Pessoa pessoa, Convenio convenio, int nrProntuario, string pacienteRisco)
        {
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            PacienteRisco = pacienteRisco;
            Status = FlStatus.A;
            FlObito = 0;
        }
    }
}
