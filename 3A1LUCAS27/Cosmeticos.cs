using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

 namespace _3A1LUCAS27

{
    class Cosmeticos
    {
        public int id;
        public string nome;
        public double preco;

        Conexao obj = new Conexao();

        public void Cadastrar()
        {

            string inserir = $@"insert into cosmeticos values ('{id}', '{nome}', '{preco}');";
            obj.ExecutarComando(inserir);

        }

        public DataTable Listar()     //Requer: using System.Data;
        {
            string listar = $"SELECT * FROM cosmeticos; ";
            return obj.ExecutarConsulta(listar);
        }
        public void Excluir()
        {
            string deletar = $"DELETE FROM cosmeticos WHERE id = '{id}'; ";
            obj.ExecutarComando(deletar);
        }

        public void Alterar()
        {
            string alterar = $"UPDATE cosmeticos SET nome = '{nome}', preco = '{preco}' WHERE id = '{id}'";
            obj.ExecutarComando(alterar);
        }
    }
}
