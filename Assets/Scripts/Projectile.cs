using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {
	//public EnemyHealth _enemyhealth;
	private float _speed;
	//private AudioSource Source;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 2f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.forward * _speed * Time.deltaTime);
		//_enemyhealth = GetComponent<EnemyHealth>();
	}

	public void SetSpeed(float value){
		_speed = value;
	}
}
