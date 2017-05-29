using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class KetNoiDB
    {
        public string StrConnection;
        public SqlConnection conn; //khởi tạo 1 đối tượng kết nối vs sql

        //hàm tạo kết nối với database
        public void Connect()
        {
            try
            {
                conn = new SqlConnection(StrConnection);

                {
                    conn.Open();//mở kết nối
                }

            }
            catch (SqlException e)
            {
                throw e;
            }
        }

        //hàm đóng kết nối
        public void Disconnection()
        {
            conn.Close();
        }

        //hàm lấy toàn bộ các trg trong bảng dữ liệu
        public DataTable getData(string lenhSql, SqlParameter[] param,CommandType cmdType)
        {
            DataTable dt = new DataTable();
            try
            {
                Connect();//mở kết nối

                SqlDataAdapter adapter = new SqlDataAdapter();
                //SqlDataAdapter chứa các lệnh SQL và đối tượng connection để đọc và ghi dữ liệu
                SqlCommand cmd = new SqlCommand(lenhSql,conn);
                // bạn có thể thực hiện các lệnh select, insert, modify, và delete các dòng trong một table của database
                cmd.Parameters.AddRange(param);

                if (cmdType == CommandType.Text)
                {
                    cmd.CommandType = CommandType.Text;
                }
                else if (cmdType == CommandType.StoredProcedure)
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    //thiết lập các đối tượng lện để nó biết thực hiện 1 thủ tục để lưu trữ
                }
                
                adapter.SelectCommand = cmd;

                adapter.Fill(dt);//dl vào database

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                Disconnection();
                param = null;
            }
            return dt;
        }

        public DataTable getdata(string v)
        {
            throw new NotImplementedException();
        }

        public void setList(String lenhSql, SqlParameter[] param,string[] str)//xác lập ds
        {
            try
            {

               
              
                DataRow dr = getData(lenhSql, param, CommandType.Text).Rows[0]; //datarow-dữ liệu hàg
                
                for(int i=0;i<str.Length;i++)
                   str[i]= Convert.ToString(dr[i]);



            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public void ThuTuc(string tenThuTuc, SqlParameter[] param)
        {
            
            try
            {
                Connect();//mở kết nối
                
                SqlCommand cmd = new SqlCommand(tenThuTuc,conn);
                cmd.Parameters.AddRange(param);
                cmd.CommandType = CommandType.StoredProcedure;// Khai báo kiểu thực thi là Thực thi thủ tục
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                throw e;
            }
            finally
            {
                Disconnection();
            }
        
        }
    }
}
