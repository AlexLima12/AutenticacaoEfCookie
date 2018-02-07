using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoEfCookie.Models
{
    public class Permissao
    {
        //Criando Banco...

        //chave primaria
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public  int IdPermissao { get; set; }

        //Nome da permissão
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Nome { get; set; }

        public ICollection<UsuarioPermissao> UsuariosPermissoes { get; set; }

    }
}