﻿namespace Calculator;
using System.Data;

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
	void isCorrect(object sender, EventArgs e)
	{
		DataTable dt = new DataTable();
        Button button = (Button)sender;
        string pressed = button.Text;

        if (dt.Compute(questionContent.Text,"").ToString()==pressed)
		{
			id++;
			//animation here
			if (id ==11)
			{
				id = 1;
			}
			getExercise();
		}
		
	}
}
