using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

namespace OITech.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class MultivalorController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public MultivalorController(
            IConfiguration configuration
            )
        {
            _configuration = configuration;
        }

        //Consultar zonas
        [HttpGet]
        [Route("ConsultarZonas")]
        //[AllowAnonymous]
        public object ConsultarZonas()
        {
            string SProcedure = @"Admin.SPZona";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            var JSONString = JsonConvert.SerializeObject(table);
            return TryFormatJson(JSONString);
        }

        //Consultar Condicion Predio
        [HttpGet]
        [Route("ConsultarCondicionPredio")]
        //[AllowAnonymous]
        public object ConsultarCondicionPredio()
        {
            string SProcedure = @"Admin.SPCondicionPredio";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            var JSONString = JsonConvert.SerializeObject(table);
            return TryFormatJson(JSONString);
        }

        //Consultar Condicion Predio Antiguo
        [HttpGet]
        [Route("ConsultarCondicionPredioAntiguo")]
        //[AllowAnonymous]
        public object ConsultarCondicionPredioAntiguo()
        {
            string SProcedure = @"Admin.SPCondicionPredioAntiguo";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            var JSONString = JsonConvert.SerializeObject(table);
            return TryFormatJson(JSONString);
        }

        //Convierte en JSON
        private static string TryFormatJson(string str)
        {
            try
            {
                object parsedJson = JsonConvert.DeserializeObject(str);
                return JsonConvert.SerializeObject(parsedJson, Formatting.Indented);
            }
            catch
            {
                // can't parse JSON, return the original string
                return str;
            }
        }

    }

}
