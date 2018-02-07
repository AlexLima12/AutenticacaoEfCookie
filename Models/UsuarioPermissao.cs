using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutenticacaoEfCookie.Models
{
    public class UsuarioPermissao
    {

         //chave primaria da tabela UsuarioPermissao
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        
        public int IdUsuarioPermissao { get; set; }


        //Criando relacionamento da tabela Usuario
        [Required]
        public  int IdUsuario { get; set; }

        [ForeignKey("IdUsuario")]
        public Usuario Usuario { get; set; }


        //Criando relacionamento da tabela Permissao
        [Required]
        public int IdPermissao { get; set; }
        [ForeignKey("IdPermissao")]
        public Permissao Permissao { get; set; }
    }
}