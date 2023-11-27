using RegistroCarrosdosAlunosIF.Models;

namespace RegistroCarrosdosAlunosIF.Actions
{
    public interface ICadastrosRepositorio
    {
        Cadastros CarregarCadastro(Cadastros prontuario);
        List<Cadastros> BuscarTodos();
        Cadastros Adicionar(Cadastros cadastros);
        void Adicionar(Controllers.Cadastros cadastros);        
    }
}
