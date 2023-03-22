using JogoDaMemoria.DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaMemoria.DAO
{
    class JogoDAO
    {
        public List<JogoDTO> ListarJogos()
        {
            var conexao = ConnectionFactory.Create();
            conexao.Open();

            var query = "SELECT * FROM Jogo ORDER BY tempo ASC LIMIT 5";
            var comando = new MySqlCommand(query, conexao);
            var dataReader = comando.ExecuteReader();
            var ListaJogos = new List<JogoDTO>();

            while (dataReader.Read())
            {
                var jogo = new JogoDTO();
                jogo.ID = int.Parse(dataReader["id"].ToString());
                jogo.Nome = dataReader["nome"].ToString();
                jogo.Tempo = int.Parse(dataReader["tempo"].ToString());
                jogo.Movimentos = int.Parse(dataReader["movimentos"].ToString());

                ListaJogos.Add(jogo);
            }

            conexao.Close();

            return ListaJogos;
        }

        public void CadastraJogo(JogoDTO jogo)
        {
            var conexao = ConnectionFactory.Create();
            conexao.Open();

            var query = @"INSERT INTO Jogo (nome,tempo, movimentos) VALUES
						(@nome,@tempo, @movimentos)";

            var comando = new MySqlCommand(query, conexao);
            comando.Parameters.AddWithValue("@nome", jogo.Nome);
            comando.Parameters.AddWithValue("@tempo", jogo.Tempo);
            comando.Parameters.AddWithValue("@movimentos", jogo.Movimentos);

            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
