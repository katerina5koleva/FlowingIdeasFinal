
namespace FlowingIdeas.Presentation
{
	partial class IdeasDataViewer
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
            dataGridView1 = new DataGridView();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            PhlosophicalCheckBox = new CheckBox();
            artisticIdeaCheckBox = new CheckBox();
            workIdeaCheckBox = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.BlanchedAlmond;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Edit, Delete });
            dataGridView1.GridColor = Color.FloralWhite;
            dataGridView1.Location = new Point(320, 128);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(529, 213);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 125;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // PhlosophicalCheckBox
            // 
            PhlosophicalCheckBox.AutoSize = true;
            PhlosophicalCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            PhlosophicalCheckBox.ForeColor = Color.Brown;
            PhlosophicalCheckBox.Location = new Point(321, 17);
            PhlosophicalCheckBox.Margin = new Padding(3, 2, 3, 2);
            PhlosophicalCheckBox.Name = "PhlosophicalCheckBox";
            PhlosophicalCheckBox.Size = new Size(163, 22);
            PhlosophicalCheckBox.TabIndex = 1;
            PhlosophicalCheckBox.Text = "Philosophical ideas";
            PhlosophicalCheckBox.UseVisualStyleBackColor = true;
            PhlosophicalCheckBox.CheckedChanged += PhlosophicalCheckBox_CheckedChanged;
            // 
            // artisticIdeaCheckBox
            // 
            artisticIdeaCheckBox.AutoSize = true;
            artisticIdeaCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            artisticIdeaCheckBox.ForeColor = Color.Brown;
            artisticIdeaCheckBox.Location = new Point(321, 46);
            artisticIdeaCheckBox.Margin = new Padding(3, 2, 3, 2);
            artisticIdeaCheckBox.Name = "artisticIdeaCheckBox";
            artisticIdeaCheckBox.Size = new Size(119, 22);
            artisticIdeaCheckBox.TabIndex = 2;
            artisticIdeaCheckBox.Text = "Artistic ideas";
            artisticIdeaCheckBox.UseVisualStyleBackColor = true;
            artisticIdeaCheckBox.CheckedChanged += artisticIdeaCheckBox_CheckedChanged_1;
            // 
            // workIdeaCheckBox
            // 
            workIdeaCheckBox.AutoSize = true;
            workIdeaCheckBox.Font = new Font("Rockwell", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            workIdeaCheckBox.ForeColor = Color.Firebrick;
            workIdeaCheckBox.Location = new Point(321, 74);
            workIdeaCheckBox.Margin = new Padding(3, 2, 3, 2);
            workIdeaCheckBox.Name = "workIdeaCheckBox";
            workIdeaCheckBox.Size = new Size(105, 22);
            workIdeaCheckBox.TabIndex = 3;
            workIdeaCheckBox.Text = "Work ideas";
            workIdeaCheckBox.UseVisualStyleBackColor = true;
            workIdeaCheckBox.CheckedChanged += workIdeaCheckBox_CheckedChanged_1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 255, 192);
            button1.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.SeaGreen;
            button1.Location = new Point(757, 68);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 5;
            button1.Text = "Add an Idea";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddAnIdeaButton_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 192, 192);
            button2.Font = new Font("Rockwell", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.Crimson;
            button2.Location = new Point(757, 40);
            button2.Name = "button2";
            button2.Size = new Size(92, 22);
            button2.TabIndex = 6;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonCancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = FlowingIdeasApp.Properties.Resources.owlbert_3_actual;
            pictureBox1.Location = new Point(-34, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 402);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // IdeasDataViewer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightYellow;
            ClientSize = new Size(865, 422);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(workIdeaCheckBox);
            Controls.Add(artisticIdeaCheckBox);
            Controls.Add(PhlosophicalCheckBox);
            Controls.Add(dataGridView1);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "IdeasDataViewer";
            Text = "Flowing Ideas";
            Load += IdeasDataViewer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
		private CheckBox PhlosophicalCheckBox;
		private CheckBox artisticIdeaCheckBox;
		private CheckBox workIdeaCheckBox;
		private ErrorProvider errorProvider1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private DataGridViewButtonColumn Edit;
		private DataGridViewButtonColumn Delete;
		private Button button1;
		private Button button2;
		private PictureBox pictureBox1;
	}
}