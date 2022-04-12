using Controller.Logic;
using Models.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transport_Company
{
    public partial class FormCheckCargo : Form
    {
        private readonly OrderLogic orderLogic = new OrderLogic();
        private readonly CargoLogic cargoLogic = new CargoLogic();
        public int Id { set { id = value; } }
        private int? id;
        public FormCheckCargo(int? id)
        {
            InitializeComponent();
            if(id!=null)
            {
                this.id = id;
            }
            loadData();
        }
        public void loadData()
        {
            var order = orderLogic.ReadById(id);
            var cargo = cargoLogic.ReadByOrder(order);
            dataGridView1.DataSource = cargo;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
