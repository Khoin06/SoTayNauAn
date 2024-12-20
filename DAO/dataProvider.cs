using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoTayNauAn.DAO
{
    public class dataProvider
    {
        private string con = "Data Source=DESKTOP-0FKCP5H;Initial Catalog=CookBook;User ID=sa;Password=123456 ";
        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }
        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(con))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();
                connection.Close();
            }
            return data;
        }
        public DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(con))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào câu truy vấn nếu có
                    if (parameters != null)
                    {
                        foreach (var param in parameters)
                        {
                            command.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value); // Sử dụng DBNull.Value để thay thế giá trị null
                        }
                    }

                    try
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        connection.Open();
                        adapter.Fill(dataTable);
                    }
                    catch (SqlException ex)
                    {
                        // Log lỗi hoặc xử lý ngoại lệ tại đây
                        Console.WriteLine("SQL Error: " + ex.Message);
                        throw;
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            return dataTable;
        }

        public int ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            using (SqlConnection connection = new SqlConnection(con))
            {
                SqlCommand command = new SqlCommand(query, connection);
                foreach (var param in parameters)
                {
                    command.Parameters.AddWithValue(param.Key, param.Value);
                }

                connection.Open();
                return command.ExecuteNonQuery();
            }
        }

    }
}
