using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamaceySystem.Forms.Setting_Forms
{
    public partial class F_Server_Setting : F_Master_Inheretanz
    {
        public F_Server_Setting(bool FirstStart)
        {
            InitializeComponent();
            firstStart = FirstStart;
            Set_Prop_Settings();
            txt_server.Text = c_db.get_server_name();
            txt_database.Text = "PHANACEY_DB";
            view_inheretanz_butomes(false, true, false, false, false, true, false);

        }
        public F_Server_Setting()
        {
            InitializeComponent();
        
            Set_Prop_Settings();
            txt_server.Text = c_db.get_server_name();
            txt_database.Text = "PHANACEY_DB";
            view_inheretanz_butomes(false, true, false, false, false, true, false);

        }
        private readonly bool firstStart;
        private void btn_restore_database_Click(object sender, EventArgs e)
        {

        }
    
        private void rb_local_CheckedChanged(object sender, EventArgs e)
        {
            txt_user_name.Enabled = false;
            txt_pass.Enabled = false;
            txt_time.Enabled = false;
        }

        private void rb_network_CheckedChanged(object sender, EventArgs e)
        {
            txt_user_name.Enabled = true;
            txt_pass.Enabled = true;
            txt_time.Enabled = true;
        }

        private void Save_Prop_Settings()
        {
            Properties.Settings.Default.Server_Name = txt_server.Text;
            Properties.Settings.Default.database = txt_database.Text;
            Properties.Settings.Default.username = txt_user_name.Text;
            Properties.Settings.Default.password = txt_pass.Text;
            Properties.Settings.Default.time_server = txt_time.Text;
            Properties.Settings.Default.sqript_bath = txt_sqript_bath.Text;

            // Save Settings
            Properties.Settings.Default.Save();
            MessageBox.Show("تم حفظ الاعدادات بنجاح");

        }
        private void Set_Prop_Settings()
        {
            txt_server.Text = Properties.Settings.Default.Server_Name ;
            txt_database.Text= Properties.Settings.Default.database  ;
            txt_user_name.Text= Properties.Settings.Default.username  ;
            txt_pass.Text= Properties.Settings.Default.password  ;
            txt_time.Text= Properties.Settings.Default.time_server  ;
            txt_sqript_bath.Text= Properties.Settings.Default.sqript_bath ;
        }


        public override void Insert_Data()
        {
           
            //var Server = txt_server.Text;
            //var DataBase = txt_database.Text;
            //var Timout = txt_time.Text;
            //var UserName = txt_user_name.Text;
            //var Password = txt_pass.Text;
            //if (rb_local.Checked == true)
            //{
            //    // Local Con
            //    SetLocalCon(Server, DataBase);
            //}
            //else
            //{
            //    // Network Con
            //    SetNetWorkCon(Server, DataBase, UserName, Password, Timout);
            //}
            Save_Prop_Settings();
            MessageBox.Show("تم حفظ نص الاتصال بنجاح , اعد تشغيل البرنامج لطفا");
            Application.Exit();
            base.Insert_Data();
        }



       
         private void SetNetWorkCon(string server, string dataBase, string userName, string password, String timout)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";User Id=" + userName + ";Password=" + password + ";Timeout=" + timout + "";
            Properties.Settings.Default.Server_Name = server;
            Properties.Settings.Default.database = dataBase;
            Properties.Settings.Default.username = userName;
            Properties.Settings.Default.password = password;

            //   Properties.Settings.Default.SqlServerConString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

        private void SetLocalCon(string server, string dataBase)
        {
            var ConString = @"Server=" + server + ";Database=" + dataBase + ";Trusted_Connection=True;";
            Properties.Settings.Default.Server_Name = server;
            Properties.Settings.Default.database = dataBase;

          //  Properties.Settings.Default.SqlServerConString = ConString;
            // Save Settings
            Properties.Settings.Default.Save();
        }

      
       

         private void F_Server_Setting_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (firstStart == true)
            {
                Application.Exit();
            }
        }

        private void btn_sqript_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "اختر ملف سكريبت قاعدة البيانات";
            openFileDialog.RestoreDirectory = true;
            var result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                txt_sqript_bath.Text = openFileDialog.FileName;
            }
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_server_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
