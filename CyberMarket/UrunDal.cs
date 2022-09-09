using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CyberMarket
{
    public class UrunDal
    {
        SqlConnection _connection = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog=CyberMarket; Integrated Security=true");

        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public List<Urun> GetAll()
        {
            ConnectionControl();
            List<Urun> urunler = new List<Urun>();
            SqlCommand command = new SqlCommand("Select * from Urunler", _connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Urun urun = new Urun
                    {
                        Id = (int)reader["Id"],
                        UrunAdi = (string)reader["UrunAdi"],
                        UrunFiyati = (decimal)reader["UrunFiyati"],
                        UrunAdedi = (int)reader["UrunAdedi"],
                        UrunSinifi = (string)reader["UrunSinifi"],
                        UrunResmi = (((byte[])reader["UrunResmi"]).Length > 0) ? (byte[])reader["UrunResmi"] : null
                    };
                    urunler.Add(urun);
                }
            }
            _connection.Close();
            return urunler;
        }
        public void Add(Urun urun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Urunler values(@UrunAdi, @UrunFiyati, @UrunAdedi, @UrunSinifi, @UrunResmi)", _connection);
            command.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", urun.UrunFiyati);
            command.Parameters.AddWithValue("@UrunAdedi", urun.UrunAdedi);
            command.Parameters.AddWithValue("@UrunSinifi", urun.UrunSinifi);
            command.Parameters.Add("@UrunResmi", SqlDbType.Image, urun.UrunResmi.Length).Value = urun.UrunResmi;
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void Update(Urun urun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Urunler set UrunAdi=@UrunAdi, UrunFiyati=@UrunFiyati, UrunAdedi=@UrunAdedi, UrunSinifi=@UrunSinifi, UrunResmi=@UrunResmi where Id=@Id", _connection);
            command.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", urun.UrunFiyati);
            command.Parameters.AddWithValue("@UrunAdedi", urun.UrunAdedi);
            command.Parameters.AddWithValue("@UrunSinifi", urun.UrunSinifi);
            command.Parameters.AddWithValue("@UrunResmi", urun.UrunResmi);
            command.Parameters.AddWithValue("@Id", urun.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void UpdateWithoutPicture(Urun urun)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update Urunler set UrunAdi=@UrunAdi, UrunFiyati=@UrunFiyati, UrunAdedi=@UrunAdedi, UrunSinifi=@UrunSinifi where Id=@Id", _connection);
            command.Parameters.AddWithValue("@UrunAdi", urun.UrunAdi);
            command.Parameters.AddWithValue("@UrunFiyati", urun.UrunFiyati);
            command.Parameters.AddWithValue("@UrunAdedi", urun.UrunAdedi);
            command.Parameters.AddWithValue("@UrunSinifi", urun.UrunSinifi);
            command.Parameters.AddWithValue("@Id", urun.Id);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public List<Urun> GetBySinif(string SinifAdi)
        {
            ConnectionControl();
            List<Urun> urunler = new List<Urun>();
            SqlCommand command = new SqlCommand($"Select * from Urunler where UrunSinifi=@UrunSinifi collate Turkish_CI_AS", _connection);
            command.Parameters.AddWithValue("@UrunSinifi", SinifAdi);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Urun urun = new Urun
                    {
                        Id = (int)reader["Id"],
                        UrunAdi = (string)reader["UrunAdi"],
                        UrunFiyati = (decimal)reader["UrunFiyati"],
                        UrunAdedi = (int)reader["UrunAdedi"],
                        UrunSinifi = (string)reader["UrunSinifi"],
                        UrunResmi = (((byte[])reader["UrunResmi"]).Length > 0) ? (byte[])reader["UrunResmi"] : null
                    };
                    urunler.Add(urun);
                }
            }
            _connection.Close();
            return urunler;
        }

        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from Urunler where Id=@Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }

}
