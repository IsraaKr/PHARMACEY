using PhamaceyDataBase.Commander;
using PhamaceyDataBase;
using PhamaceySystem.Forms.Medicin_Forms;
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

namespace PhamaceySystem.Forms
{
    public partial class F_Medecian : F_Master_Add_Update

    {
        public F_Medecian()
        {
            InitializeComponent();
            Title( "Define Material , تعريف مادة ");
        }
        public override void Title(string s_title)
        {
            base.Title(s_title);
        }
        ClsCommander<T_Medician> cmdMedician = new ClsCommander<T_Medician>();
        ClsCommander<T_Med_Category> cmdMedCategoreyes = new ClsCommander<T_Med_Category>();
        ClsCommander<T_Med_Shape> cmdMedShape = new ClsCommander<T_Med_Shape>();

        T_Medician TF_Medician;
        Boolean Is_Double_Click = false;
        public override void Get_Data(string status_mess)
        {
            if (TF_Medician != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    cmdMedician = new ClsCommander<T_Medician>();

                  //  Fill_Graid();

                    GetCat_Data();
                    GetShape_Data();
                    base.Get_Data(status_mess);

                }
                catch (Exception ex)
                {
                    Get_Data(ex.InnerException.InnerException.ToString() + "/" + ex.Message);
                }
            }
        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Medician = new T_Medician();
                    Fill_Entitey();
                    cmdMedician.Insert_Data(TF_Medician);
                    base.Insert_Data();
                    Get_Data("i");
                }

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
        }
        public override void Update_Data()
        {
            try
            {
                if (Is_Double_Click)
                {
                    if (Validate_Data() &&/* gv.RowCount > 0 &&*/ TF_Medician != null)
                    {
                        Fill_Entitey();
                        cmdMedician.Update_Data(TF_Medician);
                        base.Update_Data();
                        Get_Data("u");
                    }
                }
                else
                    C_Master.Warning_Massege_Box("الرجاء اختيار عنصر لتعديله");

            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }


        }
        public override void Delete_Data()
        {
            try
            {
                if (Is_Double_Click)
                {
                    //if (C_Master.Qustion_Massege_Box(C_Master.mas_del) == DialogResult.Yes)
                    //{
                    //    if (gv.RowCount > 0)
                    //    {
                    //        foreach (int row_id in gv.GetSelectedRows())
                    //        {
                    //            Get_Row_ID(row_id);
                    //            cmdMedician.Delet_Data(TF_Medician);

                    //        }
                    //        base.Delete_Data();
                    //        Get_Data("d");
                    //    }
//
                }
                else
                        C_Master.Warning_Massege_Box("الرجاء اختيار عنصر من الجدول لحذفه");
                
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
        }
        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(s_controls);
            Set_Auto_Id();
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;
            number_of_errores += med_idTextEdit.is_text_valid() ? 0 : 1;
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
            TF_Medician.med_id = Convert.ToInt32(med_idTextEdit.Text);
            TF_Medician.med_code = med_codeTextEdit.Text;
            TF_Medician.med_name = med_nameTextEdit.Text;
           // TF_Medician.med_date = Convert.ToDateTime(med_DateDateEdit.DateTime.ToString("yyyy/MM/dd"));
            TF_Medician.med_minimum = Convert.ToInt32(med_minimumTextEdit.Text);
            TF_Medician.med_state = Convert.ToBoolean(med_stateCheckEdit.CheckState);
            TF_Medician.med_note = med_noteTextEdit.Text;
            TF_Medician.med_cat_id = Convert.ToInt32(med_cat_idSearchLookUpEdit.EditValue);
            TF_Medician.med_shape_id = Convert.ToInt32(med_shape_idSearchLookUpEdit.EditValue);

        }
       
        public void GetCat_Data()
        {
            var Cat_List = (from Cat in cmdMedCategoreyes.Get_All()
                            select new
                            {
                                id = Cat.med_cat_id,
                                name = Cat.med_cat_name ,
                            }).OrderBy(id => id.id);
            if (Cat_List != null && Cat_List.Count() > 0)
            {
                med_cat_idSearchLookUpEdit.slkp_iniatalize_data(Cat_List, "name", "id");
                med_cat_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                med_cat_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }

        }
        public void GetShape_Data()
        {
            var shape_List = (from shape in cmdMedShape.Get_All()
                            select new
                            {
                                id = shape.med_shape_id,
                                name = shape.med_shape_name
                            }).OrderBy(id => id.id);
            if (shape_List != null && shape_List.Count() > 0)
            {
                med_shape_idSearchLookUpEdit.slkp_iniatalize_data(shape_List, "name", "id");
                med_shape_idSearchLookUpEdit.Properties.View.Columns[0].Caption = "الرقم";
                med_shape_idSearchLookUpEdit.Properties.View.Columns[1].Caption = "الاسم ";
            }

        }
        private void Set_Auto_Id()
        {
            var max_id = cmdMedician.Get_All().Where(c_id => c_id.med_id == cmdMedician.Get_All().Max(max => max.med_id)).FirstOrDefault();
            med_idTextEdit.Text = max_id == null ? "1" : (max_id.med_id + 1).ToString();
            // Cat_Mp_CodeTextEdit.Text = Cat_Mp_IdTextEdit.Text;
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
                e.DisplayText = cmdMedCategoreyes.Get_By(id => id.med_cat_id == e_id).FirstOrDefault().med_cat_name;
            }
            else
                e.DisplayText = "";
        }
    }
}
