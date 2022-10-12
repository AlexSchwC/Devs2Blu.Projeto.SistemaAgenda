using Devs2Blu.Projeto.SistemaAgenda.Classes.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaAgenda.Classes
{
    public class Compromisso
    {
        public Contato Contato { get; set; }
        public DateTime Data { get; set; }
        public String Descricao { get; set; }
        public FlConcluido Status { get; set; }

        #region Construtores 

        public Compromisso()
        {

        }

        public Compromisso(Contato contato, DateTime data, String descricao, FlConcluido status)
        {
            Contato = contato;
            Data = data;
            Descricao = descricao;
            Status = status;
        }

        #endregion
    }
}
