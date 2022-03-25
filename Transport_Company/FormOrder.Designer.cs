namespace Transport_Company
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.maskedTextBoxName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxSurName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxCargo = new System.Windows.Forms.MaskedTextBox();
            this.buttonAddCargo = new System.Windows.Forms.Button();
            this.listBoxCargos = new System.Windows.Forms.ListBox();
            this.comboBoxWorkers = new System.Windows.Forms.ComboBox();
            this.textBoxWorkerWeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTextBoxWeight = new System.Windows.Forms.MaskedTextBox();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // maskedTextBoxName
            // 
            this.maskedTextBoxName.Location = new System.Drawing.Point(12, 46);
            this.maskedTextBoxName.Name = "maskedTextBoxName";
            this.maskedTextBoxName.Size = new System.Drawing.Size(243, 20);
            this.maskedTextBoxName.TabIndex = 0;
            // 
            // maskedTextBoxSurName
            // 
            this.maskedTextBoxSurName.Location = new System.Drawing.Point(12, 93);
            this.maskedTextBoxSurName.Name = "maskedTextBoxSurName";
            this.maskedTextBoxSurName.Size = new System.Drawing.Size(243, 20);
            this.maskedTextBoxSurName.TabIndex = 1;
            // 
            // maskedTextBoxCargo
            // 
            this.maskedTextBoxCargo.Location = new System.Drawing.Point(12, 143);
            this.maskedTextBoxCargo.Name = "maskedTextBoxCargo";
            this.maskedTextBoxCargo.Size = new System.Drawing.Size(163, 20);
            this.maskedTextBoxCargo.TabIndex = 2;
            // 
            // buttonAddCargo
            // 
            this.buttonAddCargo.Location = new System.Drawing.Point(288, 141);
            this.buttonAddCargo.Name = "buttonAddCargo";
            this.buttonAddCargo.Size = new System.Drawing.Size(75, 23);
            this.buttonAddCargo.TabIndex = 3;
            this.buttonAddCargo.Text = "Добавить";
            this.buttonAddCargo.UseVisualStyleBackColor = true;
            this.buttonAddCargo.Click += new System.EventHandler(this.buttonAddCargo_Click);
            // 
            // listBoxCargos
            // 
            this.listBoxCargos.FormattingEnabled = true;
            this.listBoxCargos.Location = new System.Drawing.Point(12, 169);
            this.listBoxCargos.Name = "listBoxCargos";
            this.listBoxCargos.Size = new System.Drawing.Size(243, 95);
            this.listBoxCargos.TabIndex = 4;
            // 
            // comboBoxWorkers
            // 
            this.comboBoxWorkers.FormattingEnabled = true;
            this.comboBoxWorkers.Location = new System.Drawing.Point(12, 279);
            this.comboBoxWorkers.Name = "comboBoxWorkers";
            this.comboBoxWorkers.Size = new System.Drawing.Size(243, 21);
            this.comboBoxWorkers.TabIndex = 5;
            this.comboBoxWorkers.SelectedIndexChanged += new System.EventHandler(this.comboBoxWorkers_SelectedIndexChanged);
            // 
            // textBoxWorkerWeight
            // 
            this.textBoxWorkerWeight.Location = new System.Drawing.Point(288, 280);
            this.textBoxWorkerWeight.Name = "textBoxWorkerWeight";
            this.textBoxWorkerWeight.Size = new System.Drawing.Size(75, 20);
            this.textBoxWorkerWeight.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Груз";
            // 
            // maskedTextBoxWeight
            // 
            this.maskedTextBoxWeight.Location = new System.Drawing.Point(181, 143);
            this.maskedTextBoxWeight.Name = "maskedTextBoxWeight";
            this.maskedTextBoxWeight.Size = new System.Drawing.Size(73, 20);
            this.maskedTextBoxWeight.TabIndex = 10;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(15, 356);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(160, 23);
            this.buttonOrder.TabIndex = 11;
            this.buttonOrder.Text = "Заказать";
            this.buttonOrder.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(181, 356);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(160, 23);
            this.buttonCancel.TabIndex = 12;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(288, 170);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 405);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.maskedTextBoxWeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxWorkerWeight);
            this.Controls.Add(this.comboBoxWorkers);
            this.Controls.Add(this.listBoxCargos);
            this.Controls.Add(this.buttonAddCargo);
            this.Controls.Add(this.maskedTextBoxCargo);
            this.Controls.Add(this.maskedTextBoxSurName);
            this.Controls.Add(this.maskedTextBoxName);
            this.Name = "FormOrder";
            this.Text = "Форма заказа";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox maskedTextBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxSurName;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxCargo;
        private System.Windows.Forms.Button buttonAddCargo;
        private System.Windows.Forms.ListBox listBoxCargos;
        private System.Windows.Forms.ComboBox comboBoxWorkers;
        private System.Windows.Forms.TextBox textBoxWorkerWeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxWeight;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button btnDelete;
    }
}