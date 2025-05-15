using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KSM
{
    public partial class StaffInfo : Form
    {
        private Form mainForm;
        public StaffInfo(Form mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }
    }
}
