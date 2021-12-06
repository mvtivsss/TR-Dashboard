using dashboardTurismoPy.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
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

        private async void graficosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var departments = await RestHelper.getAllDepartments();
            var reservations = await RestHelper.getAllReserves();
            var users = await RestHelper.getAllUsers();
            FormGraficos form = new FormGraficos();
            form.Show();

            foreach (var item in reservations)
            {
                Console.WriteLine(item.DepartmentPrice);
                //txtResponse.Text = reservations.Count().ToString();
            }

            foreach (var item in users)
            {
                Console.WriteLine(item.Rut.ToString());
                //txtResponse.Text = users.Count().ToString();
            }

            foreach (var item in departments)
            {
                //txtResponse.Text = departments.Count().ToString();
                Console.WriteLine(item.Address.ToString());
            }
        }
    }
}
