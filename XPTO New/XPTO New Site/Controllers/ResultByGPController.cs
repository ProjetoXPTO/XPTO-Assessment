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
	public class ResultbyGPController : ApiController
	{

		[HttpGet]
		public ResultByGP obterAvaliacao()
		{
			//Cria Objeto da Classe ResultByGP
			ResultByGP a = new ResultByGP();

			//Abre a conexão com o banco de dados
			SqlConnection conn = new SqlConnection("Server=tcp:udfz7di8my.database.windows.net,1433;Database=xpto;User ID=xptodb@udfz7di8my;Password=Xpto123456;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
			conn.Open();
			SqlCommand cmd;

			//Recupera as médias no banco
			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (1,2,3,4)", conn);
			SqlDataReader reader = cmd.ExecuteReader();
			reader.Read();
			a.nota51 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (5,6,7,8,9,10,11,12,13,14,15)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.nota52 = reader.GetDouble(0);
			reader.Close();

			cmd = new SqlCommand("SELECT avg(nota) from avaliacao where id_quest in (16,17,18,19,20,21,22,23,24,25)", conn);
			reader = cmd.ExecuteReader();
			reader.Read();
			a.nota53 = reader.GetDouble(0);
			reader.Close();


			return a;
		}
	}
}