using Controller.Logic;
using Controller.Models;
using Models.Models;
using Models.VehiclesList;
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
    public partial class FormAddWorker : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        private readonly VehicleLogic vehicleLogic = new VehicleLogic();
        private readonly WorkerLogic workerLogic=new WorkerLogic();
        public FormAddWorker(int id)
        {
            if (id != 0)
                this.id = id;
            InitializeComponent();
        }

        private void FormAddWorker_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            List<VehicleModel> list = vehicleLogic.Read(null);
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
            comboBox1.DataSource = list;
            comboBox1.SelectedItem = null;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.Cancel;
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(maskedTextBoxName.Text) && string.IsNullOrEmpty(maskedTextBoxSurName.Text))
            {
                MessageBox.Show("Заполните строки", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                workerLogic.CreateOrUpdate(new WorkerModel
                {
                    Id = id,
                    Name = maskedTextBoxName.Text,
                    Surname = maskedTextBoxSurName.Text,
                    VehicleId = vehicleLogic.ReadById(comboBox1.SelectedIndex+1).Id,
                    IsFree=true
                });
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                DialogResult = DialogResult.Cancel;
            }
            Close();
        }
    }
}
