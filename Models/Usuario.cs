using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoEfCookie.Models
{
    public class Usuario
    {   
        //Criando Banco...

        //chave primaria
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public  int IdUsuario { get; set; }

        //Nome de usuario
        [StringLength(100, MinimumLength=4)]
        [Required]
        public string Nome { get; set; }

        //Email
        [StringLength(50, MinimumLength=4)]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        //Senha
        [StringLength(12, MinimumLength=4)]
        [DataType(DataType.Password)]
        [Required]
        public string Senha { get; set; }

        public ICollection<UsuarioPermissao> UsuariosPermissoes { get; set; }

    }
}