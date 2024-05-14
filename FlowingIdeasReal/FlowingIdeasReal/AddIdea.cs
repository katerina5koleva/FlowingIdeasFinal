using Business;
using Data.Model;
using FlowingIdeas.Presentation;

namespace FlowingIdeasApp
{
	/// <summary>
	/// This class adds ideas in the database.
	/// From the radiobuttons we choose the type of the idea,
	/// we inherit the userId from the IdeasDataViewer form
	/// and we have the text of the idea, of course.
	/// </summary>
	public partial class AddIdea : Form
	{
		private int userId;
		private IdeaType ideaType;
		private UserIdeaBusinessLogic ideaBusinessLogic = new();

		public AddIdea(int userId)
		{
			InitializeComponent();
			this.userId = userId;
		}

		/// <summary>
		/// This method clears the text box.
		/// </summary>
		private void ClearTextBoxes()
		{
			txtIdea.Text = "";
		}

		/// <summary>
		/// This radio button selects the type of the idea as artistic
		/// and saves the idea type Id (1), which we need to create the idea.
		/// </summary>
		private void TypeArtisticIdea_CheckedChanged(object sender, EventArgs e)
		{
			ideaType = IdeaType.Artistic;
		}

		/// <summary>
		/// This radio button selects the type of the idea as philosophical
		/// and saves the idea type Id (2), which we need to create the idea.
		/// </summary>
		private void TypePhilosophicalIdea_CheckedChanged(object sender, EventArgs e)
		{
			ideaType = IdeaType.Philosopical;
		}

		/// <summary>
		/// This radio button selects the type of the idea as work
		/// and saves the idea type Id (3), which we need to create the idea.
		/// </summary>
		private void TypeWorkIdea_CheckedChanged(object sender, EventArgs e)
		{
			ideaType = IdeaType.Work;
		}

		/// <summary>
		/// This button hides the Adding an idea form
		/// and takes us back to the DataViewer form.
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

			string newIdeaText = txtIdea.Text;

			if (string.IsNullOrEmpty(newIdeaText))
			{
				errorProvider1.SetError(txtIdea, "Required");
			}
			else if (newIdeaText.Length < 3)
			{
				errorProvider1.SetError(txtIdea, "Your idea should be longer!!!");
			}
			else if (newIdeaText.Length > 400)
			{
				errorProvider1.SetError(txtIdea, "Please, write a shorter idea!!!");
			}
			else
			{
				ideaBusinessLogic.AddIdea(userId, ideaType, newIdeaText);

				MessageBox.Show("Your idea was created!");
				ClearTextBoxes();
				this.Hide();
				IdeasDataViewer ideasDataViewer = new IdeasDataViewer(userId);
				ideasDataViewer.Show();
			}
		}

		private void AddIdea_Load(object sender, EventArgs e)
		{

		}
	}
}
