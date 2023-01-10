using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JMBet
{
    public class Utente
    {
        int id;
        String nome;

        public Utente(int id, string nome)
        {
            this.id = id;
            this.nome = nome;
        }

        public String toString()
        {
            return nome;
        }

        public int getId()
        {
            return id;
        }
    }
}
