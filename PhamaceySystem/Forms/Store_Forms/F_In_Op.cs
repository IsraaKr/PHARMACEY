using PhamaceyDataBase;
using PhamaceyDataBase.Commander;
using PhamaceySystem.Forms.Medicin_Forms;
using PhamaceySystem.Forms.Person_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamaceySystem.Forms.Store_Forms
{
    public partial class F_In_Op : F_Master_Inheretanz
    {
        public F_In_Op()
        {
            InitializeComponent();
            Title("ادخال  مادة / In Operation");
  
        view_inheretanz_butomes(true, false, false, false, false, false, false);
    }
        public F_In_Op( int op_id)
        {
            id_toUpdate = op_id;
            InitializeComponent();
            Title("ادخال  مادة / In Operation");

            view_inheretanz_butomes(true, true, false, false, false, false, false);
        }
        ClsCommander<T_Medician> cmdMedician = new ClsCommander<T_Medician>();
        ClsCommander<T_Pers_Emploee> cmdEmp = new ClsCommander<T_Pers_Emploee>();
        ClsCommander<T_Pers_Donars> cmdDonars = new ClsCommander<T_Pers_Donars>();
        ClsCommander<T_Med_Storage_Shape> cmdStorageShape = new ClsCommander<T_Med_Storage_Shape>();
        ClsCommander<T_OPeration_IN> cmdOpIn = new ClsCommander<T_OPeration_IN>();
        ClsCommander<T_OPeration_IN_Item> cmdOpInItem = new ClsCommander<T_OPeration_IN_Item>();

        T_OPeration_IN TF_OP_IN;
        T_OPeration_IN_Item TF_OP_IN_Item;
        int is_op_insert = 0;
        DateTime d = DateTime.Today;
        int id_toUpdate = 0;

        public override void Get_Data(string status_mess)
    {
        try
        {
            clear_data(this.Controls);

            cmdMedician = new ClsCommander<T_Medician>();
              cmdMedician = new ClsCommander<T_Medician>();
              cmdEmp = new ClsCommander<T_Pers_Emploee>();
            cmdDonars = new ClsCommander<T_Pers_Donars>();
              cmdStorageShape = new ClsCommander<T_Med_Storage_Shape>();
             cmdOpIn = new ClsCommander<T_OPeration_IN>();
            cmdOpInItem = new ClsCommander<T_OPeration_IN_Item>();

               GetStorageShape_Data();
               GetDonars_Data();
               GetEmp_Data();
               GetMed_Data();
                is_op_insert = 0;

                Set_Auto_Id_item();
                Set_Auto_Id_op();

                if (id_toUpdate != 0)
                {
                    TF_OP_IN = new T_OPeration_IN();
                    TF_OP_IN = cmdOpIn.Get_By(i => i.in_op_id == id_toUpdate).FirstOrDefault();

                    Fill_Controls_op();
                    Fill_Graid_item();
                }
                base.Get_Data(status_mess);

        }
        catch (Exception ex)
        {
            Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
        }

    }
    public override void Insert_Data()
    {
        try
        {
                if (id_toUpdate == 0)
                {
                    if (is_op_insert == 0 && Validate_Data_op())
                        insert_op();

                    if (Validate_Data_item())
                        insert_item();
                }
                else
                {
                    Fill_Entitey_op();
                    cmdOpIn.Update_Data(TF_OP_IN);
                    base.Update_Data();
                    Get_Data("u");
                }

            
                clear_data(this.Controls);
            
        }
        catch (Exception ex)
        {
            Get_Data(ex.InnerException.InnerException.ToString());
        }
    }

    public override void clear_data(Control.ControlCollection s_controls)
    {
        base.clear_data(s_controls);
       // Set_Auto_Id();
    }
        public override void neew()
        {
            base.neew();
            Get_Data("");
            Set_Auto_Id_op();
            Set_Auto_Id_item();
           
        }
        public  bool Validate_Data_op()
    {
        int number_of_errores = 0;
            number_of_errores += in_op_idTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += donar_empTextEdit.is_text_valid() ? 0 : 1;

            if (donar_idSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                donar_idSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }
            if (emp_idSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                emp_idSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
    }
        public void Fill_Entitey_op()
        {
            // TF_OP_IN.med_id = Convert.ToInt32(med_idTextEdit.Text)
            TF_OP_IN.in_op_date = Convert.ToDateTime(in_op_dateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            //TF_OP_IN.in_op_time = Convert.ToDateTime(TimeSpan..ToString("yyyy/MM/dd"));
            //TF_OP_IN.in_op_time = in_op_timeTimeSpanEdit.EditValue
            TF_OP_IN.in_op_text = in_op_textTextEdit.Text;
            TF_OP_IN.in_op_state = Convert.ToBoolean(in_op_stateCheckEdit.CheckState);
            TF_OP_IN.in_op_recipt_no = Convert.ToInt32("1");//in_op_recipt_noTextEdit.Text);
            TF_OP_IN.in_op_recipt_name = in_op_recipt_nameTextEdit.Text;
            TF_OP_IN.in_op_recipt_date = Convert.ToDateTime(in_op_recipt_dateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_OP_IN.donar_emp = donar_empTextEdit.Text;
            TF_OP_IN.donar_id = Convert.ToInt32(donar_idSearchLookUpEdit.EditValue);
            TF_OP_IN.emp_id = Convert.ToInt32(emp_idSearchLookUpEdit.EditValue);
            TF_OP_IN.op_type_id = Convert.ToInt32("1");

        }
        public void Fill_Controls_op()
        {
            in_op_idTextEdit.Text = TF_OP_IN.in_op_id.ToString();
           in_op_dateDateEdit.DateTime = Convert.ToDateTime(TF_OP_IN.in_op_date);
            //    in_op_timeTimeSpanEdit.Text = TF_OP_IN.in_op_time;
            in_op_stateCheckEdit.Checked = Convert.ToBoolean(TF_OP_IN.in_op_state);
            in_op_recipt_noTextEdit.Text = TF_OP_IN.in_op_recipt_no.ToString();
            in_op_recipt_nameTextEdit.Text = TF_OP_IN.in_op_recipt_name;
            in_op_recipt_dateDateEdit.DateTime = Convert.ToDateTime(TF_OP_IN.in_op_recipt_date);


            donar_empTextEdit.Text = TF_OP_IN.donar_emp;

            donar_idSearchLookUpEdit.EditValue = TF_OP_IN.donar_id;
            emp_idSearchLookUpEdit.EditValue = TF_OP_IN.emp_id;

        }
        public void insert_op()
        {
            var check = cmdOpIn.Get_All().Where(x => x.in_op_id == Convert.ToInt32(in_op_idTextEdit.Text)).FirstOrDefault();
            if (check == null)
            {
                is_op_insert = 1;
                TF_OP_IN = new T_OPeration_IN();
                Fill_Entitey_op();
                cmdOpIn.Insert_Data(TF_OP_IN);
                //base.Insert_Data();
                //Get_Data("i");
            }
        }
        private void Set_Auto_Id_op()
        {
            var max_id = cmdOpIn.Get_All().Where(c_id => c_id.in_op_id ==
                         cmdOpIn.Get_All().Max(max => max.in_op_id)).FirstOrDefault();
            in_op_idTextEdit.Text = max_id == null ? "1" : (max_id.in_op_id + 1).ToString();
        }


        public bool Validate_Data_item()
        {
            int number_of_errores = 0;
            number_of_errores += in_item_idTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += in_item_quntityTextEdit.is_text_valid() ? 0 : 1;

            if (Med_idSearchlookupEdit.EditValue == null)
            {
                number_of_errores += 1;
                Med_idSearchlookupEdit.ErrorText = "هذا الحقل مطلوب";
            }
            if (med_storage_shape_idSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                donar_idSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }
        public void Fill_Entitey_item()
        {
            TF_OP_IN_Item.in_item_quntity = Convert.ToInt32(in_item_quntityTextEdit.Text);
            TF_OP_IN_Item.in_item_proDate = Convert.ToDateTime(in_item_proDateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_OP_IN_Item.in_item_expDate = Convert.ToDateTime(in_item_expDateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_OP_IN_Item.in_B_It_state = Convert.ToBoolean(in_B_It_stateCheckEdit.CheckState);
            TF_OP_IN_Item.in_B_It_note = in_B_It_noteMemoEdit.Text;
            TF_OP_IN_Item.Med_id = Convert.ToInt32(Med_idSearchlookupEdit.EditValue);
            TF_OP_IN_Item.med_storage_shape_id = Convert.ToInt32(med_storage_shape_idSearchLookUpEdit.EditValue);
            TF_OP_IN_Item.In_op_id = Convert.ToInt32(in_op_idTextEdit.Text);
        
        }
        public void insert_item()
        {
             TF_OP_IN_Item = new T_OPeration_IN_Item();
             Fill_Entitey_item();
             cmdOpInItem.Insert_Data(TF_OP_IN_Item);
             //base.Insert_Data();
             //Get_Data("i");
        }
        private void Set_Auto_Id_item()
        {
            var max_id = cmdOpInItem.Get_All().Where(c_id => c_id.in_item_id ==
                         cmdOpInItem.Get_All().Max(max => max.in_item_id)).FirstOrDefault();
            in_item_idTextEdit.Text = max_id == null ? "1" : (max_id.in_item_id + 1).ToString();
        }
        private void Fill_Graid_item()
        {
            int id = Convert.ToInt32(in_op_idTextEdit.Text);
            //var data_source  = (from item in cmdOpInItem.Get_All().Where(x => x.in_op_id == id)
            //            
            //                    select new
            //               {
            //                   id = item.in_item_id,
            //                        med_idd = ,
            //                        name = ,
            //                        quntiti = item.in_item_quntity,
            //                   prodate = item.in_item_proDate,
            //                   expdate= item.in_item_expDate,
            //                        storage_shape_id = item.T_Med_Storage_Shape.med_stor_shape_id,
            //                        storage_shape = item.T_Med_Storage_Shape.med_stor_shape_name,
            //                         inop_id =item.
            //                    }).OrderBy(l_id => l_id.id).ToList();
            //  if (data_source != null && data_source.Count() > 0)

            DataTable data_source = c_db.select(@"SELECT        dbo.T_OPeration_IN_Item.in_item_id,
                                                        dbo.T_Medician.med_id,
                                                    dbo.T_Medician.med_code,
                                                   dbo.T_Medician.med_name,
                                                    dbo.T_OPeration_IN_Item.in_item_quntity, 
                         dbo.T_OPeration_IN_Item.in_item_proDate,
                         dbo.T_OPeration_IN_Item.in_item_expDate,
                       dbo.T_Med_Storage_Shape.med_stor_shape_id, 
                         dbo.T_Med_Storage_Shape.med_stor_shape_name, 
                           dbo.T_OPeration_IN_Item.In_op_id
FROM            dbo.T_OPeration_IN_Item INNER JOIN
                         dbo.T_Med_Storage_Shape ON dbo.T_OPeration_IN_Item.med_storage_shape_id = dbo.T_Med_Storage_Shape.med_stor_shape_id INNER JOIN
                         dbo.T_Medician ON dbo.T_OPeration_IN_Item.Med_id = dbo.T_Medician.med_id
WHERE        (dbo.T_OPeration_IN_Item.In_op_id = "+id+")");
            if (data_source != null && data_source.Rows.Count > 0)
            {
                gc.DataSource = data_source;

                gv.Columns[0].Visible = false;
                gv.Columns[1].Visible = false;
                gv.Columns[2].Caption = "كود الدواء";
                gv.Columns[3].Caption = "اسم الدواء";

                gv.Columns[4].Caption = "الكمية";
                gv.Columns[5].Caption = "تاريخ الانتاج";
                gv.Columns[6].Caption = "تاريخ الانتهاء ";
                gv.Columns[7].Visible = false;
                gv.Columns[8].Caption = "شكل التخزين ";
                gv.Columns[9].Visible = false;
                gv.BestFitColumns();
            }
        }

        private void clear_item()
        {
            med_storage_shape_idSearchLookUpEdit.EditValue = null;
            med_storage_shape_idSearchLookUpEdit.Text = "";
            in_item_quntityTextEdit.Text = string.Empty;
            Med_idSearchlookupEdit.EditValue = null;
            Med_idSearchlookupEdit.Text = "";
            //in_item_expDateDateEdit.Text = "";
            //in_item_proDateDateEdit.Text = "";
        }



        public void GetStorageShape_Data()
        {
            var shape_list = (from Emp in cmdStorageShape.Get_All()
                              select new
                              {
                                  id = Emp.med_stor_shape_id,
                                  name = Emp.med_stor_shape_name
                              }).OrderBy(id => id.id);
            if (shape_list != null && shape_list.Count() > 0)
            {
                med_storage_shape_idSearchLookUpEdit.slkp_iniatalize_data(shape_list, "name", "id");
                med_storage_shape_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                med_storage_shape_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }
        }
        public void GetEmp_Data()
        {
            var emp_list = (from Emp in cmdEmp.Get_All()
                            select new
                            {
                                id = Emp.Emp_id,
                                name = Emp.Emp_name
                            }).OrderBy(id => id.id);
            if (emp_list != null && emp_list.Count() > 0)
            {
                //     emp_idSearchLookUpEdit.Properties.DataSource = emp_list;
                emp_idSearchLookUpEdit.slkp_iniatalize_data(emp_list, "name", "id");
                emp_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                emp_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }
        }
        public void GetDonars_Data()
        {
            var Donar_list = (from Emp in cmdDonars.Get_All()
                              select new
                              {
                                  id = Emp.Donar_id,
                                  name = Emp.Donar_name
                              }).OrderBy(id => id.id);
            if (Donar_list != null && Donar_list.Count() > 0)
            {
                //     emp_idSearchLookUpEdit.Properties.DataSource = emp_list;
                donar_idSearchLookUpEdit.slkp_iniatalize_data(Donar_list, "name", "id");
                donar_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                donar_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }

        }
        public void GetMed_Data()
    {

        var med_list = (from Emp in cmdMedician.Get_All()
                          select new
                          {
                              id = Emp.med_id,
                              name = Emp.med_name
                          }).OrderBy(id => id.id);
        if (med_list != null && med_list.Count() > 0)
        {
            Med_idSearchlookupEdit.slkp_iniatalize_data(med_list, "name", "id");
                Med_idSearchlookupEdit.Properties.View.Columns[0].Caption = "الرقم";
                Med_idSearchlookupEdit.Properties.View.Columns[1].Caption = "الاسم ";
        }

    }
   
 
        private void btn_add_donar_Click(object sender, EventArgs e)
        {
            F_Donars f = new F_Donars();
            f.ShowDialog();
     
            GetDonars_Data();

        }
        private void btn_add_emp_Click(object sender, EventArgs e)
        {
            F_Emp f = new F_Emp();
            f.ShowDialog();
 
            GetEmp_Data();
     
        }
        private void btn_add_med_Click(object sender, EventArgs e)
        {
            F_Med  f = new F_Med();
            f.ShowDialog();

            GetMed_Data();
        }
        private void btn_add_store_shape_Click(object sender, EventArgs e)
        {
            F_Store_shape f = new F_Store_shape();
            f.ShowDialog();
            GetStorageShape_Data();
     
        }



        private void Med_idSearchlookupEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdMedician.Get_By(id => id.med_id == e_id).FirstOrDefault().med_name;
            }
            else
                e.DisplayText = "";
        }
        private void med_storage_shape_idSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdStorageShape.Get_By(id => id.med_stor_shape_id == e_id).FirstOrDefault().med_stor_shape_name;
            }
            else
                e.DisplayText = "";
        }      
        private void donar_idSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdDonars.Get_By(id => id.Donar_id == e_id).FirstOrDefault().Donar_name;
            }
            else
                e.DisplayText = "";
        }
        private void emp_idSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdEmp.Get_By(id => id.Emp_id == e_id).FirstOrDefault().Emp_name;
            }
            else
                e.DisplayText = "";
        }

        private void btn_add_item_Click(object sender, EventArgs e)
        {
            Insert_Data();
            Fill_Graid_item();
            clear_item();
        }

        private void gv_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
