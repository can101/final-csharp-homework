using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.ConstrainedExecution;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int dbSelectIndex = 0;
        //public MySqlConnection mysqlbaglan = new MySqlConnection("Server=localhost;Database=melisa;Uid=root;Pwd='14531453';");

        //SqlConnection _conn = new SqlConnection(@"Data Source=celikdev;Initial Catalog=test;Integrated Security=True");
        MSSQLUserDal msSQlUserDal = new MSSQLUserDal();
        MySQLUserDal mySQlUserDal = new MySQLUserDal();
        User user = new User();
        public Form1()
        {
            InitializeComponent();
            dbComboBox.SelectedIndex = dbSelectIndex;
            LoadUsers();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dbSelectIndex = dbComboBox.SelectedIndex;
            LoadUsers();
        }
        private void LoadUsers()
        {
            if (dbSelectIndex == 0)
            {
                dataGridView1.DataSource = msSQlUserDal.GetAll();
            }
            else
            {
                dataGridView1.DataSource = mySQlUserDal.GetAll();
            }
        }
        private void createBtn_Click(object sender, EventArgs e)
        {
            User user = new User
            {
                City = cityTextBox.Text,
                Country = countryTextBox.Text,
                First_Name = firstNameTextBox.Text,
                Last_Name = lastNameTextBox.Text,
                Occupation = occupationTextBox.Text
            };
            bool result;
            if (dbSelectIndex == 0)
            {
                result = msSQlUserDal.Create(user);
            }
            else
            {
                result = mySQlUserDal.Create(user);
            }
            if (result)
            {
                LoadUsers();
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
                lastNameTextBox.Clear();
                cityTextBox.Clear();
                countryTextBox.Clear();
                occupationTextBox.Clear();
            }
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            bool result;
            if (dbSelectIndex == 0)
            {
                result = msSQlUserDal.Delete(user);
            }
            else
            {
                result = mySQlUserDal.Delete(user);
            }
            if (result)
            {
                editPanel.Visible = false;
                user = new User { };
                LoadUsers();
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            User updateUser = new User
            {
                First_Name = firstNameUpdateTextBox.Text,
                Last_Name = lastNameUpdateTextBox.Text,
                City = cityUpdateTextBox.Text,
                Country = countryUpdateTextBox.Text,
                Occupation = occupationUpdateTextBox.Text,
                Id = user.Id,
            };
            bool result;
            if (dbSelectIndex == 0)
            {
                result = msSQlUserDal.Update(updateUser);
            }
            else
            {
                result = mySQlUserDal.Update(updateUser);
            }
            if (result)
            {
                editPanel.Visible = false;
                user = new User { };
                LoadUsers();
            }
        }
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            user.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            user.First_Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            user.Last_Name = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            user.City = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            user.Country = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            user.Occupation = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            IdUpdateTextBox.Text = user.Id.ToString();
            firstNameUpdateTextBox.Text = user.First_Name;
            lastNameUpdateTextBox.Text = user.Last_Name;
            cityUpdateTextBox.Text = user.City;
            countryUpdateTextBox.Text = user.Country;
            occupationUpdateTextBox.Text = user.Occupation;
            editPanel.Visible = true;
        }




        /*  private void Form1_Load(object sender, EventArgs e)
          {
              sqlveri_cek();
          }

          public void mysqlveri_cek()
          {
              /* dataGridView1.View = View.Details;
               dataGridView1.GridLines = true;
               dataGridView1.Columns.Add("Ad_Soyad", 100);
               dataGridView1.Columns.Add("ID");
               dataGridView1.Columns.Add("Meslek");
               dataGridView1.Columns.Add("Sehir");
               dataGridView1.Columns.Add("Ulke");
               try
               {
                   mysqlbaglan.Open();

                   string sql = "SELECT * FROM odev";
                   MySqlCommand command = new MySqlCommand(sql, mysqlbaglan);
                   MySqlDataReader reader = command.ExecuteReader();
                   while (reader.Read())
                   {
                       ListViewItem item = new ListViewItem(reader["Ad_Soyad"].ToString());
                       item.SubItems.Add(reader["id"].ToString());
                       item.SubItems.Add(reader["Meslek"].ToString());  //www.yazilimkodlama.com
                       item.SubItems.Add(reader["Sehir"].ToString());
                       item.SubItems.Add(reader["Ulke"].ToString());
                      // dataGridView1.Items.Add(item);
                   }
                   reader.Close();
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.ToString());
               }

               mysqlbaglan.Close();
          }

          private void dataGridView1_ColumnClick(object sender, ColumnClickEventArgs e)
          {

              /* if (dataGridView1.Sorting == SortOrder.Ascending)
               {
                   this.dataGridView1.Columns[0].Text = "Ad_Soyad (Z-A)";
                   dataGridView1.Sorting = SortOrder.Descending;
               }
               else
               {
                   this.dataGridView1.Columns[0].Text = "Ad_Soyad (A-Z)";
                   dataGridView1.Sorting = SortOrder.Ascending;
               }
          }

          private void add_Click(object sender, EventArgs e)
          {
              try
              {
                  if (_conn.State == ConnectionState.Closed)
                  {
                      _conn.Open();
                  }

                  string sql = "Insert into users values(@first_name,@last_name,@city,@country,@occupation)";
                  SqlCommand command = new SqlCommand(sql, _conn);
                  command.Parameters.AddWithValue("@first_name", firstNameTextBox.Text);
                  command.Parameters.AddWithValue("@last_name", lastNameTextBox.Text);
                  command.Parameters.AddWithValue("@city", cityTextBox.Text);
                  command.Parameters.AddWithValue("@country", countryTextBox.Text);
                  command.Parameters.AddWithValue("@occupation", occupationTextBox.Text);
                  command.ExecuteNonQuery();
                  sqlveri_cek();
                  MessageBox.Show("Added!");
                  firstNameTextBox.Clear();
                  lastNameTextBox.Clear();
                  lastNameTextBox.Clear();
                  cityTextBox.Clear();
                  countryTextBox.Clear();
                  occupationTextBox.Clear();
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.ToString());
              }

              _conn.Close();
          }

          private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
          {
              try
              {
                  if (_conn.State == ConnectionState.Closed)
                  {
                      _conn.Open();
                  }
                  int Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                  SqlCommand command = new SqlCommand("Delete from users where Id=@id", _conn);
                  command.Parameters.AddWithValue("@id", Id);
                  command.ExecuteNonQuery();
                  this.sqlveri_cek();
                  MessageBox.Show("Deleted!");
              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.ToString());
              }

              _conn.Close();
          }
      }*/
    }
}
