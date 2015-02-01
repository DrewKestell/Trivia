using UnityEngine;
using System.Collections;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class HighScoreTracker : MonoBehaviour {

	public static HighScoreTracker highScoreTracker;

	public HighScore[] highScoreArray = new HighScore[5];
	private TextAsset highScoresAsset;

	void OnEnable()
	{
		if(File.Exists(Application.persistentDataPath + "/highScores.dat"))
		{
			BinaryFormatter bf = new BinaryFormatter();
			FileStream file = File.Open(Application.persistentDataPath + "/highScores.dat", FileMode.Open);
			HighScoreData data = (HighScoreData) bf.Deserialize(file);

			highScoreArray[0] = data.highScore1;
			highScoreArray[1] = data.highScore2;
			highScoreArray[2] = data.highScore3;
			highScoreArray[3] = data.highScore4;
			highScoreArray[4] = data.highScore5;

			file.Close();
		}
	}

	void OnDisable()
	{
		BinaryFormatter bf = new BinaryFormatter();
		FileStream file = File.Open(Application.persistentDataPath + "/highScores.dat", FileMode.Open);
		HighScoreData data = new HighScoreData();
		data.highScore1 = highScoreArray[0];
		data.highScore2 = highScoreArray[1];
		data.highScore3 = highScoreArray[2];
		data.highScore4 = highScoreArray[3];
		data.highScore5 = highScoreArray[4];

		bf.Serialize(file, data);
		file.Close();
	}
	
	void Awake()
	{
		if(highScoreTracker == null)
		{
			DontDestroyOnLoad (gameObject);
			highScoreTracker = this;
		}

		else if(highScoreTracker != this)
		{
			Destroy (gameObject);
		}
	}

	public void sortScores()
	{
		Array.Sort (highScoreArray);
	}

	public HighScore getHighScore(int index)
	{
		return highScoreArray[index];
	}

	public void setHighScore(int index, int score, string name)
	{
		highScoreArray [index].setScore (score);
		highScoreArray [index].setName (name);
		sortScores();
	}
}

[Serializable]
class HighScoreData
{
	public HighScore highScore1;
	public HighScore highScore2;
	public HighScore highScore3;
	public HighScore highScore4;
	public HighScore highScore5;
}