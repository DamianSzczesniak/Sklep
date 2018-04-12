using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sklep
{
    public partial class Form1 : Form
    {
        SklepEntities sklepEntities = new SklepEntities();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            DbSet<Drukarki> drukarki = sklepEntities.Drukarki;

            String text = "zajecia";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
