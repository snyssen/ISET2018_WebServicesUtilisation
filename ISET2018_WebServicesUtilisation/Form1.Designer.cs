namespace ISET2018_WebServicesUtilisation
{
	partial class Form1
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
			this.BtnHello = new System.Windows.Forms.Button();
			this.LblID = new System.Windows.Forms.Label();
			this.TBID = new System.Windows.Forms.TextBox();
			this.buttonBtnPersonneByID2 = new System.Windows.Forms.Button();
			this.TBVerfifSBN = new System.Windows.Forms.Button();
			this.TBISBN = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.TBLogNom = new System.Windows.Forms.TextBox();
			this.BtnVerifLog = new System.Windows.Forms.Button();
			this.TBLogPass = new System.Windows.Forms.TextBox();
			this.LblNom = new System.Windows.Forms.Label();
			this.LblPassword = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// BtnHello
			// 
			this.BtnHello.Location = new System.Drawing.Point(12, 12);
			this.BtnHello.Name = "BtnHello";
			this.BtnHello.Size = new System.Drawing.Size(100, 23);
			this.BtnHello.TabIndex = 0;
			this.BtnHello.Text = "Hello !";
			this.BtnHello.UseVisualStyleBackColor = true;
			this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
			// 
			// LblID
			// 
			this.LblID.AutoSize = true;
			this.LblID.Location = new System.Drawing.Point(12, 38);
			this.LblID.Name = "LblID";
			this.LblID.Size = new System.Drawing.Size(100, 13);
			this.LblID.TabIndex = 1;
			this.LblID.Text = "Identifiant personne";
			// 
			// TBID
			// 
			this.TBID.Location = new System.Drawing.Point(12, 54);
			this.TBID.Name = "TBID";
			this.TBID.Size = new System.Drawing.Size(100, 20);
			this.TBID.TabIndex = 2;
			this.TBID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// buttonBtnPersonneByID2
			// 
			this.buttonBtnPersonneByID2.Location = new System.Drawing.Point(12, 80);
			this.buttonBtnPersonneByID2.Name = "buttonBtnPersonneByID2";
			this.buttonBtnPersonneByID2.Size = new System.Drawing.Size(100, 23);
			this.buttonBtnPersonneByID2.TabIndex = 3;
			this.buttonBtnPersonneByID2.Text = "Chercher";
			this.buttonBtnPersonneByID2.UseVisualStyleBackColor = true;
			this.buttonBtnPersonneByID2.Click += new System.EventHandler(this.buttonBtnPersonneByID2_Click);
			// 
			// TBVerfifSBN
			// 
			this.TBVerfifSBN.Location = new System.Drawing.Point(12, 49);
			this.TBVerfifSBN.Name = "TBVerfifSBN";
			this.TBVerfifSBN.Size = new System.Drawing.Size(100, 23);
			this.TBVerfifSBN.TabIndex = 5;
			this.TBVerfifSBN.Text = "Vérifier";
			this.TBVerfifSBN.UseVisualStyleBackColor = true;
			this.TBVerfifSBN.Click += new System.EventHandler(this.TBVerfifSBN_Click);
			// 
			// TBISBN
			// 
			this.TBISBN.Location = new System.Drawing.Point(12, 23);
			this.TBISBN.Name = "TBISBN";
			this.TBISBN.Size = new System.Drawing.Size(100, 20);
			this.TBISBN.TabIndex = 4;
			this.TBISBN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.TBISBN);
			this.groupBox1.Controls.Add(this.TBVerfifSBN);
			this.groupBox1.Location = new System.Drawing.Point(0, 109);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(127, 80);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "ISBN checker";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.LblPassword);
			this.groupBox2.Controls.Add(this.LblNom);
			this.groupBox2.Controls.Add(this.TBLogPass);
			this.groupBox2.Controls.Add(this.TBLogNom);
			this.groupBox2.Controls.Add(this.BtnVerifLog);
			this.groupBox2.Location = new System.Drawing.Point(0, 187);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(127, 127);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Login";
			// 
			// TBLogNom
			// 
			this.TBLogNom.Location = new System.Drawing.Point(12, 32);
			this.TBLogNom.Name = "TBLogNom";
			this.TBLogNom.Size = new System.Drawing.Size(100, 20);
			this.TBLogNom.TabIndex = 4;
			this.TBLogNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// BtnVerifLog
			// 
			this.BtnVerifLog.Location = new System.Drawing.Point(12, 95);
			this.BtnVerifLog.Name = "BtnVerifLog";
			this.BtnVerifLog.Size = new System.Drawing.Size(100, 23);
			this.BtnVerifLog.TabIndex = 5;
			this.BtnVerifLog.Text = "Vérifier";
			this.BtnVerifLog.UseVisualStyleBackColor = true;
			this.BtnVerifLog.Click += new System.EventHandler(this.BtnVerifLog_Click);
			// 
			// TBLogPass
			// 
			this.TBLogPass.Location = new System.Drawing.Point(12, 69);
			this.TBLogPass.Name = "TBLogPass";
			this.TBLogPass.Size = new System.Drawing.Size(100, 20);
			this.TBLogPass.TabIndex = 6;
			this.TBLogPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// LblNom
			// 
			this.LblNom.AutoSize = true;
			this.LblNom.Location = new System.Drawing.Point(9, 16);
			this.LblNom.Name = "LblNom";
			this.LblNom.Size = new System.Drawing.Size(29, 13);
			this.LblNom.TabIndex = 8;
			this.LblNom.Text = "Nom";
			// 
			// LblPassword
			// 
			this.LblPassword.AutoSize = true;
			this.LblPassword.Location = new System.Drawing.Point(12, 55);
			this.LblPassword.Name = "LblPassword";
			this.LblPassword.Size = new System.Drawing.Size(71, 13);
			this.LblPassword.TabIndex = 9;
			this.LblPassword.Text = "Mot de passe";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(126, 313);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.buttonBtnPersonneByID2);
			this.Controls.Add(this.TBID);
			this.Controls.Add(this.LblID);
			this.Controls.Add(this.BtnHello);
			this.Name = "Form1";
			this.Text = "Form1";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button BtnHello;
		private System.Windows.Forms.Label LblID;
		private System.Windows.Forms.TextBox TBID;
		private System.Windows.Forms.Button buttonBtnPersonneByID2;
		private System.Windows.Forms.Button TBVerfifSBN;
		private System.Windows.Forms.TextBox TBISBN;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label LblPassword;
		private System.Windows.Forms.Label LblNom;
		private System.Windows.Forms.TextBox TBLogPass;
		private System.Windows.Forms.TextBox TBLogNom;
		private System.Windows.Forms.Button BtnVerifLog;
	}
}

