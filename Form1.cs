using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SecondCrud;

namespace CoffeeCrud
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null; // PuSing
        Koneksi konek = new Koneksi();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTNinput_Click(object sender, EventArgs e)
        {
            try
            {
                conn = konek.Getconn();
                SqlCommand cmd = new SqlCommand("INSERT INTO Minuman (Nama_Minuman,Jenis_Minuman,Harga) VALUES (@Nama_Minuman,@Jenis_Minuman,@Harga)", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Nama_Minuman", TXTnama.Text);
                cmd.Parameters.AddWithValue("@Jenis_Minuman", TXTjenis.Text);
                cmd.Parameters.AddWithValue("@Harga", TXTharga.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil di Input");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BTNhapus_Click(object sender, EventArgs e)
        {
            try
            {
                conn = konek.Getconn();
                SqlCommand cmd = new SqlCommand("DELETE FROM Minuman WHERE Nama_Minuman = @Nama_Minuman", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Nama_Minuman", TXTnama.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Berhasil Dihapus");
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BTNcari_Click(object sender, EventArgs e)
        {
            try
            {
                conn = konek.Getconn();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Minuman WHERE Nama_Minuman = @Nama_Minuman", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Nama_Minuman", TXTnama.Text);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // Read the first row
                    TXTjenis.Text = reader["Jenis_Minuman"].ToString();
                    TXTharga.Text = reader["Harga"].ToString();
                    MessageBox.Show("Data Ditemukan");
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void BTNubah_Click(object sender, EventArgs e)
        {
            try
            {
                conn = konek.Getconn();
                SqlCommand cmd = new SqlCommand("UPDATE Minuman SET Jenis_Minuman = @Jenis_Minuman, Harga = @Harga WHERE Nama_Minuman = @Nama_Minuman", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@Nama_Minuman", TXTnama.Text);
                cmd.Parameters.AddWithValue("@Jenis_Minuman", TXTjenis.Text);
                cmd.Parameters.AddWithValue("@Harga", TXTharga.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Berhasil Diubah");
                }
                else
                {
                    MessageBox.Show("Data Tidak Ditemukan");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
