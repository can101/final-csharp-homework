using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public class MSSQLUserDal : IUserDal
    {
        SqlConnection _conn = new SqlConnection(@"Data Source=celikdev;Initial Catalog=melisa;Integrated Security=True");

        private void ConnectionControl()
        {
            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }

        public bool Create(User user)
        {
            try
            {
                ConnectionControl();
                string sql = "Insert into users values(@first_name,@last_name,@city,@country,@occupation)";
                SqlCommand command = new SqlCommand(sql, _conn);
                command.Parameters.AddWithValue("@first_name", user.First_Name);
                command.Parameters.AddWithValue("@last_name", user.Last_Name);
                command.Parameters.AddWithValue("@city", user.City);
                command.Parameters.AddWithValue("@country", user.Country);
                command.Parameters.AddWithValue("@occupation", user.Occupation);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Added!");
                    return true;
                }
                else
                {
                    MessageBox.Show("No rows were added.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Added Error!!!!");
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public bool Delete(User user)
        {
            try
            {
                ConnectionControl();
                string sql = "Delete from users where Id=@id";
                SqlCommand command = new SqlCommand(sql, _conn);
                command.Parameters.AddWithValue("@id", user.Id);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Deleted!");
                    return true;
                }
                else
                {
                    MessageBox.Show("No rows were deleted.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deleted Error!!!!");
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

        public List<User> GetAll()
        {
            ConnectionControl();
            string sql = "SELECT * FROM users";
            SqlCommand command = new SqlCommand(sql, _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<User> users = new List<User>();
            while (reader.Read())
            {
                User user = new User
                {
                    Id = Convert.ToInt32(reader["id"]),
                    First_Name = reader["first_name"].ToString(),
                    Last_Name = reader["last_name"].ToString(),
                    Occupation = reader["occupation"].ToString(),
                    City = reader["city"].ToString(),
                    Country = reader["country"].ToString(),
                };
                users.Add(user);

            }
            reader.Close();
            _conn.Close();
            return users;
        }

        public bool Update(User user)
        {
            try
            {
                ConnectionControl();
                string sql = "Update users SET first_name=@first_name,last_name=@last_name,city=@city,country=@country,occupation=@occupation where id=@id";
                SqlCommand command = new SqlCommand(sql, _conn);
                command.Parameters.AddWithValue("@id", user.Id);
                command.Parameters.AddWithValue("@first_name", user.First_Name);
                command.Parameters.AddWithValue("@last_name", user.Last_Name);
                command.Parameters.AddWithValue("@city", user.City);
                command.Parameters.AddWithValue("@country", user.Country);
                command.Parameters.AddWithValue("@occupation", user.Occupation);
                int rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Updated!");
                    return true;
                }
                else
                {
                    MessageBox.Show("No rows were updated.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Uptaded Error!!!!");
                Console.WriteLine(ex.ToString());
                _conn.Close();
                return false;
            }
            finally
            {
                _conn.Close();
            }
        }

    }
}
