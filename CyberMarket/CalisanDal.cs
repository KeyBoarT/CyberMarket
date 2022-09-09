using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CyberMarket
{
    class CalisanDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=CyberMarket; Integrated Security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public List<Calisan> GetAll()
        {
            ConnectionControl();
            List<Calisan> calisanlar = new List<Calisan>();
            SqlCommand command = new SqlCommand("Select * from Calisanlar", _connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Calisan calisan = new Calisan
                    {
                        Id = (int)reader["Id"],
                        Ad = (string)reader["Ad"],
                        Soyad = (string)reader["Soyad"],
                        Pozisyon = (string)reader["Pozisyon"],
                        Durum = (string)reader["Durum"],
                        Resim = (((byte[])reader["Resim"]).Length > 0) ? (byte[])reader["Resim"] : null
                    };
                    calisanlar.Add(calisan);
                }
            }
            _connection.Close();
            return calisanlar;
        }
        public void Add(Calisan calisan)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Calisanlar values(@Ad, @Soyad, @Pozisyon, @Durum, @Resim)", _connection);
            command.Parameters.AddWithValue("@Ad", calisan.Ad);
            command.Parameters.AddWithValue("@Soyad", calisan.Soyad);
            command.Parameters.AddWithValue("@Pozisyon", calisan.Pozisyon);
            command.Parameters.AddWithValue("@Durum", calisan.Durum);
            command.Parameters.Add("@Resim", SqlDbType.Image, calisan.Resim.Length).Value = calisan.Resim;
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Calisan calisan)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Calisanlar set Ad=@Ad, Soyad=@Soyad, Pozisyon=@Pozisyon, Durum=@Durum, Resim=@Resim where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ad", calisan.Ad);
            command.Parameters.AddWithValue("@Soyad", calisan.Soyad);
            command.Parameters.AddWithValue("@Pozisyon", calisan.Pozisyon);
            command.Parameters.AddWithValue("@Durum", calisan.Durum);
            command.Parameters.AddWithValue("@Resim", calisan.Resim);
            command.Parameters.AddWithValue("@Id", calisan.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateWithoutPicture(Calisan calisan)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Calisanlar set Ad=@Ad, Soyad=@Soyad, Pozisyon=@Pozisyon, Durum=@Durum where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Ad", calisan.Ad);
            command.Parameters.AddWithValue("@Soyad", calisan.Soyad);
            command.Parameters.AddWithValue("@Pozisyon", calisan.Pozisyon);
            command.Parameters.AddWithValue("@Durum", calisan.Durum);
            command.Parameters.AddWithValue("@Id", calisan.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Calisan> GetByDurum(string durum)
        {
            ConnectionControl();
            List<Calisan> calisanlar = new List<Calisan>();
            SqlCommand command = new SqlCommand($"Select * from Calisanlar where Durum=@Durum collate Turkish_CI_AS", _connection);
            command.Parameters.AddWithValue("@Durum", durum);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Calisan calisan = new Calisan
                    {
                        Id = (int)reader["Id"],
                        Ad = (string)reader["Ad"],
                        Soyad = (string)reader["Soyad"],
                        Pozisyon = (string)reader["Pozisyon"],
                        Durum = (string)reader["Durum"],
                        Resim = (((byte[])reader["Resim"]).Length > 0) ? (byte[])reader["Resim"] : null
                    };
                    calisanlar.Add(calisan);
                }
            }
            _connection.Close();
            return calisanlar;
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Calisanlar where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}
