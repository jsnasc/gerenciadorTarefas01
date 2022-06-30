using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBinding2ways.Dados
{
    class Tarefa
    {
        public string Nome{ get; set; }

        public bool Feito { get; set; }

        public bool Fazendo { get; set; }

        public bool Pendente { get; set; }

        public int GrupoID { get; set;}
        
        public Tarefa() { 
        }

        public Tarefa(string name)
        {
            Nome = name;
        }

        public Tarefa(string name,bool feito, bool fazendo, bool pendente) {
            Nome = name;
            Feito = feito;
            Fazendo = fazendo;
            Pendente = pendente;
        }
    }
}
