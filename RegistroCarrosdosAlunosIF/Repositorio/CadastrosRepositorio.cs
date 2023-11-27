using RegistroCarrosdosAlunosIF.Dados;
using RegistroCarrosdosAlunosIF.Models;

namespace RegistroCarrosdosAlunosIF.Actions
{
    public class CadastrosRepositorio : ICadastrosRepositorio
    {

        private readonly CadastroDbContext _bancoContext;
        public CadastrosRepositorio(CadastroDbContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public Cadastros Adicionar(Cadastros cadastros)
        {
            // inserçao dos dados no banco

            _bancoContext.Cadastros.Add(cadastros);
            _bancoContext.SaveChanges();
            return cadastros;
        }

        public void Adicionar(Controllers.Cadastros cadastros)
        {
            throw new NotImplementedException();
        }

        public List<Cadastros> BuscarTodos()
        {
            return _bancoContext.Cadastros.ToList();
        }

        public Cadastros CarregarCadastro(Cadastros prontuario)
        {
            
               return _bancoContext.Cadastros.FirstOrDefault(proc => proc.Prontuário == prontuario);

                //// Adicione logs para depuração
                //if (cadastro != null)
                //{
                //    System.Diagnostics.Debug.WriteLine($"Cadastro carregado com sucesso: Prontuário - {cadastro.Prontuário}, Nome - {cadastro.Nome}");
                //}
                //else
                //{
                //    System.Diagnostics.Debug.WriteLine($"Cadastro não encontrado para o prontuário {prontuario}");
                //}

                //return cadastro;
            

        }     
    }
}
