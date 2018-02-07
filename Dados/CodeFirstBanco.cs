using AutenticacaoEfCookie.Models;

namespace AutenticacaoEfCookie.Dados
{
    public class CodeFirstBanco
    {
        //Criar banco de dados

        public static void Inicializar(AutenticacaoContexto contexto){
            contexto.Database.EnsureCreated();

            var usuario = new Usuario(){
                Nome = "Fernando",
                Email = "fernado.guerra@corujasdev.com.br",
                Senha = "123456"
            };

            contexto.UsuariosNoBanco.Add(usuario);


            var permissao = new Permissao(){
                Nome = "Financeiro"
            };

            contexto.PermissoesNoBanco.Add(permissao);

            
        }
    }
}