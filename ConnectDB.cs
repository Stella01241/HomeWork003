using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HomeWork003
{
    public class ConnectDB
    {
        #region 新增無人機fix資料表
        public static DataTable FixDataTable()
        {
            //建立資料庫字串變數
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=fix; Integrated Security=true";
            //使用的SQL語法
            string queryString = $@" SELECT * FROM FixTable_1;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉換成SQL可讀懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                //command.Parameters.AddWithValue("@NumberCol"1,2");

                try
                {
                    //開始連線
                    connection.Open();
                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();
                    //在記憶體中創新空表
                    DataTable dt = new DataTable();
                    //把值塞進空表
                    dt.Load(reader);


                    //關閉資料庫連線
                    reader.Close();
                    //回傳dt
                    return dt;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;

                }

            }
        }
        public static DataTable CreateFix(int sid, string equipment_Name, string restoration_time, string failure_date, string restoration_ferctory,
             string failure_cause, string replacement_department, string note)
        {
            //建立資料庫字串變數
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=fix; Integrated Security=true";
            //使用的SQL語法
            string queryString = $@" INSERT INTO  FixTable_1
                                        (sid, equipment_name, restoration_time, failure_date, restoration_factory, failure_cause, replacement_department,note)
                                       VALUES
                                         (@sid, @equipment_name, @restoration_time, @failure_date, @restoration_factory, @failure_cause, @replacement_department, @note)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                command.Parameters.AddWithValue("@sid", sid);
                command.Parameters.AddWithValue("@equipment_name", equipment_Name);
                command.Parameters.AddWithValue("@restoration_time", restoration_time);
                command.Parameters.AddWithValue("@failure_date", failure_date);
                command.Parameters.AddWithValue("@restoration_factory", restoration_ferctory);
                command.Parameters.AddWithValue("@failure_cause", failure_cause);
                command.Parameters.AddWithValue("@replacement_department", replacement_department);
                command.Parameters.AddWithValue("@note", note);


                try
                {
                    //開始連線
                    connection.Open();
                    //從資料庫讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();

                    dt.Load(reader);

                    reader.Close();

                    return dt;

                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    HttpContext.Current.Response.Write(ex);
                    return null;

                }
            }
        }

        #endregion

        #region 刪除無人機資料表的Method
        public static DataTable DeleteFix(int sid)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=fix; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"DELETE FROM FixTable_1 WHERE sid = @ID";
            //DELETE FROM TestTable_1 WHERE ID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@ID", sid);

                try
                {
                    //開始連線
                    connection.Open();
                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();
                    //在記憶體中創新空表
                    DataTable dt = new DataTable();
                    //把值塞進空表
                    dt.Load(reader);


                    //關閉資料庫連線
                    reader.Close();
                    //回傳dt
                    return dt;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;

                }

            }
        }
        #endregion

        #region 修改無人機資料表的Method
        public static DataTable UpdateFix(int sid, string equipment_Name, string restoration_time, string failure_date, string restoration_ferctory,
            string failure_cause, string replacement_department, string note)
        {

            //建立連線資料庫的字串變數Catalog=fix的Dr
            //one為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=fix; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@"UPDATE FixTable_1 SET equipment_name = @equipment_name, 
                 restoration_time = @restoration_time, failure_date = @failure_date, restoration_factory = @restoration_factory, 
                 failure_cause = @failure_cause, replacement_department = @replacement_department, note = @note
                  Where  sid = @sid";
            //DELETE FROM TestTable_1 WHERE ID

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);


                command.Parameters.AddWithValue("@sid", sid);
                command.Parameters.AddWithValue("@equipment_name", equipment_Name);
                command.Parameters.AddWithValue("@restoration_time", restoration_time);
                command.Parameters.AddWithValue("@failure_date", failure_date);
                command.Parameters.AddWithValue("@restoration_factory", restoration_ferctory);
                command.Parameters.AddWithValue("@failure_cause", failure_cause);
                command.Parameters.AddWithValue("@replacement_department", replacement_department);
                command.Parameters.AddWithValue("@note", note);

                try
                {
                    //開始連線
                    connection.Open();
                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();
                    //在記憶體中創新空表
                    DataTable dt = new DataTable();
                    //把值塞進空表
                    dt.Load(reader);


                    //關閉資料庫連線
                    reader.Close();
                    //回傳dt
                    return dt;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;

                }

            }
        }
        #endregion

        #region 查詢single無人機資料表的Method
        public static DataTable ReadSingleFix(int sid)
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=fix; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM FixTable_1 WHERE sid = @sid ;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.AddWithValue("@sid", sid);

                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);



                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }


            }
        }
        #endregion

        #region 查詢Allfix無人機的Method
        public static DataTable ReadAllFix()
        {

            //建立連線資料庫的字串變數Catalog=Drone的Drone為資料庫名稱
            string connectionString = "Data Source=localhost\\SQLExpress;Initial Catalog=fix; Integrated Security=true";

            //使用的SQL語法
            string queryString = $@" SELECT * FROM  FixTable_1;";

            //建立連線
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //轉譯成SQL看得懂的語法
                SqlCommand command = new SqlCommand(queryString, connection);


                try
                {
                    //開始連線
                    connection.Open();

                    //從資料庫中讀取資料
                    SqlDataReader reader = command.ExecuteReader();

                    //在記憶體中創新的空表
                    DataTable dt = new DataTable();

                    //把值塞進空表
                    dt.Load(reader);



                    //關閉資料庫連線
                    reader.Close();

                    //回傳dt
                    return dt;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return null;
                }


            }
        }
        #endregion
    }
}