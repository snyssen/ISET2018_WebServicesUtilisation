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

		private void TBVerfifSBN_Click(object sender, EventArgs e)
		{
			string sISBN = TBISBN.Text.Trim();
			if (sISBN.Length > 0)
			{
				sISBN = sISBN.Replace("-", "");
				if (UInt64.TryParse(sISBN, out UInt64 whatev) && sISBN.Length == 13) // On a bien un nombre de 13 chiffres
				{
					char[] tabISBN = sISBN.ToCharArray();
					if (CheckISBNChar(tabISBN))
						MessageBox.Show("Le code entré est valide");
					else
						MessageBox.Show("Le code entré est invalide");
				}
			}
		}

		// retourne vrai si l'ISBN est valide. le tabchar entré doit être un nombre de 13 chiffres
		private bool CheckISBNChar(char[] tabISBN)
		{
			int r = 0;
			for (int i = 0; i < 12; i++)
			{
				if (i % 2 == 0) // char pair
				{
					r += int.Parse(tabISBN[i].ToString());
				}
				else // char impair
				{
					r += int.Parse(tabISBN[i].ToString()) * 3;
				}
			}
			r = 10 - (r % 10);
			if (r == 10)
				r = 0;
			if (int.Parse(tabISBN[12].ToString()) == r)
				return true;
			else
				return false;
		}
	}
}
