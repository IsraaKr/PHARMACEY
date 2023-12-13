using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Reflection;
using DevExpress.XtraEditors;

namespace PhamaceySystem
{
    public partial class F_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public F_Main()
        {
            InitializeComponent();
            load_first_frame();
        }

        private void load_first_frame()
        {

            //F_SOURA_GRID f = new F_SOURA_GRID();
            //nav(f, pan_nav);
           

        }

        //نستدعيه عند كل فتحة فورم جديد 
        public void nav(Form f, PanelControl p)
        {
            f.TopLevel = false;
            f.Size = p.Size;
            f.Dock = DockStyle.Fill;
            p.Controls.Clear();
            p.Controls.Add(f);
            f.Show();
        }
        //فتح الفورم عن طريق اسمه باستعمال الاسمبلي
        public void open_form_byname(string name)
        {  //الاسمبلي الذي نحنا نعمل فيه .الانواع .الاأول
            var ins = Assembly.GetExecutingAssembly().GetTypes().FirstOrDefault(x => x.Name == name);
            if (ins != null)
            {   //انشاء انستانس من التايب و ارجاعه على شكل فورم
                var frm = Activator.CreateInstance(ins) as Form;
                if (Application.OpenForms[frm.Name] != null)//التأكد إذا الفورم كان مفتوح
                {
                    //frm = Application.OpenForms[frm.Name];
                    nav(frm, pan_nav);
                }
                else
                {
                    // frm.Show();
                    nav(frm, pan_nav);
                }
                frm.BringToFront();
            }
        }
        //حدث يتم تطبيقه عند الضغط على أي المنت في الاكورديون كونترول
        private void accordionControl1_ElementClick_1(object sender, DevExpress.XtraBars.Navigation.ElementClickEventArgs e)
        {
            //نضع التاغ من الديزايننر نوع سترينغ و القيمة اسم الفورم الذي اريد فتحه
            var tag = e.Element.Tag as string;
            if (tag != string.Empty && tag != null)
            {
                open_form_byname(tag);
            }
            // e.Element.Appearance.Normal.BackColor = Color.Gray;
        }

        private void ribbon_ItemClick(object sender, ItemClickEventArgs e)
        {
            //نضع التاغ من الديزايننر نوع سترينغ و القيمة اسم الفورم الذي اريد فتحه
            var tag = e.Item.Tag as string;
            if (tag != string.Empty && tag != null)
            {
                open_form_byname(tag);
            }
        }
    }
}