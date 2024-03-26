using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data.Model;
using System.Data.SqlClient;
using System.Net.Http;
namespace FlowingIdeas.Presentation;
/// <summary>
/// This is the first window that is an implementation of a login/signup functionality
/// for managing user ideas in a Windows Forms application, with database interaction handled through the business logic.
/// </summary>
public partial class IdeasFlow : Form
{
    private UserIdeaBusinessLogic userIdeaBusinessLogic = new UserIdeaBusinessLogic();
    public static IdeasFlow instance;
    public IdeasFlow()
    {
        InitializeComponent();
        instance = this;
    }

    /// <summary>
    ///	This button handles the click event of the login.
    /// It establishes a database connection, checks if the username exists and
    /// shows an error message if the username doesn't exist.
    /// </summary>

    private void buttonLogIn_Click(object sender, EventArgs e)
    {
        string writtenUsername = txtUsername.Text;
        if (writtenUsername != string.Empty)
        {
            if (userIdeaBusinessLogic.CheckIfAccountExists(writtenUsername))
            {
                int userId = userIdeaBusinessLogic.GetUserId(writtenUsername);
                IdeasDataViewer formViewIdeas = new IdeasDataViewer(userId);
                this.Hide();
                formViewIdeas.Show();

            }
            else
            {
                MessageBox.Show("No account avaliable with this username! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        else
        {
            emptyUsernameBoxError.Clear();
            bool addBool = true;
            if (string.IsNullOrEmpty(writtenUsername))
            {
                emptyUsernameBoxError.SetError(txtUsername, "Required");
                addBool = false;
            }
        }
    }
    /// <summary>
    /// This button closes the form when the cancel is clicked.
    /// </summary>

    private void buttonCancel_Click(object sender, EventArgs e)
    {
        this.Close();
    }
    
    
    private void IdeasFlow_Load(object sender, EventArgs e)
    {

    }
    /// <summary>
    /// This button handles the click event of the sign-up. It checks if the username already exists, 
    /// validates the length of the username, and inserts a new username into the database if validation passes.
    /// </summary>
    private void buttonSignUp_Click_1(object sender, EventArgs e)
    {
        string writtenUsername = txtUsername.Text;
        emptyUsernameBoxError.Clear();
        bool addBool = true;
        if (string.IsNullOrEmpty(writtenUsername))
        {
            emptyUsernameBoxError.SetError(txtUsername, "Required");
            addBool = false;
        }
        else if (userIdeaBusinessLogic.CheckIfAccountExists(writtenUsername))
        {
            MessageBox.Show("Username already exist, please try another! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        else if (writtenUsername.Length > 15)
        {
            emptyUsernameBoxError.SetError(txtUsername, "Your username needs to be shorter!");
            addBool = false;
        }
        else if (writtenUsername.Length < 3)
        {
            emptyUsernameBoxError.SetError(txtUsername, "Your username needs to be longer!");
            addBool = false;
        }
        else
        {
            userIdeaBusinessLogic.CreateAccount(writtenUsername);
            MessageBox.Show("Your account has been created. Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    
}

