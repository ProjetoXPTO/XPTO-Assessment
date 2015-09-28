using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using XPTO_New_Site.Models;
using System.Data;
using System.Data.SqlClient;


namespace XPTO_New_Site.Controllers
{
	public class LoginUserController : ApiController
	{
		[HttpPost]
		public LoginUser logar([FromBody] string senha)
		{

			SqlConnection conn = new SqlConnection("Server=tcp:udfz7di8my.database.windows.net,1433;Database=xpto;User ID=xptodb@udfz7di8my;Password=Xpto123456;Trusted_Connection=False;Encrypt=True;Connection Timeout=30;");
			conn.Open();

			SqlCommand cmd;
			SqlDataReader reader;

			cmd = new SqlCommand("select senha from usuario where senha = '" + senha +"'", conn);
			reader = cmd.ExecuteReader();
			reader.Read();


			LoginUser a = new LoginUser();

			if (reader.HasRows)
			{
				a.senha = true;
				return a;
			}
			else
			{
				a.senha = false;
				return a;

			}



		}


	}
}