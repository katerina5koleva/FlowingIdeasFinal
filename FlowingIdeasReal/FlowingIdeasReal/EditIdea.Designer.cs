﻿namespace FlowingIdeasApp
{
	partial class EditIdea
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
			components = new System.ComponentModel.Container();
			label2 = new Label();
			txtIdea = new TextBox();
			button1 = new Button();
			button2 = new Button();
			errorProvider1 = new ErrorProvider(components);
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label2.ForeColor = Color.Brown;
			label2.Location = new Point(12, 12);
			label2.Name = "label2";
			label2.Size = new Size(215, 17);
			label2.TabIndex = 5;
			label2.Text = "Rewrite your idea here:";
			// 
			// txtIdea
			// 
			txtIdea.Location = new Point(14, 55);
			txtIdea.Multiline = true;
			txtIdea.Name = "txtIdea";
			txtIdea.Size = new Size(402, 179);
			txtIdea.TabIndex = 12;
			// 
			// button1
			// 
			button1.BackColor = Color.FromArgb(255, 192, 192);
			button1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button1.ForeColor = Color.Crimson;
			button1.Location = new Point(14, 255);
			button1.Margin = new Padding(3, 4, 3, 4);
			button1.Name = "button1";
			button1.Size = new Size(91, 29);
			button1.TabIndex = 13;
			button1.Text = "Cancel";
			button1.UseVisualStyleBackColor = false;
			button1.Click += buttonCancel_Click;
			// 
			// button2
			// 
			button2.BackColor = Color.FromArgb(192, 255, 192);
			button2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
			button2.ForeColor = Color.SeaGreen;
			button2.Location = new Point(331, 255);
			button2.Margin = new Padding(3, 4, 3, 4);
			button2.Name = "button2";
			button2.Size = new Size(85, 29);
			button2.TabIndex = 14;
			button2.Text = "Save";
			button2.UseVisualStyleBackColor = false;
			button2.Click += buttonSave_Click;
			// 
			// errorProvider1
			// 
			errorProvider1.ContainerControl = this;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = Properties.Resources.owlbert_3_actual2;
			pictureBox1.Location = new Point(422, 6);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(282, 287);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 15;
			pictureBox1.TabStop = false;
			// 
			// EditIdea
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.LightYellow;
			ClientSize = new Size(710, 305);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(txtIdea);
			Controls.Add(label2);
			Margin = new Padding(3, 4, 3, 4);
			Name = "EditIdea";
			Text = "Flowing Ideas";
			Load += EditIdea_Load;
			((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private TextBox txtIdea;
		private Button button1;
		private Button button2;
		private ErrorProvider errorProvider1;
		private PictureBox pictureBox1;
	}
}