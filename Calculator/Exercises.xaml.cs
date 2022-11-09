namespace Calculator;
using System;
using System.Data;
using System.Threading.Tasks;

public partial class Exercises : ContentPage
{
	public int id = 1;
	public Exercises()
	{
		InitializeComponent();
		getExercise();

	}
	async void getExercise()
	{
		ExercisesData data = await callApi();
		questionNumber.Text = "Question " + id.ToString();
		choice1.Text = data.incorrect1.ToString();
		choice2.Text = data.incorrect2.ToString();
		choice3.Text = data.correct.ToString();
		questionContent.Text = data.equation;

	}
	async Task<ExercisesData> callApi()
	{
		GetAPI getAPI = new GetAPI();
		ExercisesData value = await getAPI.GetData(id);
		return value;
		
	}
	async void isCorrect(object sender, EventArgs e)
	{
		DataTable dt = new DataTable();
		Button button = (Button)sender;
		string pressed = button.Text;
		var btn = (Button)sender;

		if (dt.Compute(questionContent.Text, "").ToString() == pressed)
		{
			id++;

            await DisplayAlert("Your answer is...", "Correct", "Go Next");

            if (id == 11)
			{
				id = 1;
			}
			getExercise();
		}

		else
        {
			bool answer = await DisplayAlert("Your answer is...", "Incorrect", "Skip to Next", "Try Again");

			if (answer)
			{
				id++;

				getExercise();
			}
        }
	}
}
