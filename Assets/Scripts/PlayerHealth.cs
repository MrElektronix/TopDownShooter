using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour
{
	public Text PlayerHealthText;
	public float maxHealth = 100;
	public float currentHealth = 100;
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
			SceneManager.LoadScene("Lost Game");
		}
		UpdateLives ();
	}

	void UpdateLives() { 
		PlayerHealthText.text = "Player Health: " + currentHealth + "/" + maxHealth;
	}

}