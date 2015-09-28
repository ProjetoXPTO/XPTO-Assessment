using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.SqlClient;
using System.Data;
using XPTO_New_Site.Models;

namespace XPTO_New_Site.Controllers
{
	public class ResultByProcessoController : ApiController
	{

		[HttpGet]
		public ResultByProcesso obterAvaliacao()
		{
			//Cria Objeto da Classe ResultByGP
			ResultByProcesso a = new ResultByProcesso();

			//Abre a conexão com o banco de dados
			SqlConnection conn = new SqlConnection("Server=tcp:udfz7di8my.database.windows.net,1433;Database=xpto;User ID=xptodb@udfz7di8my;Password=Xpto123456;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
			conn.Open();
			SqlCommand cmd;

			//Recupera as médias no banco
			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (1,2)", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			a.processo1 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest = 3", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo2 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest = 4", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo3 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (5,6,7,8)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo4 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (9,10,11)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo5 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (12,13,14,15)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo6 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (16,17,18,19)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo7 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (20,21)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo8 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (2,23,24,25)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.processo9 = reader.GetDouble(0);
			reader.Close();

			return a;

		}




	}
}