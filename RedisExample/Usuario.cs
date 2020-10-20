using System;
using System.Collections.Generic;
using System.Text;

namespace RedisExample
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Usuario()
        {
            Id = Guid.NewGuid();
        }
    }
}
