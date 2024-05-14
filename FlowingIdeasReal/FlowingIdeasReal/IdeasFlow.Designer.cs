namespace FlowingIdeas.Presentation
{
	partial class IdeasFlow
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
            txtUsername = new TextBox();
            UsenameLable = new Label();
            buttonLogIn = new Button();
            buttonCancel = new Button();
            buttonSignUp = new Button();
            emptyUsernameBoxError = new ErrorProvider(components);
            shortUsernameError = new ErrorProvider(components);
            longUsernameError = new ErrorProvider(components);
            accountDoesNotExistError = new ErrorProvider(components);
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)emptyUsernameBoxError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shortUsernameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)longUsernameError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accountDoesNotExistError).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(416, 147);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(271, 23);
            txtUsername.TabIndex = 1;
            // 
            // UsenameLable
            // 
            UsenameLable.AutoSize = true;
            UsenameLable.Font = new Font("Rockwell", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            UsenameLable.ForeColor = Color.Brown;
            UsenameLable.Location = new Point(416, 127);
            UsenameLable.Name = "UsenameLable";
            UsenameLable.Size = new Size(81, 18);
            UsenameLable.TabIndex = 5;
            UsenameLable.Text = "Username:";
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.FromArgb(192, 255, 192);
            buttonLogIn.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonLogIn.ForeColor = Color.SeaGreen;
            buttonLogIn.Location = new Point(424, 188);
            buttonLogIn.Margin = new Padding(3, 2, 3, 2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(82, 22);
            buttonLogIn.TabIndex = 7;
            buttonLogIn.Text = "Login";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.BackColor = Color.FromArgb(255, 192, 192);
            buttonCancel.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCancel.ForeColor = Color.Crimson;
            buttonCancel.Location = new Point(600, 188);
            buttonCancel.Margin = new Padding(3, 2, 3, 2);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(82, 22);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = false;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // buttonSignUp
            // 
            buttonSignUp.BackColor = Color.FromArgb(255, 255, 128);
            buttonSignUp.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSignUp.ForeColor = Color.OrangeRed;
            buttonSignUp.Location = new Point(511, 188);
            buttonSignUp.Margin = new Padding(3, 2, 3, 2);
            buttonSignUp.Name = "buttonSignUp";
            buttonSignUp.Size = new Size(82, 22);
            buttonSignUp.TabIndex = 10;
            buttonSignUp.Text = "Sign up";
            buttonSignUp.UseVisualStyleBackColor = false;
            buttonSignUp.Click += buttonSignUp_Click_1;
            // 
            // emptyUsernameBoxError
            // 
            emptyUsernameBoxError.ContainerControl = this;
            // 
            // shortUsernameError
            // 
            shortUsernameError.ContainerControl = this;
            // 
            // longUsernameError
            // 
            longUsernameError.ContainerControl = this;
            // 
            // accountDoesNotExistError
            // 
            accountDoesNotExistError.ContainerControl = this;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FlowingIdeasApp.Properties.Resources.owlbert2;
            pictureBox1.Location = new Point(10, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // IdeasFlow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightYellow;
            ClientSize = new Size(741, 349);
            Controls.Add(pictureBox1);
            Controls.Add(buttonSignUp);
            Controls.Add(buttonCancel);
            Controls.Add(buttonLogIn);
            Controls.Add(UsenameLable);
            Controls.Add(txtUsername);
            Margin = new Padding(3, 2, 3, 2);
            Name = "IdeasFlow";
            Text = "Flowing Ideas";
            Load += IdeasFlow_Load;
            ((System.ComponentModel.ISupportInitialize)emptyUsernameBoxError).EndInit();
            ((System.ComponentModel.ISupportInitialize)shortUsernameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)longUsernameError).EndInit();
            ((System.ComponentModel.ISupportInitialize)accountDoesNotExistError).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
		private Label UsenameLable;
		private Button buttonLogIn;
		private Button buttonCancel;
		private Button buttonSignUp;
		private ErrorProvider emptyUsernameBoxError;
		private ErrorProvider shortUsernameError;
		private ErrorProvider longUsernameError;
		private ErrorProvider accountDoesNotExistError;
		private PictureBox pictureBox1;
	}
}