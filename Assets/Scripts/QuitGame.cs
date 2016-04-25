using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class QuitGame : MonoBehaviour {

	public void LeaveGame()
	{
		SceneManager.LoadScene("Main Menu");
	}
}
