using API_emezu.App_Start;
using API_emezu.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_emezu.Controllers
{
    public class UsuarioController : ApiController
    {
        SqlConnection con = conexao.obterConexao();
        private static List<Usuario> usuarios = new List<Usuario>();

        public DataTable Get()
        {
            string query = "SELECT * FROM usuario";
            SqlCommand cmd = new SqlCommand(query, con);
            conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            //cmd.ExecuteNonQuery();     
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable usuario = new DataTable();
            da.Fill(usuario);          
            return usuario;
        }

        public void Post(Usuario user)
        {
            string query = "INSERT INTO usuario(nome, endereco, telefone) VALUES ('"+user.nome+"','"+user.endereco+"','"+user.telefone+"');";
            SqlCommand cmd = new SqlCommand(query, con);
            conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conexao.fecharConexao();
            //usuarios.Add(user);
        }

        public IHttpActionResult Delete(int Id)
        {
            if (Id <= 0)
                return BadRequest("Not a valid id");
            string query = "DELETE FROM usuario WHERE Id=" + Id;
            SqlCommand cmd = new SqlCommand(query, con);
            conexao.obterConexao();
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            conexao.fecharConexao();
            //Usuario usuario = usuarios.Find(delegate(Usuario us) { return us.Id== Id; });
            //usuarios.Remove(usuario);
            return Ok();
        }
    }
}
