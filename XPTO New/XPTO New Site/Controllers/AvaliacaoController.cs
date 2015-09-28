using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data;
using System.Data.SqlClient;
using XPTO_New_Site.Models;

namespace XPTO_New_Site.Controllers
{
	public class AvaliacaoController : ApiController
	{
		// POST api/Avaliacao/
		[HttpPost]
		public bool Finalizar([FromBody]Avaliacao resp)
		{
			
			//Cria e abre a conexão com o banco de dados (essa string só serve para acessar o banco localmente)
			//Ver mais strings de conexão em http://www.connectionstrings.com/
			SqlConnection conn = new SqlConnection("Server=tcp:udfz7di8my.database.windows.net,1433;Database=xpto;User ID=xptodb@udfz7di8my;Password=Xpto123456;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
			conn.Open();

			
			SqlCommand cmd;

			for (int x = 0; x < 25; x++)
			{
				
				//Cria um comando para inserir um novo registro à tabela
				cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
				cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
				cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
				cmd.Parameters[0].Value = x + 1;
				cmd.Parameters[1].Value = resp.resposta[x];
				cmd.ExecuteNonQuery();
				cmd.Dispose();


			}

			return true;

		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 5112;
		//	cmd.Parameters[1].Value = respostas.Nota5112;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 512;
		//	cmd.Parameters[1].Value = respostas.Nota512;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	//Nota 513
		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 513;
		//	cmd.Parameters[1].Value = respostas.Nota513;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	//Nota 5211
		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 5211;
		//	cmd.Parameters[1].Value = respostas.Nota5211;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	//Nota 5212
		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 5212;
		//	cmd.Parameters[1].Value = respostas.Nota5212;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	//Nota 5213
		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 5213;
		//	cmd.Parameters[1].Value = respostas.Nota5213;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	//Nota 5214
		//	cmd = new SqlCommand("INSERT INTO avaliacao (id_quest, nota) VALUES (@a,@b)", conn);
		//	cmd.Parameters.Add(new SqlParameter("@a", SqlDbType.Int));
		//	cmd.Parameters.Add(new SqlParameter("@b", SqlDbType.Float));
		//	cmd.Parameters[0].Value = 5214;
		//	cmd.Parameters[1].Value = respostas.Nota5214;
		//	cmd.ExecuteNonQuery();
		//	cmd.Dispose();

		//	//Fecha a conexão ao final pois ela não é mais necessária
		//	conn.Close();
		//	conn.Dispose();


		//	return true;
		//}

		//[HttpGet]
		//public Avaliacao ObterAvaliacao()
		//{
		//	Avaliacao a = new Avaliacao();
		//	SqlConnection conn = new SqlConnection("Server=tcp:yoyyscq7wn.database.windows.net,1433;Database=Xpto;User ID=projetoxpto@yoyyscq7wn;Password=Ecritorio123;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
		//	conn.Open();
		//	SqlCommand cmd;

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 5111", conn);
		//	SqlDataReader reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota5111 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 5112", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota5112 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 512", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota512 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 513", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota513 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 5211", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota5211 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 5212", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota5212 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 5213", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota5213 = reader.GetDouble(0);
		//	reader.Close();

		//	cmd = new SqlCommand("SELECT avg(nota) from avaliacao where nr_quest = 5214", conn);
		//	reader = cmd.ExecuteReader();
		//	reader.Read();
		//	a.Nota5214 = reader.GetDouble(0);
		//	reader.Close();


		//	return a;
		}
	}
}