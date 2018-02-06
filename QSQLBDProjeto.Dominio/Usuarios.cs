using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace QSQLBDProjeto.Dominio
{
    public class Usuarios
    {
        public int Id { get; set; }
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo nome é obrigatório.")]
        public string Nome { get; set; }
        [DisplayName("Cargo")]
        [Required(ErrorMessage = "O campo cargo é obrigatório.")]
        public string Cargo { get; set; }
        [DisplayName("Data")]
        [Required(ErrorMessage = "O campo data é obrigatório.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime Data { get; set; }
    }
}
