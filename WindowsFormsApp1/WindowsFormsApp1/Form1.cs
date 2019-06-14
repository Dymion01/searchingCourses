using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.nr = new System.Windows.Forms.NumericUpDown();
            this.unit = new System.Windows.Forms.ComboBox();
            this.result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nr)).BeginInit();
            this.SuspendLayout();
            // 
            // nr
            // 
            this.nr.Location = new System.Drawing.Point(247, 30);
            this.nr.Name = "nr";
            this.nr.Size = new System.Drawing.Size(120, 20);
            this.nr.TabIndex = 2;
            this.nr.ValueChanged += new System.EventHandler(this.nr_ValueChanged);
            // 
            // unit
            // 
            this.unit.AutoCompleteCustomSource.AddRange(new string[] {
            "mile",
            "kilometry"});
            this.unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unit.Items.AddRange(new object[] {
            "mile",
            "kilometry"});
            this.unit.Location = new System.Drawing.Point(47, 29);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(121, 21);
            this.unit.TabIndex = 3;
            this.unit.SelectedIndexChanged += new System.EventHandler(this.nr_ValueChanged);
            this.unit.SelectedValueChanged += new System.EventHandler(this.unnr_ValueChanged);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(63, 151);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(35, 13);
            this.result.TabIndex = 5;
            this.result.Text = "label1";
            this.result.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1060, 624);
            this.Controls.Add(this.result);
            this.Controls.Add(this.unit);
            this.Controls.Add(this.nr);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nr2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void konwerteruj_Click(object sender, EventArgs e)
        {
            var result = nr.Value + "mil to ";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nr_ValueChanged(object sender, EventArgs e)
        {
            bool isUnitMiles = false;
            if (unit.SelectedIndex == 1)
                isUnitMiles = true;

            if (isUnitMiles)
                result.Text = "" + nr.Value + "mil to " + ((double)nr.Value * 1.6) + "km";
            else
                result.Text = "" + nr.Value + "km to " + ((double)nr.Value / 1.6) + "mil";
        }

        private void unnr_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
