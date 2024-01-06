using PhamaceyDataBase;
using PhamaceyDataBase.Commander;
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
    public partial class F_Store_Place : F_Master_List
    {
        public F_Store_Place()
        {
            InitializeComponent();
            Title("Storage Shape ,  شكل التخزين ");
            txt.Text = "اسم الشكل ";
        }


        ClsCommander<T_Med_Storage_Shape> cmdStoreShape = new ClsCommander<T_Med_Storage_Shape>();
        T_Med_Storage_Shape TF_Storage_Shape;
        Boolean Is_Double_Click = false;

        public override void Title(string s_title)
        {
            base.Title(s_title);
        }
        public override void Get_Data(string status_mess)
        {
            //if (TF_Storage_Shape != null)
            //{
            try
            {
                clear_data(this.Controls);
                Is_Double_Click = false;
                cmdStoreShape = new ClsCommander<T_Med_Storage_Shape>();
                TF_Storage_Shape = cmdStoreShape.Get_All().FirstOrDefault();
                if (TF_Storage_Shape!=null)
                Fill_Graid();

                base.Get_Data(status_mess);
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }
       
        }
        public override void Insert_Data()
        {
            try
            {
                if (Validate_Data())
                {
                    TF_Storage_Shape = new T_Med_Storage_Shape();
                    Fill_Entitey();
                    cmdStoreShape.Insert_Data(TF_Storage_Shape);
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
                    if (Validate_Data() && gv.RowCount > 0 && TF_Storage_Shape != null)
                    {

                        Fill_Entitey();
                        cmdStoreShape.Update_Data(TF_Storage_Shape);
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
                    if (C_Master.Qustion_Massege_Box(C_Master.mas_del) == DialogResult.Yes)
                    {
                        if (gv.RowCount > 0)
                            foreach (int row_id in gv.GetSelectedRows())
                            {
                                Get_Row_ID(row_id);
                                cmdStoreShape.Delet_Data(TF_Storage_Shape);
                            }
                        base.Delete_Data();
                        Get_Data("d");

                    }
                }
                else
                    C_Master.Warning_Massege_Box("  بالضغط مرتين يجب اختيار عنصر من الجدول لحذفه");
            }
            catch (Exception ex)
            {
                Get_Data(ex.InnerException.InnerException.ToString());
            }

        }

        public override bool Validate_Data()
        {
            int number_of_errores = 0;

            number_of_errores += txt_name.is_text_valid() ? 0 : 1;
            number_of_errores += txt_id.is_text_valid() ? 0 : 1;
            return (number_of_errores == 0);

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
        public void Fill_Controls()
        {
            txt_id.Text = TF_Storage_Shape.med_stor_shape_id.ToString();
            txt_name.Text = TF_Storage_Shape.med_stor_shape_name;

        }
        public void Fill_Entitey()
        {
            //  TF_Storage_Shape.med_cat_id = Convert.ToInt32(txt_id.Text);

            TF_Storage_Shape.med_stor_shape_name = txt_name.Text.Trim();


        }
        private void Fill_Graid()
        {
            Object x = new object();
            x = (from Emp_s in cmdStoreShape.Get_All()
                 select new
                 {
                     id = Emp_s.med_stor_shape_id,
                     name = Emp_s.med_stor_shape_name,
                 }).OrderBy(c_id => c_id.name);
            gc.DataSource = x;
            gv.Columns["id"].Visible = false;
            gv.Columns["name"].Caption = "اسم الشكل";
            gv.BestFitColumns();
        }
        private void Set_Auto_Id()
        {
            var Max_Id = cmdStoreShape.Get_All().Where(c_id => c_id.med_stor_shape_id
                                 == cmdStoreShape.Get_All().Max(max => max.med_stor_shape_id)).FirstOrDefault();
            txt_id.Text = Max_Id == null ? "1" : (Max_Id.med_stor_shape_id + 1).ToString();


        }
        private void Get_Row_ID(int Row_Id)
        {
            long id;
            if (Row_Id != 0)
            {
                id = Convert.ToInt64(gv.GetRowCellValue(Row_Id, gv.Columns[0]));
                TF_Storage_Shape = cmdStoreShape.Get_By(c_id => c_id.med_stor_shape_id == id).FirstOrDefault();
            }
            else
            {
                id = Convert.ToInt64(gv.GetRowCellValue(gv.FocusedRowHandle, gv.Columns[0]));
                TF_Storage_Shape = cmdStoreShape.Get_By(c_id => c_id.med_stor_shape_id == id).FirstOrDefault();
            }
        }
        public override void gv_DoubleClick(object sender, EventArgs e)
        {
            Is_Double_Click = true;
            gv.SelectRow(gv.FocusedRowHandle);
            Get_Row_ID(0);
            if (TF_Storage_Shape != null)
                Fill_Controls();
        }
        public override void gv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete && gv.RowCount > 0)
                Delete_Data();
        }

        public override void gv_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            Is_Double_Click = true;
        }
    }
}
