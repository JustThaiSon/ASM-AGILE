namespace ASM_Agile.frm
{
	partial class frmMenuEmployees
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
			this.components = new System.ComponentModel.Container();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnCustomers = new Guna.UI2.WinForms.Guna2Button();
			this.btnExits = new Guna.UI2.WinForms.Guna2Button();
			this.btnProDuct = new Guna.UI2.WinForms.Guna2Button();
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// guna2Elipse1
			// 
			this.guna2Elipse1.BorderRadius = 8;
			this.guna2Elipse1.TargetControl = this;
			// 
			// guna2DragControl1
			// 
			this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
			this.guna2DragControl1.TargetControl = this;
			this.guna2DragControl1.UseTransparentDrag = true;
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
			this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
			this.guna2Panel1.BorderRadius = 8;
			this.guna2Panel1.BorderThickness = 3;
			this.guna2Panel1.Controls.Add(this.btnCustomers);
			this.guna2Panel1.Controls.Add(this.btnExits);
			this.guna2Panel1.Controls.Add(this.btnProDuct);
			this.guna2Panel1.Location = new System.Drawing.Point(161, 162);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(473, 265);
			this.guna2Panel1.TabIndex = 129;
			// 
			// btnCustomers
			// 
			this.btnCustomers.BackColor = System.Drawing.Color.Transparent;
			this.btnCustomers.BorderRadius = 9;
			this.btnCustomers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnCustomers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnCustomers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnCustomers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnCustomers.ForeColor = System.Drawing.Color.White;
			this.btnCustomers.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnCustomers.Image = global::ASM_Agile.Properties.Resources.customer;
			this.btnCustomers.ImageSize = new System.Drawing.Size(35, 35);
			this.btnCustomers.Location = new System.Drawing.Point(65, 63);
			this.btnCustomers.Name = "btnCustomers";
			this.btnCustomers.Size = new System.Drawing.Size(125, 41);
			this.btnCustomers.TabIndex = 6;
			this.btnCustomers.Text = "Customers";
			this.btnCustomers.UseTransparentBackground = true;
			this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
			// 
			// btnExits
			// 
			this.btnExits.BackColor = System.Drawing.Color.Transparent;
			this.btnExits.BorderRadius = 9;
			this.btnExits.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnExits.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnExits.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnExits.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnExits.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnExits.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnExits.ForeColor = System.Drawing.Color.White;
			this.btnExits.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnExits.Image = global::ASM_Agile.Properties.Resources.cancel;
			this.btnExits.ImageSize = new System.Drawing.Size(35, 35);
			this.btnExits.Location = new System.Drawing.Point(178, 173);
			this.btnExits.Name = "btnExits";
			this.btnExits.Size = new System.Drawing.Size(125, 41);
			this.btnExits.TabIndex = 5;
			this.btnExits.Text = "Exits";
			this.btnExits.UseTransparentBackground = true;
			this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
			// 
			// btnProDuct
			// 
			this.btnProDuct.BackColor = System.Drawing.Color.Transparent;
			this.btnProDuct.BorderRadius = 9;
			this.btnProDuct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnProDuct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnProDuct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnProDuct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnProDuct.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnProDuct.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnProDuct.ForeColor = System.Drawing.Color.White;
			this.btnProDuct.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnProDuct.Image = global::ASM_Agile.Properties.Resources.smartphone;
			this.btnProDuct.ImageSize = new System.Drawing.Size(35, 35);
			this.btnProDuct.Location = new System.Drawing.Point(292, 63);
			this.btnProDuct.Name = "btnProDuct";
			this.btnProDuct.Size = new System.Drawing.Size(125, 41);
			this.btnProDuct.TabIndex = 4;
			this.btnProDuct.Text = "Product";
			this.btnProDuct.UseTransparentBackground = true;
			this.btnProDuct.Click += new System.EventHandler(this.btnProDuct_Click);
			// 
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.Gray;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(693, 12);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(30, 29);
			this.guna2ControlBox1.TabIndex = 128;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Gray;
			this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(738, 12);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new System.Drawing.Size(30, 29);
			this.guna2ControlBox2.TabIndex = 127;
			// 
			// guna2ShadowForm1
			// 
			this.guna2ShadowForm1.BorderRadius = 6;
			this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(6)))), ((int)(((byte)(100)))));
			this.guna2ShadowForm1.TargetForm = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Aachen", 36F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.label1.Location = new System.Drawing.Point(147, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(486, 80);
			this.label1.TabIndex = 132;
			this.label1.Text = "Menu Nhân Viên";
			// 
			// frmMenuEmployees
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(780, 544);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.guna2Panel1);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2ControlBox2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmMenuEmployees";
			this.Text = "frmMenuEmployees";
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button btnCustomers;
		private Guna.UI2.WinForms.Guna2Button btnExits;
		private Guna.UI2.WinForms.Guna2Button btnProDuct;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
		private System.Windows.Forms.Label label1;
	}
}