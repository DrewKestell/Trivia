using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class HighScore : IComparable {

	private int score;
	private string name;

	public HighScore(int score, string name)
	{
		this.score = score;
		this.name = name;
	}

	public int CompareTo(object obj)
	{
		if (obj == null) return 1;

		HighScore otherHighScore = obj as HighScore;
		if(otherHighScore != null)
			return this.score.CompareTo(otherHighScore.getScore());
		else
			throw new ArgumentException("Object is not a HighScore");
	}

	public int getScore()
	{
		return score;
	}

	public void setScore(int score)
	{
		this.score = score;
	}

	public string getName()
	{
		return name;
	}

	public void setName(string name)
	{
		this.name = name;
	}
}