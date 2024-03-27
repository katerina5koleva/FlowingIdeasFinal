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
			txtUsername.Location = new Point(475, 196);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(309, 27);
			txtUsername.TabIndex = 1;
			// 
			// UsenameLable
			// 
			UsenameLable.AutoSize = true;
			UsenameLable.Font = new Font("Rockwell", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
			UsenameLable.ForeColor = Color.Brown;
			UsenameLable.Location = new Point(475, 169);
			UsenameLable.Name = "UsenameLable";
			UsenameLable.Size = new Size(97, 22);
			UsenameLable.TabIndex = 5;
			UsenameLable.Text = "Username:";
			// 
			// buttonLogIn
			// 
			buttonLogIn.BackColor = Color.FromArgb(192, 255, 192);
			buttonLogIn.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
			buttonLogIn.ForeColor = Color.SeaGreen;
			buttonLogIn.Location = new Point(485, 251);
			buttonLogIn.Name = "buttonLogIn";
			buttonLogIn.Size = new Size(94, 29);
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
			buttonCancel.Location = new Point(686, 251);
			buttonCancel.Name = "buttonCancel";
			buttonCancel.Size = new Size(94, 29);
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
			buttonSignUp.Location = new Point(584, 251);
			buttonSignUp.Name = "buttonSignUp";
			buttonSignUp.Size = new Size(94, 29);
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
			pictureBox1.Location = new Point(12, 28);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(421, 400);
			pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
			pictureBox1.TabIndex = 11;
			pictureBox1.TabStop = false;
			// 
			// IdeasFlow
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSizeMode = AutoSizeMode.GrowAndShrink;
			BackColor = Color.LightYellow;
			ClientSize = new Size(847, 465);
			Controls.Add(pictureBox1);
			Controls.Add(buttonSignUp);
			Controls.Add(buttonCancel);
			Controls.Add(buttonLogIn);
			Controls.Add(UsenameLable);
			Controls.Add(txtUsername);
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