
namespace sikora_xml
{
	partial class frm_Error
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Error));
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.error = new System.Windows.Forms.RichTextBox();
			this.errorMSG = new System.Windows.Forms.Label();
			this.btn_close = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(163, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// error
			// 
			this.error.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
			this.error.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.error.Location = new System.Drawing.Point(12, 83);
			this.error.Name = "error";
			this.error.ReadOnly = true;
			this.error.Size = new System.Drawing.Size(334, 96);
			this.error.TabIndex = 1;
			this.error.Text = "";
			// 
			// errorMSG
			// 
			this.errorMSG.AutoSize = true;
			this.errorMSG.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.errorMSG.Location = new System.Drawing.Point(12, 54);
			this.errorMSG.Name = "errorMSG";
			this.errorMSG.Size = new System.Drawing.Size(49, 15);
			this.errorMSG.TabIndex = 2;
			this.errorMSG.Text = "label1";
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(255)))), ((int)(((byte)(161)))));
			this.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btn_close.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
			this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btn_close.Location = new System.Drawing.Point(158, 185);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(42, 42);
			this.btn_close.TabIndex = 8;
			this.btn_close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// frm_Error
			// 
			this.AcceptButton = this.btn_close;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(113)))), ((int)(((byte)(206)))));
			this.CancelButton = this.btn_close;
			this.ClientSize = new System.Drawing.Size(358, 236);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.errorMSG);
			this.Controls.Add(this.error);
			this.Controls.Add(this.pictureBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frm_Error";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Ooopsie! Stala se chyba!";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.RichTextBox error;
		private System.Windows.Forms.Label errorMSG;
		private System.Windows.Forms.Button btn_close;
	}
}