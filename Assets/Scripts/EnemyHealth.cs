using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public Text EnemyHealthText;
	public float maxHealth = 180;
	public float currentHealth = 180;
	public float minimumHealth = 0;

	// Use this for initialization
	void Start ()
	{
		currentHealth = maxHealth;
		UpdateLives ();
	}

	// Update is called once per frame
	void Update () 
	{

	}

	public void Damage (int damageAmount)
	{
		currentHealth -= damageAmount;
		//Debug.Log("2 times?");
		if (currentHealth <= minimumHealth)
		{
			currentHealth = minimumHealth;
			//Destroy(other.gameObject);
			Destroy(gameObject);
			SceneManager.LoadScene("Won Game");
		}
		UpdateLives ();
	}

	void UpdateLives() { 
		EnemyHealthText.text = "Enemy Health: " + currentHealth + "/" + maxHealth;
	}
}
