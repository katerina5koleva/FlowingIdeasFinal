using Business;
using Data.Model;
using FlowingIdeas.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowingIdeasApp
{
    /// <summary>
    /// This is a form in which the user can rewrite
    /// the text of their idea.
    /// </summary>
    public partial class EditIdea : Form
    {
        private int userId;
        private int ideaIdToEdit;
        private UserIdeaBusinessLogic ideaBusinessLogic = new UserIdeaBusinessLogic();
        public EditIdea(int userId, int ideaIdToEdit)
        {
            InitializeComponent();
            this.userId = userId;
            this.ideaIdToEdit = ideaIdToEdit;
        }
        /// <summary>
        /// This method clears the text box.
        /// </summary>
        private void ClearTextBoxes()
        {
            txtIdea.Text = "";
        }
        /// <summary>
        /// This method is activated when the cancel button is clicked.
        /// It hides the current form and opens again the IdeasDataViewer form.
        /// </summary>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            IdeasDataViewer formViewIdeas = new IdeasDataViewer(userId);
            this.Hide();
            formViewIdeas.Show();
        }
        /// <summary>
        /// This button saves the idea and adds it to the table Ideas in the database,
        /// using the controller.
        /// It also checks whether it meets the length requirements.
        /// </summary>
        private void buttonSave_Click(object sender, EventArgs e)
        {

            errorProvider1.Clear();
            bool addBool = true;

            string newIdeaText = txtIdea.Text;

            if (string.IsNullOrEmpty(newIdeaText))
            {
                errorProvider1.SetError(txtIdea, "Required");
                addBool = false;
            }
            else if (newIdeaText.Length < 3)
            {
                errorProvider1.SetError(txtIdea, "Your idea should be longer!!!");
                addBool = false;
            }
            else if (newIdeaText.Length > 400)
            {
                errorProvider1.SetError(txtIdea, "Please, write a shorter idea!!!");
            }
            else
            {
                ideaBusinessLogic.Edit(ideaIdToEdit, userId, newIdeaText);
                MessageBox.Show("Your idea was edited!");
                ClearTextBoxes();
                this.Hide();
                IdeasDataViewer ideasDataViewer = new IdeasDataViewer(userId); 
                ideasDataViewer.Show();
            }
        }

        private void EditIdea_Load(object sender, EventArgs e)
        {

        }
    }
}
