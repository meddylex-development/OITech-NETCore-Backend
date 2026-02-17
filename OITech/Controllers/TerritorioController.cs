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

    public class TerritorioController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public TerritorioController(
            IConfiguration configuration
            )
        {
            _configuration = configuration;
        }

        //Consultar departamento
        [HttpGet]
        [Route("ConsultarDepartamento")]
        //[AllowAnonymous]
        public object ConsultarDepartamento()
        {
            string SProcedure = @"Admin.SPDepartamento";
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

        //Consultar municipio
        [HttpGet]
        [Route("ConsultarMunicipio")]
        //[AllowAnonymous]
        public object ConsultarMunicipio(string COD_DPTO)
        {
            string SProcedure = @"Admin.SPMunicipio";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@COD_DPTO", COD_DPTO);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            var JSONString = JsonConvert.SerializeObject(table);
            return TryFormatJson(JSONString);
        }

        //Consultar veredas
        [HttpGet]
        [Route("ConsultarVeredas")]
        //[AllowAnonymous]
        public object ConsultarVeredas(string DPTOMPIO)
        {
            string SProcedure = @"Admin.SPVeredas";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@DPTOMPIO", DPTOMPIO);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            var JSONString = JsonConvert.SerializeObject(table);
            return TryFormatJson(JSONString);
        }

        //Consultar comuna
        [HttpGet]
        [Route("ConsultarComunas")]
        //[AllowAnonymous]
        public object ConsultarComunas(string DPTOMPIO)
        {
            string SProcedure = @"Admin.SPComunas";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@DPTOMPIO", DPTOMPIO);
                    myReader = myCommand.ExecuteReader();
                    table.Load(myReader);
                    myReader.Close();
                    myCon.Close();
                }
            }
            var JSONString = JsonConvert.SerializeObject(table);
            return TryFormatJson(JSONString);
        }


        //Consultar barrios
        [HttpGet]
        [Route("ConsultarBarrios")]
        //[AllowAnonymous]
        public object ConsultarBarrios(string DPTOMPIO, string Comuna)
        {
            string SProcedure = @"Admin.SPBarrios";
            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("OITechContext");
            SqlDataReader myReader;
            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand myCommand = new SqlCommand(SProcedure, myCon))
                {
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.Parameters.AddWithValue("@DPTOMPIO", DPTOMPIO);
                    myCommand.Parameters.AddWithValue("@Comuna", Comuna);
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
