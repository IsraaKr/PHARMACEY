﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhamaceySystem
{
    class c_db
    {
        //public static SqlConnection con;
        public static SqlCommand comnd;
        public static SqlDataReader dr;
        //  public static SqlDataAdapter da;
        public static DataTable dt;
        public static int done;

        public static SqlConnection _Con;
        public static SqlConnection con  //عند كل استخدام ل كون نستخدم التابع و ليس الخاصية
        {
            get
            {
                if (_Con.State != ConnectionState.Open)
                    _Con.Open();
                return _Con;
            }
            set
            {
                _Con = value;
            }
        }
        //جلب اسم السيرفر
        public static string get_server_name()
        {
            string server_name = "";
            var registaryviewarray = new[] { RegistryView.Registry32, RegistryView.Registry64 };
            foreach (var registryview in registaryviewarray)
            {
                using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryview))
                using (var key = hklm.OpenSubKey(@"software\microsoft\microsoft sql server"))
                {
                    var instances = (string[])key?.GetValue("InstalledInstances");
                    if (instances != null)
                        foreach (var element in instances)
                            if (element == "MSSQLSERVER")
                                server_name = System.Environment.MachineName;
                            else
                                server_name = System.Environment.MachineName + @"\" + element;
                }
            }
            return server_name;
        }
        //الاتصال بالقاعدة
        public static void server_connection(string ser_name)
        {
            con = new SqlConnection(@"Data Source=" + ser_name + "; Integrated Security=true;");
        }
        //إنشاء قاعدة البيانات
        public static void create_DB(string db_name)
        {
            comnd = new SqlCommand("create database " + db_name, con);
            comnd.ExecuteNonQuery();

        }
        //الاتصال بقاعدة البيانات
        public static void db_conection(string server_name, string db_name)
        {
            con = new SqlConnection(@"Data Source=" + server_name + "; Initial Catalog=" + db_name + "; Integrated Security=true;");
        }
        //select
        public static DataTable select(string sql)
        {
            comnd = new SqlCommand(sql, con);
            dr = comnd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dr.Close();
            return dt;
        }
        //insert_upadte_delete
        public static int insert_upadte_delete(string sql)
        {
            done = 0;
            comnd = new SqlCommand(sql, con);
            done = comnd.ExecuteNonQuery();
            return done;
        }
        //max id
        public static string max(string sql)
        {
            dr.Close();
            int x = 0;
            comnd = new SqlCommand(sql, con);
            dr = comnd.ExecuteReader();
            while (dr.Read())
            {
                if (x < Int32.Parse(dr[0].ToString()))
                    x = Int32.Parse(dr[0].ToString());
            }

            dr.Close();
            return x.ToString();
        }
       

    }
}