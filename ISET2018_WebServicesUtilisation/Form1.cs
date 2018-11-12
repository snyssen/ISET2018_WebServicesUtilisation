using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET2018_WebServicesUtilisation
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void BtnHello_Click(object sender, EventArgs e)
		{
			UtiliserServiceHEL.ServiceHELClient s = new UtiliserServiceHEL.ServiceHELClient();
			MessageBox.Show(s.HelloWorld());
		}

		private void buttonBtnPersonneByID2_Click(object sender, EventArgs e)
		{
			if (int.TryParse(TBID.Text, out int nID))
			{
				UtiliserServiceHEL.ServiceHELClient s = new UtiliserServiceHEL.ServiceHELClient();
				UtiliserServiceHEL.WS_Personne p = s.GetPersonneByID(nID);
				if (p.ID == 0)
					MessageBox.Show("Personne non enregistrée");
				else
					MessageBox.Show(p.Prenom + " " + p.Nom + " (" + p.ID + ")");
			}
			else
				MessageBox.Show("ID invalide");
		}
	}
}
