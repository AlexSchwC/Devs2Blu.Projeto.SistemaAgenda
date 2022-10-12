using Devs2Blu.Projeto.SistemaAgenda.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaAgenda.Classes
{
    public class Contato
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String UF { get; set; }
        public FlStatus Status { get; set; }

        #region Construtores

        public Contato()
        {

        }

        public Contato(String nome)
        {
            Nome = nome;
            Status = FlStatus.A;
        }

        public Contato(String nome, string telefone, string email, string uf)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            UF = uf;
            Status = FlStatus.A;
        }

        #endregion
    }
}
