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
    public partial class F_Medecian : F_Master_Inheretanz
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
        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
