using UnityEngine;
using System.Collections;

public class AboutManager : MonoBehaviour {

	public void SceneTransition(string sceneName)
	{
		Application.LoadLevel(sceneName);
	}
}