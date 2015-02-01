using UnityEngine;
using System.Collections;

public class TitleManager : MonoBehaviour {

	public void SceneTransition(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}