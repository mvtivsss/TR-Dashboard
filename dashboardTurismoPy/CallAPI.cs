using dashboardTurismoPy.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dashboardTurismoPy
{
    public partial class CallAPI : Form
    {
        public CallAPI()
        {
            InitializeComponent();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var response = await RestHelper.getAll();
            txtResponse.Text = RestHelper.BeautifyJson(response);
        }
    }
}
