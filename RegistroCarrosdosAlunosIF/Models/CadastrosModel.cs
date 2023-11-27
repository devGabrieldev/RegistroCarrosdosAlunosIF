using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RegistroCarrosdosAlunosIF.Controllers;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistroCarrosdosAlunosIF.Models
{
    public class Cadastros
    {
        
        [Key,Column(TypeName = "varchar(20)")]
        public required string Prontuário { get; set; }        
        public required string Nome { get; set; }
        public required int CNH { get; set; }
        public required string Email { get; set; }
        public required int Telefone { get; set; }
        public required string Modelo { get; set; }
        public int Ano { get; set; }
        public string? Cor { get; set; }
        public required string Tipo { get; set; }
        public required string Placa { get; set; }
        public required string Curso { get; set; }
        public required string Periodo { get; set; }

        public static implicit operator string(Cadastros v)
        {
            throw new NotImplementedException();
        }
    }

}
