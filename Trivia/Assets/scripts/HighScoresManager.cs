using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HighScoresManager : MonoBehaviour {

	public Text highscore1Value;
	public Text highscore1Name;
	public Text highscore2Value;
	public Text highscore2Name;
	public Text highscore3Value;
	public Text highscore3Name;
	public Text highscore4Value;
	public Text highscore4Name;
	public Text highscore5Value;
	public Text highscore5Name;

	public void SceneTransition(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}

	void Start()
	{
		UpdateHighScores();
	}

	public void UpdateHighScores()
	{
		highscore1Value.text = HighScoreTracker.highScoreTracker.getHighScore(4).getScore().ToString();
		highscore1Name.text = HighScoreTracker.highScoreTracker.getHighScore(4).getName();
		highscore2Value.text = HighScoreTracker.highScoreTracker.getHighScore(3).getScore().ToString();
		highscore2Name.text = HighScoreTracker.highScoreTracker.getHighScore(3).getName();
		highscore3Value.text = HighScoreTracker.highScoreTracker.getHighScore(2).getScore().ToString();
		highscore3Name.text = HighScoreTracker.highScoreTracker.getHighScore(2).getName();
		highscore4Value.text = HighScoreTracker.highScoreTracker.getHighScore(1).getScore ().ToString();
		highscore4Name.text = HighScoreTracker.highScoreTracker.getHighScore(1).getName();
		highscore5Value.text = HighScoreTracker.highScoreTracker.getHighScore(0).getScore().ToString();
		highscore5Name.text = HighScoreTracker.highScoreTracker.getHighScore(0).getName();
	}
}