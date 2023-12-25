﻿using PhamaceyDataBase.Commander;
using PhamaceyDataBase;
using PhamaceySystem.Inheratenz_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhamaceySystem.Forms.Store_Forms;

namespace PhamaceySystem.Forms.Medicin_Forms
{
    public partial class F_Med : F_Master_Inheretanz
    {
        public F_Med()
        {
            InitializeComponent();
            Title("تعريف مادة / Define Material");
             view_inheretanz_butomes(false,true,true, false, false, true, false);
        }
        int id_toUpdate =0;
        public F_Med( int med_id)
        {
            id_toUpdate = med_id;
       InitializeComponent();
            Title("تعريف مادة / Define Material");
            view_inheretanz_butomes(false, true, true, false, false, true, false);
        }
        ClsCommander<T_Medician> cmdMedician = new ClsCommander<T_Medician>();
        ClsCommander<T_Med_Category> cmdMedCat = new ClsCommander<T_Med_Category>();
        ClsCommander<T_Med_Shape> cmdMedShape = new ClsCommander<T_Med_Shape>();
     
        T_Medician TF_Medician;
       
        DateTime d = DateTime.Today;
        public override void Get_Data(string status_mess)
        {
            
            try
            {
                  clear_data(this.Controls);
               
                cmdMedician = new ClsCommander<T_Medician>();
                cmdMedCat = new ClsCommander<T_Med_Category>();
                cmdMedShape = new ClsCommander<T_Med_Shape>();
     
                GetCat_Data();
                GetShape_Data();
                if (id_toUpdate !=0)
                {
                    TF_Medician = new T_Medician();
                    TF_Medician = cmdMedician.Get_By(i => i.med_id == id_toUpdate).FirstOrDefault();

                    Fill_Controls();
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
                if (Validate_Data())
                {
                    if (id_toUpdate == 0)
                    {
                        TF_Medician = new T_Medician();
                        Fill_Entitey();
                        cmdMedician.Insert_Data(TF_Medician);
                        base.Insert_Data();
                        Get_Data("i");
                    }
                    else
                    {

                      Fill_Entitey();
                        cmdMedician.Update_Data(TF_Medician);
                        base.Update_Data();
                        Get_Data("u");
                    }

                    MessageBox.Show("تم الحفظ");
                    clear_data(this.Controls);
                }

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
        }

        public override void Insert_save_Data()
        {
            base.Insert_save_Data();

            F_In_Op f = new F_In_Op();
            f.ShowDialog();
        }

        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(s_controls);
            Set_Auto_Id();
        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;
            number_of_errores += med_codeTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += med_nameTextEdit.is_text_valid() ? 0 : 1;
            number_of_errores += med_minimumTextEdit.is_text_valid() ? 0 : 1;
            if (med_cat_idSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                med_cat_idSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }
            if (med_shape_idSearchLookUpEdit.EditValue == null)
            {
                number_of_errores += 1;
                med_shape_idSearchLookUpEdit.ErrorText = "هذا الحقل مطلوب";
            }

            return (number_of_errores == 0);
        }

        public void Fill_Controls()
        {
            med_idTextEdit.Text = TF_Medician.med_id.ToString();
            med_codeTextEdit.Text = TF_Medician.med_code;
            med_nameTextEdit.Text = TF_Medician.med_name;
            //med_DateDateEdit.DateTime = Convert.ToDateTime(TF_Medician.med_Date);

            med_minimumTextEdit.Text = TF_Medician.med_minimum.ToString();

            med_stateCheckEdit.Checked = Convert.ToBoolean(TF_Medician.med_state);
            med_noteTextEdit.Text = TF_Medician.med_note;

            med_cat_idSearchLookUpEdit.EditValue = TF_Medician.med_cat_id;
            med_shape_idSearchLookUpEdit.EditValue = TF_Medician.med_shape_id;

        }
        public void Fill_Entitey()
        {
            // TF_Medician.med_id = Convert.ToInt32(med_idTextEdit.Text);
            TF_Medician.med_code = med_codeTextEdit.Text;
            TF_Medician.med_name = med_nameTextEdit.Text;
            // TF_Medician.med_date = Convert.ToDateTime(med_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Medician.med_minimum = Convert.ToInt32(med_minimumTextEdit.Text);
            TF_Medician.med_state = Convert.ToBoolean(med_stateCheckEdit.CheckState);
            TF_Medician.med_note = med_noteTextEdit.Text;
            TF_Medician.med_cat_id = Convert.ToInt32(med_cat_idSearchLookUpEdit.EditValue);
            TF_Medician.med_shape_id = Convert.ToInt32(med_shape_idSearchLookUpEdit.EditValue);
            //TF_Medician.med_cat_id = Convert.ToInt32(med_nameTextEdit1.Text);
            //TF_Medician.med_shape_id = Convert.ToInt32(med_nameTextEdit2.Text);

        }


        public void GetCat_Data()
        {
            var cat_list = (from Emp in cmdMedCat.Get_All()
                            select new
                            {
                                id = Emp.med_cat_id ,
                                name = Emp.med_cat_name 
                            }).OrderBy(id => id.id);
            if (cat_list != null && cat_list.Count() > 0)
            {
               med_cat_idSearchLookUpEdit.Properties.DataSource = cat_list;
               med_cat_idSearchLookUpEdit.slkp_iniatalize_data(cat_list, "name", "id");
                med_cat_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                med_cat_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }

        }
        public void GetShape_Data()
        {
           
            var shape_list = (from Emp in cmdMedShape.Get_All()
                              select new
                              {
                                  id = Emp.med_shape_id,
                                  name = Emp.med_shape_name
                              }).OrderBy(id => id.id);
            if (shape_list != null && shape_list.Count() > 0)
            {
                med_shape_idSearchLookUpEdit.slkp_iniatalize_data(shape_list, "name", "id");
                med_shape_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                med_shape_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }

        }
        private void Set_Auto_Id()
        {
            var max_id = cmdMedician.Get_All().Where(c_id => c_id.med_id == cmdMedician.Get_All().Max(max => max.med_id)).FirstOrDefault();
            med_idTextEdit.Text = max_id == null ? "1" : (max_id.med_id + 1).ToString();
            med_codeTextEdit.Text = med_idTextEdit.Text +
                                                  DateTime.Today.Day.ToString("00") +
                                                   DateTime.Today.Month.ToString("00") +
                                                    DateTime.Today.Year.ToString();
        }



        private void med_shape_idSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdMedShape.Get_By(id => id.med_shape_id == e_id).FirstOrDefault().med_shape_name;
            }
            else
                e.DisplayText = "";
        }
  

        private void med_cat_idSearchLookUpEdit_CustomDisplayText(object sender, DevExpress.XtraEditors.Controls.CustomDisplayTextEventArgs e)
        {
            if (e.Value != null && e.Value.ToString() != string.Empty)
            {
                long e_id = Convert.ToInt64(e.Value);
                e.DisplayText = cmdMedCat.Get_By(id => id.med_cat_id == e_id).FirstOrDefault().med_cat_name;
            }
            else
                e.DisplayText = "";
        }

        private void btn_shape_Click(object sender, EventArgs e)
        {
            F_Med_Shape f = new F_Med_Shape();
            f.ShowDialog();
        }

        private void btn_cat_Click(object sender, EventArgs e)
        {
            F_Med_Categories f = new F_Med_Categories();
            f.ShowDialog();
        }
    }
}