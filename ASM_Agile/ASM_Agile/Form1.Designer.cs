namespace ASM_Agile
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
			this.components = new System.ComponentModel.Container();
			this.label4 = new System.Windows.Forms.Label();
			this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
			this.btnEmployees = new Guna.UI2.WinForms.Guna2Button();
			this.btnExits = new Guna.UI2.WinForms.Guna2Button();
			this.btnManagers = new Guna.UI2.WinForms.Guna2Button();
			this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
			this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
			this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
			this.guna2Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label4.Font = new System.Drawing.Font("Aachen", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Red;
			this.label4.Location = new System.Drawing.Point(137, 35);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(489, 57);
			this.label4.TabIndex = 114;
			this.label4.Text = "Chọn Quyền Đăng Nhập";
			// 
			// guna2Panel1
			// 
			this.guna2Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(224)))), ((int)(((byte)(231)))));
			this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(56)))), ((int)(((byte)(68)))));
			this.guna2Panel1.BorderRadius = 8;
			this.guna2Panel1.BorderThickness = 3;
			this.guna2Panel1.Controls.Add(this.btnEmployees);
			this.guna2Panel1.Controls.Add(this.btnExits);
			this.guna2Panel1.Controls.Add(this.btnManagers);
			this.guna2Panel1.Location = new System.Drawing.Point(147, 143);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new System.Drawing.Size(473, 265);
			this.guna2Panel1.TabIndex = 113;
			// 
			// btnEmployees
			// 
			this.btnEmployees.BackColor = System.Drawing.Color.Transparent;
			this.btnEmployees.BorderRadius = 9;
			this.btnEmployees.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnEmployees.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnEmployees.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnEmployees.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnEmployees.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnEmployees.ForeColor = System.Drawing.Color.White;
			this.btnEmployees.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnEmployees.Image = global::ASM_Agile.Properties.Resources.customer_care;
			this.btnEmployees.ImageSize = new System.Drawing.Size(30, 30);
			this.btnEmployees.Location = new System.Drawing.Point(302, 63);
			this.btnEmployees.Name = "btnEmployees";
			this.btnEmployees.Size = new System.Drawing.Size(125, 41);
			this.btnEmployees.TabIndex = 7;
			this.btnEmployees.Text = "Employees";
			this.btnEmployees.UseTransparentBackground = true;
			this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);
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
			this.btnExits.Location = new System.Drawing.Point(162, 153);
			this.btnExits.Name = "btnExits";
			this.btnExits.Size = new System.Drawing.Size(125, 41);
			this.btnExits.TabIndex = 5;
			this.btnExits.Text = "Exits";
			this.btnExits.UseTransparentBackground = true;
			this.btnExits.Click += new System.EventHandler(this.btnExits_Click);
			// 
			// btnManagers
			// 
			this.btnManagers.BackColor = System.Drawing.Color.Transparent;
			this.btnManagers.BorderRadius = 9;
			this.btnManagers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
			this.btnManagers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
			this.btnManagers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
			this.btnManagers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
			this.btnManagers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnManagers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btnManagers.ForeColor = System.Drawing.Color.White;
			this.btnManagers.HoverState.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.btnManagers.Image = global::ASM_Agile.Properties.Resources.manager1;
			this.btnManagers.ImageSize = new System.Drawing.Size(30, 30);
			this.btnManagers.Location = new System.Drawing.Point(40, 63);
			this.btnManagers.Name = "btnManagers";
			this.btnManagers.Size = new System.Drawing.Size(125, 41);
			this.btnManagers.TabIndex = 4;
			this.btnManagers.Text = "Managers";
			this.btnManagers.UseTransparentBackground = true;
			this.btnManagers.Click += new System.EventHandler(this.btnManagers_Click);
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
			// guna2ControlBox1
			// 
			this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.guna2ControlBox1.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
			this.guna2ControlBox1.FillColor = System.Drawing.Color.Gray;
			this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox1.Location = new System.Drawing.Point(677, 19);
			this.guna2ControlBox1.Name = "guna2ControlBox1";
			this.guna2ControlBox1.Size = new System.Drawing.Size(30, 29);
			this.guna2ControlBox1.TabIndex = 123;
			// 
			// guna2ControlBox2
			// 
			this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.guna2ControlBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(220)))), ((int)(((byte)(199)))));
			this.guna2ControlBox2.FillColor = System.Drawing.Color.Gray;
			this.guna2ControlBox2.HoverState.FillColor = System.Drawing.Color.Red;
			this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
			this.guna2ControlBox2.Location = new System.Drawing.Point(722, 19);
			this.guna2ControlBox2.Name = "guna2ControlBox2";
			this.guna2ControlBox2.Size = new System.Drawing.Size(30, 29);
			this.guna2ControlBox2.TabIndex = 122;
			// 
			// guna2ShadowForm1
			// 
			this.guna2ShadowForm1.BorderRadius = 6;
			this.guna2ShadowForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(6)))), ((int)(((byte)(100)))));
			this.guna2ShadowForm1.TargetForm = this;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(764, 512);
			this.Controls.Add(this.guna2ControlBox1);
			this.Controls.Add(this.guna2ControlBox2);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.guna2Panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			this.guna2Panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
		private Guna.UI2.WinForms.Guna2Button btnEmployees;
		private Guna.UI2.WinForms.Guna2Button btnExits;
		private Guna.UI2.WinForms.Guna2Button btnManagers;
		private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
		private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
		private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
		private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
	}
}

