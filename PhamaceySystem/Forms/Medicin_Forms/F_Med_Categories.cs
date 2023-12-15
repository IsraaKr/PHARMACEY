using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhamaceyDataBase;
using PhamaceyDataBase.Commander;

namespace PhamaceySystem.Forms.Medicin_Forms
{
    public partial class F_Med_Categories : F_Master_ADD
    {
        public F_Med_Categories()
        {
            InitializeComponent();
            Title("Categoreys , تصنيفات الدواء ");
        }

        ClsCommander<T_Med_Category> cmdMedCat = new ClsCommander<T_Med_Category>();
        T_Med_Category TF_Med_Cat;
        Boolean Is_Double_Click = false;

        public override void Title(string s_title)
        {
            base.Title(s_title);
        }
        public override void Get_Data(string status_mess)
        {
            if (TF_Med_Cat != null)
            {
                try
                {
                    clear_data(this.Controls);
                    Is_Double_Click = false;
                    //cmdMedCat = new ClsCommander<T_Employee_State>();
                    TF_Med_Cat = cmdMedCat.Get_All().FirstOrDefault();
                    Fill_Graid();

                    base.Get_Data(status_mess);
                }
                catch (Exception ex)
                {
                    Get_Data(ex.InnerException.InnerException.ToString());
                }
            }
        }

        //private void Set_Auto_Id()
        //{
        //    var Max_Id = cmdMedCat.Get_All().Where(c_id => c_id.med_cat_id == cmdMedCat.Get_All().Max(max => max.Emp_St_Id)).FirstOrDefault();
        //    .Text = Max_Id == null ? "1" : (Max_Id.Emp_St_Id + 1).ToString();

        //    Emp_St_CodeTextEdit.Text = Emp_St_IdTextEdit.Text;

        //}

        public override bool Validate_Data()
        {
            int number_of_errores = 0;

            //        number_of_errores += lkp_state.is_editevalue_valid() ? 0 : 1;

            number_of_errores += txt_addd.is_text_valid() ? 0 : 1;
           // number_of_errores += Emp_St_IdTextEdit.is_text_valid() ? 0 : 1;
            return (number_of_errores == 0);

        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Med_Cat = new T_Med_Category();
                    //if (TF_Med_Cat != null)
                    Fill_Entitey();
                    cmdMedCat.Insert_Data(TF_Med_Cat);
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
                    if (Validate_Data() && gv.RowCount > 0)
                    {
                        long id = Convert.ToInt64(txt_id.Text);
                        TF_Med_Cat = cmdMedCat.Get_By(c_id => c_id.med_cat_id == id).FirstOrDefault();
                        if (TF_Med_Cat != null)
                            Fill_Entitey();
                        base.Update_Data();
                        Get_Data("u");
                    }
                }
                else
                    C_Master.Warning_Massege_Box("يجب اختيار عنصر من الجدول لتعديله");
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
                    if (C_Master.Qustion_Massege_Box("هل أنت متأكد أنك تريد الحذف") == DialogResult.Yes)
                    {
                        if (gv.RowCount > 0)
                            foreach (int row_id in gv.GetSelectedRows())
                            {
                                long id = Convert.ToInt64(gv.GetRowCellValue(row_id, gv.Columns["id"]));
                                TF_Med_Cat = cmdMedCat.Get_By(c_id => c_id.med_cat_id == id).FirstOrDefault();
                                cmdMedCat.Delet_Data(TF_Med_Cat);
                            }
                        base.Delete_Data();
                        Get_Data("d");

                    }
                }
                else
                    C_Master.Warning_Massege_Box(" يجب اختيار عنصر من الجدول لحذفه");
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }

        }


        public override void clear_data(Control.ControlCollection s_controls)
        {
            base.clear_data(s_controls);
         //   Set_Auto_Id();
        }
        public override void Print_Data()
        {
            base.Print_Data();
        }
        public void Fill_Controls()
        {
            txt_id.Text = TF_Med_Cat.med_cat_id.ToString();
            txt_addd.Text = TF_Med_Cat.med_cat_name;

        }
        public void Fill_Entitey()
        {
            TF_Med_Cat.med_cat_id = Convert.ToInt32(txt_id.Text);

            TF_Med_Cat.med_cat_name = txt_addd.Text.Trim();
        

        }
        private void Fill_Graid()
        {
            gc.DataSource = (from Emp_s in cmdMedCat.Get_All()
                             select new
                             {
                                 id = Emp_s.med_cat_id,
                                 name = Emp_s.med_cat_name,               
                             }).OrderBy(c_id => c_id.id).ToList();

            gv.Columns["id"].Caption = "الرقم";
            gv.Columns["name"].Caption = "اسم التصنيف";


            gv.BestFitColumns();
        }
       public  override void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);
            long id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns["id"]));
            TF_Med_Cat = cmdMedCat.Get_By(c_id => c_id.med_cat_id == id).FirstOrDefault();

            Fill_Controls();
        }
        public override void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }

        private void gv_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Is_Double_Click = true;
        }
    }
}
