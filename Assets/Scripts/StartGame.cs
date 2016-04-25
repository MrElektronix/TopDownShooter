using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;


public class StartGame : MonoBehaviour {

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("Shooter");

    }
}
