using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

 namespace _3A1PEDRO38

{
    class Jogos
    {
        public int id;
        public string nome;
        public double preco;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into jogos values ('{id}', '{nome}', '{preco}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM jogos; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM jogos WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE jogos SET nome = '{nome}', preco = '{preco}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
