﻿namespace FlowingIdeasApp
{
	partial class AddIdea
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
            label1 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            label2 = new Label();
            txtIdea = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(372, 40);
            label1.Name = "label1";
            label1.Size = new Size(217, 14);
            label1.TabIndex = 0;
            label1.Text = "Choose the type of your idea:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.ForeColor = Color.Brown;
            radioButton1.Location = new Point(373, 57);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(67, 18);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Artistic";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += TypeArtisticIdea_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.ForeColor = Color.Brown;
            radioButton2.Location = new Point(372, 81);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(107, 18);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Philosophical";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += TypePhilosophicalIdea_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.ForeColor = Color.Brown;
            radioButton3.Location = new Point(373, 105);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(106, 18);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Work Related";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += TypeWorkIdea_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Extra Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(372, 153);
            label2.Name = "label2";
            label2.Size = new Size(159, 14);
            label2.TabIndex = 4;
            label2.Text = "Write your idea here:";
            // 
            // txtIdea
            // 
            txtIdea.Location = new Point(372, 169);
            txtIdea.Margin = new Padding(3, 2, 3, 2);
            txtIdea.Multiline = true;
            txtIdea.Name = "txtIdea";
            txtIdea.Size = new Size(427, 175);
            txtIdea.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 224, 192);
            button1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Crimson;
            button1.Location = new Point(372, 358);
            button1.Name = "button1";
            button1.Size = new Size(80, 22);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonCancel_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.SeaGreen;
            button2.Location = new Point(719, 358);
            button2.Name = "button2";
            button2.Size = new Size(80, 22);
            button2.TabIndex = 13;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonSave_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.owlbert1;
            pictureBox2.Location = new Point(-4, 7);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(370, 387);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 16;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.flowers_34592_1280;
            pictureBox1.Location = new Point(638, 7);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // AddIdea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(811, 392);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdea);
            Controls.Add(label2);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Name = "AddIdea";
            Text = "Flowing Ideas";
            Load += AddIdea_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
		private RadioButton radioButton1;
		private RadioButton radioButton2;
		private RadioButton radioButton3;
		private Label label2;
		private TextBox txtIdea;
		private ErrorProvider errorProvider1;
		private Button button1;
		private Button button2;
		private PictureBox pictureBox2;
		private PictureBox pictureBox1;
	}
}