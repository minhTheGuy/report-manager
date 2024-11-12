using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SECOApp.DTO;

namespace SECOApp.GUI
{
    public partial class GiangVienHome : Form
    {
        public GiangVienHome()
        {
            InitializeComponent();

            // load sample data for testing
            LoadSampleData();
        }

        private void LoadSampleData()
        {
            // TODO: Load sample data for testing
        }

        private void DoAction(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: Implement this method
        }
    }
}
