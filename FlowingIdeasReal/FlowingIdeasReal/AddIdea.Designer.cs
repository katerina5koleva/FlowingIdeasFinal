namespace FlowingIdeasApp
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 17);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 0;
            label1.Text = "Choose the type of your idea:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 38);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(62, 19);
            radioButton1.TabIndex = 1;
            radioButton1.TabStop = true;
            radioButton1.Text = "Artistic";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += TypeArtisticIdea_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(32, 63);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(96, 19);
            radioButton2.TabIndex = 2;
            radioButton2.TabStop = true;
            radioButton2.Text = "Philosophical";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += TypePhilosophicalIdea_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(33, 88);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 19);
            radioButton3.TabIndex = 3;
            radioButton3.TabStop = true;
            radioButton3.Text = "Work Related";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += TypeWorkIdea_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 122);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Write your idea here:";
            // 
            // txtIdea
            // 
            txtIdea.Location = new Point(33, 151);
            txtIdea.Margin = new Padding(3, 2, 3, 2);
            txtIdea.Multiline = true;
            txtIdea.Name = "txtIdea";
            txtIdea.Size = new Size(352, 101);
            txtIdea.TabIndex = 11;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            button1.Location = new Point(305, 35);
            button1.Name = "button1";
            button1.Size = new Size(80, 22);
            button1.TabIndex = 12;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCancel_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 63);
            button2.Name = "button2";
            button2.Size = new Size(80, 22);
            button2.TabIndex = 13;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSave_Click;
            // 
            // AddIdea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 285);
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
    }
}