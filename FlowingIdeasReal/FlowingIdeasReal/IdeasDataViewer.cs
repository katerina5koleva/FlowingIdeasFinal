using Business;
using Data;
using Data.Model;
using FlowingIdeasApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FlowingIdeas.Presentation;
/// <summary>
/// This windows form allows users to add, edit, and delete different
/// types of ideas (artistic, work, philosophical) through various button clicks,
/// with data displayed in a DataGridView.
/// </summary>
public partial class IdeasDataViewer : Form
{
    private int userId;
    private UserIdeaBusinessLogic ideaBusinessLogic = new UserIdeaBusinessLogic();

    public IdeasDataViewer(int userId)
    {
        InitializeComponent();
        UpdateGrid(userId);
        this.userId = userId;
    }
    /// <summary>
    /// This automatically shows all the ideas that the user has from the database.
    /// </summary>
    private void UpdateGrid(int userId)
    {
        dataGridView1.DataSource = ideaBusinessLogic.GetAll(userId);
        dataGridView1.Columns["Id"].Visible = false;
        dataGridView1.Columns["UserId"].Visible = false;
        dataGridView1.Columns["IdeaTypeId"].HeaderText = "Idea Type";
        dataGridView1.Columns["IdeaText"].HeaderText = "Idea Text";
        // The code bellow formats the cells from int Id idea type to string with the name of the idea type.
        dataGridView1.CellFormatting += (sender, e) =>
        {
            if (e.ColumnIndex == dataGridView1.Columns["IdeaTypeId"].Index && e.Value != null)
            {
                if (!(e.Value is string))
                {
                    int ideaTypeValue = (int)e.Value;
                    string ideaTypeString = ideaBusinessLogic.GetIdeaTypeString(ideaTypeValue);
                    e.Value = ideaTypeString;
                }
            }
        };
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }
    /// <summary>
    /// This method is reposible for visualizing the data for the checkboxes simulatinuously.
    /// It adds the ideas to a list that is shown.
    /// </summary>
    private void FilterAndDisplayIdeas()
    {
        List<Idea> filteredIdeas = new List<Idea>();
        if (PhlosophicalCheckBox.Checked)
        {
            filteredIdeas.AddRange(ideaBusinessLogic.GetAllPhilosophical(userId));
        }
        if (artisticIdeaCheckBox.Checked)
        {
            filteredIdeas.AddRange(ideaBusinessLogic.GetAllArtistic(userId));
        }
        if (workIdeaCheckBox.Checked)
        {
            filteredIdeas.AddRange(ideaBusinessLogic.GetAllWork(userId));
        }
        dataGridView1.DataSource = filteredIdeas;
        dataGridView1.Columns["Id"].Visible = false;
        dataGridView1.Columns["UserId"].Visible = false;
        dataGridView1.Columns["IdeaTypeId"].HeaderText = "Idea Type";
        dataGridView1.Columns["IdeaText"].HeaderText = "Idea Text";
        dataGridView1.ReadOnly = true;
        dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
    }

    private void FlowingIdeaForm_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// This method allows us to click and choose a specific cell.
    /// The first if checks whether the cell is the button delete,
    /// uses the method Delete from the Business logic
    /// and updated the grid.
    /// </summary>
    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0 && e.ColumnIndex == 1)
        {
            int ideaIdToDelete = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            ideaBusinessLogic.Delete(ideaIdToDelete);
            UpdateGrid(userId);
        }
        if (e.RowIndex >= 0 && e.ColumnIndex == 0)
        {
            int ideaIdToEdit = (int)dataGridView1.Rows[e.RowIndex].Cells["Id"].Value;
            EditIdea formEditIdea = new EditIdea(userId, ideaIdToEdit);
            this.Hide();
            formEditIdea.Show();
            UpdateGrid(userId);
        }

    }
    /// <summary>
    /// This is the code behind the Philosophical Idea check box button.
    /// </summary>
    private void PhlosophicalCheckBox_CheckedChanged(object sender, EventArgs e)
    {
        FilterAndDisplayIdeas();
    }
    /// <summary>
    /// This the code behind the Artistic Idea check box button.
    /// </summary>
    private void artisticIdeaCheckBox_CheckedChanged_1(object sender, EventArgs e)
    {
        FilterAndDisplayIdeas();
    }
    /// <summary>
    /// This is the code behind the Work Related Idea check box button.
    /// </summary>
    private void workIdeaCheckBox_CheckedChanged_1(object sender, EventArgs e)
    {
        FilterAndDisplayIdeas();
    }
    /// <summary>
    /// This method is initialized when the add an idea button is clicked.
    /// It opens a new form in which you can write your ideas.
    /// </summary>
    private void AddAnIdeaButton_Click(object sender, EventArgs e)
    {
        AddIdea formAddIdea = new AddIdea(userId);
        this.Hide();
        formAddIdea.Show();
    }
    /// <summary>
    /// This is the code behind the close button.
    /// </summary>
    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}
