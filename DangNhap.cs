using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			this.Hide();
			frmMedicalExaminationDetails frmMED = new frmMedicalExaminationDetails();
			frmMED.ShowDialog();
			frmServices frmServices = new frmServices();
			frmServices.ShowDialog();
		}

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {

    }
  }
}
