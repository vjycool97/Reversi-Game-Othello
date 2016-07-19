using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace Reversi
{
	/// <summary>
	/// Summary description for AboutDialog.
	/// </summary>
	public class AboutDialog : System.Windows.Forms.Form
	{
		private System.Windows.Forms.PictureBox iconPictureBox;
		private System.Windows.Forms.Button okButton;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label versionLabel;
		private System.Windows.Forms.Label copyrightLabel;

		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public AboutDialog()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

			Icon icon = new Icon(this.Icon, 96, 96);
			this.iconPictureBox.Image = icon.ToBitmap();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(AboutDialog));
			this.iconPictureBox = new System.Windows.Forms.PictureBox();
			this.titleLabel = new System.Windows.Forms.Label();
			this.versionLabel = new System.Windows.Forms.Label();
			this.okButton = new System.Windows.Forms.Button();
			this.copyrightLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// iconPictureBox
			// 
			this.iconPictureBox.Location = new System.Drawing.Point(77, 56);
			this.iconPictureBox.Name = "iconPictureBox";
			this.iconPictureBox.Size = new System.Drawing.Size(96, 96);
			this.iconPictureBox.TabIndex = 0;
			this.iconPictureBox.TabStop = false;
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(103, 16);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(44, 16);
			this.titleLabel.TabIndex = 0;
			this.titleLabel.Text = "Reversi";
			this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// versionLabel
			// 
			this.versionLabel.AutoSize = true;
			this.versionLabel.Location = new System.Drawing.Point(95, 32);
			this.versionLabel.Name = "versionLabel";
			this.versionLabel.Size = new System.Drawing.Size(61, 16);
			this.versionLabel.TabIndex = 1;
			this.versionLabel.Text = "Version 2.0";
			this.versionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// okButton
			// 
			this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.okButton.Location = new System.Drawing.Point(88, 192);
			this.okButton.Name = "okButton";
			this.okButton.TabIndex = 3;
			this.okButton.Text = "OK";
			// 
			// copyrightLabel
			// 
			this.copyrightLabel.AutoSize = true;
			this.copyrightLabel.Location = new System.Drawing.Point(36, 160);
			this.copyrightLabel.Name = "copyrightLabel";
			this.copyrightLabel.Size = new System.Drawing.Size(178, 16);
			this.copyrightLabel.TabIndex = 2;
			this.copyrightLabel.Text = "Copyright 2003-2005 by Mike Hall.";
			this.copyrightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AboutDialog
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.okButton;
			this.ClientSize = new System.Drawing.Size(250, 224);
			this.ControlBox = false;
			this.Controls.Add(this.copyrightLabel);
			this.Controls.Add(this.versionLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.iconPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutDialog";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About Reversi";
			this.ResumeLayout(false);

		}
		#endregion
	}
}
