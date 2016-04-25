using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

	public Projectile projectile;
	public Transform muzzle;
	public float bulletSpeed;
	public float MaxBullets = 20;
	public float CurBullets = 20;
	public Text MaxiBullets;
	public AudioSource Reload;

	void Start() {
		CurBullets = MaxBullets;
		UpdateBullets ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Shoot ();
		}
		if (Input.GetKey ("r")) {
			Reload.Play ();
			CurBullets = MaxBullets;
			UpdateBullets ();
		}
	}

	private void Shoot(){
		//Debug.Log ("Shoot");
		CurBullets--;
		if (CurBullets < 0) {
			CurBullets = 0;
		} else {
			Projectile bullet = Instantiate (projectile, muzzle.position, muzzle.rotation) as Projectile;
			bullet.SetSpeed (bulletSpeed);
		}
		UpdateBullets ();
	}

	void UpdateBullets() {
		MaxiBullets.text = "Bullets: " + CurBullets + "/" + MaxBullets + " (R to reload)";
	}
}
