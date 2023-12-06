using RegistroCarrosdosAlunosIF.Models;

namespace RegistroCarrosdosAlunosIF.Actions
{
    public interface ICadastrosRepositorio
    {
        bool Apagar(string prontuario);
        Cadastros AutoAtt(Cadastros cadastros, Cadastros cadastrosDB); //metodo para varrer e alterar os dados no banco
        Cadastros CarregarUltimo(string prontuario);        
        Cadastros BuscarDados(string prontuario);
       /* Cadastros CarregarDados(int id);*///metodo para recuperar os dados para ediçao;
        List<Cadastros> BuscarTodos(); //metodo para listar os cadastros na tela de consulta;
        Cadastros Adicionar(Cadastros cadastros); //metodo para adicionar um novo cadastro ao banco;
        Cadastros Alterar(Cadastros cadastros); //metodo para alterar os dados do cadastro;
        //void Adicionar(Controllers.Cadastros cadastros);     
        
    }
}
