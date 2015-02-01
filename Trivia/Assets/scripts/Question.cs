using UnityEngine;
using System.Collections;

public class Question {

	private string question;
	private string correctAnswer;
	private string[] dummyAnswers = new string[3];

	public Question(string question, string correctAnswer, string firstDummyAnswer, string secondDummyAnswer, string thirdDummyAnswer)
	{
		this.question = question;
		this.correctAnswer = correctAnswer;
		dummyAnswers[0] = firstDummyAnswer;
		dummyAnswers[1] = secondDummyAnswer;
		dummyAnswers[2] = thirdDummyAnswer;	
	}

	public string getQuestion()
	{
		return question;
	}

	public string getCorrectAnswer()
	{
		return correctAnswer;
	}

	public string getDummyAnswer(int index)
	{
		return dummyAnswers[index];
	}
}