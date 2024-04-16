using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChineseDamsTest
{
    public partial class Statistics : UserControl
    {
        public Statistics()
        {
            InitializeComponent();
            //Anchor = (AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Bottom);
            this.locBox.SelectedIndex = 0;
            this.classBox.SelectedIndex = 0;
        }

        //封装一个创建SQL查询语句的方法
        public string CreateSQL(string locValue,string classValue,string queryclass)
        {
            string c;
            if (classValue == "非流水坝") c = "0";
            else c = "1";

            if (queryclass == "num") queryclass = "COUNT(*)";
            else if (queryclass == "crd") queryclass = "LAT,LON";

            string sql="-1";  //初始化sql语句

            if (locValue == "所有" && classValue == "所有")
            {
                sql = "SELECT "+queryclass +" FROM DAMS_TEST";
            }
            else if (locValue != "所有" && classValue == "所有")
            {
                sql = "SELECT "+queryclass+" FROM DAMS_TEST " +
                    "WHERE LOCATION='" + locValue + "'";
            }
            else if (locValue == "所有" && classValue != "所有")
            {
                sql = "SELECT "+queryclass+" FROM DAMS_TEST " +
                    "WHERE DAM_CLASS='" + c + "'";
            }
            else if (locValue != "所有" && classValue != "所有")
            {
                sql = "SELECT " +queryclass+ " FROM DAMS_TEST " +
                    "WHERE DAM_CLASS='" + c + "' AND " +
                    "LOCATION='" + locValue + "'";
            }

            return sql;
        }

        private void staticNum_Click(object sender, EventArgs e)
        {
            //连接到数据库
            string conStr = "Data Source=.;Initial Catalog=ChineseDamsTest;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            //创建SQL查询语句
            string sql=CreateSQL(locBox.Text, classBox.Text,"num");


            //执行查询
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            //展示
            while (rdr.Read())
            {
                string output = Convert.ToString(rdr[0]);
                MessageBox.Show("共"+output+"座","查询结果");
            }
            rdr.Close();
            conn.Close();
        }

        private void findcoordinate_Click(object sender, EventArgs e)
        {
            //连接到数据库
            string conStr = "Data Source=.;Initial Catalog=ChineseDamsTest;User ID=sa;Password=12345";
            SqlConnection conn = new SqlConnection(conStr);
            conn.Open();

            //创建查询语句
            string sql = CreateSQL(locBox.Text,classBox.Text,"crd");

            //执行查询
            SqlCommand cmd = new SqlCommand (sql, conn);
            SqlDataReader rdr = cmd.ExecuteReader();

            int i = 1;
            //展示
            while(rdr.Read())
            {
                string lat = Convert.ToString(rdr[0]);
                string lon = Convert.ToString(rdr[1]);

                if(i == 1)
                {
                    crdBox.Items.Add("   " + "纬度" + "           " + "经度"+"\n");
                }
                crdBox.Items.Add(i + "  " + lat + "  " + lon+"\n");
                i = i + 1;
            }

        }
    }
}