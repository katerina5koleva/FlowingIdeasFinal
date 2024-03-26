namespace FlowingIdeasApp
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
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 34);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 5;
            label2.Text = "Rewrite your idea here:";
            // 
            // txtIdea
            // 
            txtIdea.Location = new Point(27, 60);
            txtIdea.Margin = new Padding(3, 2, 3, 2);
            txtIdea.Multiline = true;
            txtIdea.Name = "txtIdea";
            txtIdea.Size = new Size(352, 101);
            txtIdea.TabIndex = 12;
            // 
            // button1
            // 
            button1.Location = new Point(247, 185);
            button1.Name = "button1";
            button1.Size = new Size(80, 22);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += buttonCancel_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 185);
            button2.Name = "button2";
            button2.Size = new Size(74, 22);
            button2.TabIndex = 14;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += buttonSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // EditIdea
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 219);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtIdea);
            Controls.Add(label2);
            Name = "EditIdea";
            Text = "Flowing Ideas";
            Load += EditIdea_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox txtIdea;
        private Button button1;
        private Button button2;
        private ErrorProvider errorProvider1;
    }
}