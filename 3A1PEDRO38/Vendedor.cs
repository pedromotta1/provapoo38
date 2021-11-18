using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

 namespace _3A1PEDRO38

{
    class Vendedor
    {
        public int id, quantidade;
        public string nome_vendedor;
        

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into vendedor values ('{id}', '{nome_vendedor}', '{quantidade}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM vendedor; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM vendedor WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE vendedor SET nome_vendedor = '{nome_vendedor}', quantidade = '{quantidade}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
