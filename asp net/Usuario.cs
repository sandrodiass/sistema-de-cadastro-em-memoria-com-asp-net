using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace asp_net
{
    public class Usuario
    {
        public Usuario() { }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string gmail { get; set; }


        public static List<Usuario>  Lista = new List<Usuario>();

        public List<Usuario> Todos() 
        {
            return Usuario.Lista;
        }
        /* metodo pra salvar */
        public void Salvar() 
        {
            Usuario.Lista.Add(this);
        
        }
    }
}