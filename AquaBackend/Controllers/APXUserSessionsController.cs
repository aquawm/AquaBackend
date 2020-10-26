using AquaBackend.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Data;

namespace AquaBackend.Controllers
{
    public class APXUserSessionsController : Controller
    {
        // GET: APXUserSessions
        public IActionResult Index()
        {
            List<APXUserSession> UserSessions = new List<APXUserSession>();

            using (SqlConnection sqlConnection = new SqlConnection("data source=192.168.1.7;Database=APXFirm;User ID=lmachado;Password=Aq.Sql.2020"))
            {
                using var cmd = new SqlCommand()
                {
                    CommandText = "SELECT SessionID,FullName,Created,LastTouched FROM APXFirm.AdvApp.vUserSession",
                    CommandType = CommandType.Text,
                    Connection = sqlConnection
                };
                sqlConnection.Open();

                using var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    APXUserSession APXUserSession = new APXUserSession
                    {
                        SessionID = reader[0].ToString(),
                        FullName = reader[1].ToString(),
                        Created = reader[2].ToString(),
                        LastTouched = reader[3].ToString()
                    };
                    UserSessions.Add(APXUserSession);
                }
                sqlConnection.Close();
            }
            return View(UserSessions);
        }
    }
}
