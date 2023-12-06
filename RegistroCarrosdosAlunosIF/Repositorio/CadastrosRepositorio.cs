using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using RegistroCarrosdosAlunosIF.Dados;
using RegistroCarrosdosAlunosIF.Models;
using System.Runtime.CompilerServices;

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

        public Cadastros BuscarDados(string prontuario)
        {
            return _bancoContext.Cadastros.Find(prontuario);
        }
        public Cadastros CarregarUltimo(string prontuario)
        {
            var query = $"SELECT TOP 1 * FROM Cadastros WHERE Prontuário = @prontuario";
            // Substitua 'SuaContext' pelo nome real do seu contexto de banco de dados.
            return _bancoContext.Cadastros.FromSqlRaw(query, new SqlParameter("@prontuario", prontuario)).SingleOrDefault();
        }

        public Cadastros Alterar(Cadastros cadastros)
        {
            Cadastros cadastrosDB = BuscarDados(cadastros.Prontuário);
            if (cadastrosDB == null) throw new SystemException("Opa! Houve um erro ao atualizar o cadastro!");

            AutoAtt(cadastros, cadastrosDB);


            _bancoContext.Cadastros.Update(cadastrosDB);
            _bancoContext.SaveChanges();
            return cadastrosDB;

        }

        public Cadastros AutoAtt(Cadastros cadastros, Cadastros cadastrosDB)
        {
            var propriedades = typeof(Cadastros).GetProperties();
            foreach (var prop in propriedades)
            {
                var DbAtt = prop.GetValue(cadastros);
                prop.SetValue(cadastrosDB, DbAtt);
            }
            return cadastrosDB;
        }

        public bool Apagar(string prontuario)
        {
            Cadastros cadastrosDB = BuscarDados(prontuario);
            if (cadastrosDB == null) throw new SystemException("Opa! Houve um erro ao excluir o cadastro!");
            _bancoContext.Cadastros.Remove(cadastrosDB);
            _bancoContext.SaveChanges(true);
            return true;
        }
    }
}
