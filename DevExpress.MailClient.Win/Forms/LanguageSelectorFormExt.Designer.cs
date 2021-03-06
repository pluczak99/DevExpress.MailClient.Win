﻿
using DevExpress.XtraEditors;

namespace DevExpress.MailClient.Win
{
	partial class LanguageSelectorFormExt : XtraForm
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
			this.dropdownLanguages = new System.Windows.Forms.ComboBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.checkEditRememberLanguageChoice = new DevExpress.XtraEditors.CheckEdit();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkEditRememberLanguageChoice.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// dropdownLanguages
			// 
			this.dropdownLanguages.BackColor = System.Drawing.SystemColors.Window;
			this.dropdownLanguages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.dropdownLanguages.ForeColor = System.Drawing.SystemColors.WindowFrame;
			this.dropdownLanguages.FormattingEnabled = true;
			this.dropdownLanguages.Location = new System.Drawing.Point(178, 36);
			this.dropdownLanguages.Name = "dropdownLanguages";
			this.dropdownLanguages.Size = new System.Drawing.Size(203, 21);
			this.dropdownLanguages.TabIndex = 0;
			this.dropdownLanguages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dropdownLanguages_KeyPress);
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(257, 147);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			this.btnOK.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnOK_KeyPress);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(360, 147);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 2;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.dropdownLanguages);
			this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
			this.groupBox1.Location = new System.Drawing.Point(23, 27);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(412, 100);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Select language to proceed to the application:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.label1.Location = new System.Drawing.Point(22, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "User Interface Language:";
			// 
			// checkEditRememberLanguageChoice
			// 
			this.checkEditRememberLanguageChoice.Location = new System.Drawing.Point(23, 133);
			this.checkEditRememberLanguageChoice.Name = "checkEditRememberLanguageChoice";
			this.checkEditRememberLanguageChoice.Properties.Caption = "&Remember choice";
			this.checkEditRememberLanguageChoice.Size = new System.Drawing.Size(200, 18);
			this.checkEditRememberLanguageChoice.TabIndex = 3;
			// 
			// LanguageSelectorFormExt
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(460, 189);
			this.Controls.Add(this.checkEditRememberLanguageChoice);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "LanguageSelectorFormExt";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "To Do List Demo";
			this.Load += new System.EventHandler(this.LanguageSelectorFormExt_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.checkEditRememberLanguageChoice.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox dropdownLanguages;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private CheckEdit checkEditRememberLanguageChoice;
	}
}