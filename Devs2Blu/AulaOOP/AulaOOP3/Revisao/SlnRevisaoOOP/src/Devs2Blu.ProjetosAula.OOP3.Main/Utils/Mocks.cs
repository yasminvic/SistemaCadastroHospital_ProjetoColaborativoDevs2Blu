using Devs2Blu.ProjetosAula.OOP3.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public List<Paciente> ListaPacientes { get; set; }
        public List<Medico> ListaMedicos { get; set; }
        public List<Recepcionista> ListaRecepcionistas { get; set; }
        public List<Fornecedor> ListaFornecedores { get; set; }

        public Mocks()
        {
            ListaPacientes = new List<Paciente>();
            ListaMedicos = new List<Medico>();
            ListaRecepcionistas = new List<Recepcionista>();
            ListaFornecedores = new List<Fornecedor>();

            CargaMock();
        }

        #region Métodos Cargas
        public void CargaMock()
        {
            CargaPacientes();
            CargaMedico();
            CargaRecepcionista();
            CargaFornecedor();
        }

        public void CargaPacientes()
        {
            Random rd = new Random();
            String[] convenio = { "Unimed", "Bradesco Saúde", "Amil", "Golden Cross", "NotreDame Intermédica" };
            for (int i = 0; i < 10; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i+1}", $"{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}-{i}{rd.Next(0, 9)}", convenio[rd.Next(0, 5)]);
                ListaPacientes.Add(paciente);
            }
        }

        public void CargaMedico()
        {
            Random rd = new Random();
            Int32 codigoCRM;
            String[] especialidades = { "Clínico Geral", "Neurologista", "Ginecolgista", "Pediatra", "Cardiologista" };
            for (int i = 0; i < 10; i++)
            {
                codigoCRM = Int32.Parse($"{rd.Next(10000000, 99999999)}");
                Medico medico = new Medico(i, $"Médico {i+1}", $"{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}-{i}{rd.Next(0, 9)}", codigoCRM, especialidades[rd.Next(0, 5)]);
                ListaMedicos.Add(medico);
            }
        }

        public void CargaRecepcionista()
        {
            Random rd = new Random();
            String[] setor = { "Atendimentos", "Quartos", "Saquão", "Agendamentos"};
            for (int i = 0; i < 10; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, $"Paciente {i + 1}", $"{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}-{i}{rd.Next(0, 9)}", setor[rd.Next(0, 4)]);
                ListaRecepcionistas.Add(recepcionista);
            }
        }

        public void CargaFornecedor()
        {
            Random rd = new Random();
            String[] tipoForncedor = { "Alimenticios", "Medicamentos", "Ferramentas", "Internet", "TI"};
            for (int i = 0; i < 10; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, $"Fornecedor {i + 1}", $"{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}.{i}{rd.Next(10, 99)}-{i}{rd.Next(0, 9)}", tipoForncedor[rd.Next(0, 5)]);
                ListaFornecedores.Add(fornecedor);
            }
        }
        #endregion
    }
}
