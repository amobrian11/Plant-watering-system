using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace PRJ_Auto_Watering
{
    class Datahandler
    {
        private SqlConnection connect = new SqlConnection("Server=.; Initial Catalog= dbPlants; Integrated Security = SSPI");

        public Datahandler() { }

        public void Open()
        {
            try
            {
                connect.Open();
            }
            catch (Exception er)
            {
                Console.WriteLine("Connection Not successful. \n" + er.Message);
                return;
            }
        }

        public SqlDataReader getPlants()
        {
            Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblPData", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            return HasRows(reader);

        }

        public SqlDataReader OrderByDifference(string name) 
        {
            Open();
            string query = $"SELECT * FROM tblPData  WHERE [Name] = {name} ORDER BY DIFFERENCE(Name,{name}) DESC";
            SqlCommand cmd = new SqlCommand(query, connect);
            SqlDataReader reader = cmd.ExecuteReader();
            return HasRows(reader);

        }

        public void updatePData(int id, string name, int moisture, string description)
        {
            Open();
            string query = $"UPDATE tblPData SET [Name] = '{name}', MoistureLvl = {moisture}, [Description] = {description}  WHERE PlantId = {id}";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            Close();
        }

        public SqlDataReader getPLevels()
        {
            Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM tblPLevels", connect);
            SqlDataReader reader = cmd.ExecuteReader();
            return HasRows(reader);
        }

        public void insertPData(string name, int moisture, string description, string path)
        {
            Open();
            if (path.Length > 0)
            {
                string query = $"INSERT INTO tblPData ([Name], MoistureLvl, Description, Image) VALUES ('{name}', {moisture}, '{description}', '{path}')";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string query = $"INSERT INTO tblPData ([Name], MoistureLvl, Description) VALUES ('{name}', {moisture}, '{description}')";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();
            }
            Close();
        }

        public void insertPLevels(int id, int MoisturePre, int MoisturePost, int Day, int Month)
        {
            Open();
            string query = $"INSERT INTO tblPLevels ([Name],MoisturePre,MoisturePost,[Day],[Month]) VALUES ({id},{MoisturePre},{MoisturePost},{Day},{Month})";
            SqlCommand cmd = new SqlCommand(query, connect);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void deletePData(int id)
        {
            Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM tblPData WHERE PlantId = @id", connect);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();
            Close();
        }

        public void Close()
        {
            connect.Close();
            connect.Dispose();
        }

        public SqlDataReader HasRows(SqlDataReader reader)
        {
            if (!reader.HasRows)
            {
                Console.WriteLine("No data has been found");
                Close();
                return null;
            }
            return reader;
        }
        public SqlConnection Connect { get => connect; set => connect = value; }
    }
}
