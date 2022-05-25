using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformModbus.Forms
{
    public partial class FormOptimization : Form
    {
        private static FormOptimization instance;
        public static FormOptimization getInstance()
        {
            if (instance == null)
                instance = new FormOptimization();
            return instance;
        }
        public FormOptimization()
        {
            InitializeComponent();
        }
    }
}
