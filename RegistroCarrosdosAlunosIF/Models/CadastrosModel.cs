using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using RegistroCarrosdosAlunosIF.Controllers;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RegistroCarrosdosAlunosIF.Models
{
    public class Cadastros
    {
                
        [Key,Required (ErrorMessage ="Digite um Prontuário válido")]
        public  string Prontuário { get; set; }
        [Required(ErrorMessage = "Digite um nome válido")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite uma CNH válida")]
        public string CNH { get; set; }
        [Required(ErrorMessage = "Digite um e-mail válido"), EmailAddress(ErrorMessage ="Digita um e-mail valido e único!")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite um telefone válido"), Phone(ErrorMessage = "Diga um telefone valido e único!")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Escolha uma marca válida")]
        public string Marca { get; set; }
        [Required(ErrorMessage = "Digite um modelo válido")]
        public string Modelo { get; set; }
        [Required(ErrorMessage = "Digite um ano válido")]
        public  string Ano { get; set; }
        [Required(ErrorMessage = "Digite uma cor válida")]
        public  string Cor { get; set; }
        [Required(ErrorMessage = "Escolha um modelo válido")]
        public  string Tipo { get; set; }
        [Required(ErrorMessage = "Digite uma placa valida e única  ")]
        public  string Placa { get; set; }
        [Required(ErrorMessage = "Escolha um curso válido")]
        public  string Curso { get; set; }
        [Required(ErrorMessage = "Digite um perído de curso válido")]
        public  string Período { get; set; }        
      
    }
}
