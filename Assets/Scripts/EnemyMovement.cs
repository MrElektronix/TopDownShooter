using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public PlayerHealth _playerhealth;
	public EnemyHealth _enemyhealth;
	private NavMeshAgent _navMeshAgent;
	private GameObject _playerObj;
	public AudioSource ZombieOuch;
	public AudioSource PlayerOuch;

	void Awake() {
		_navMeshAgent = GetComponent<NavMeshAgent>();
		_playerObj = GameObject.FindGameObjectWithTag("Player");
		_playerhealth = GetComponent<PlayerHealth>();
		_enemyhealth = GetComponent<EnemyHealth>();
	}

	void Update() {
		_navMeshAgent.SetDestination(_playerObj.transform.position);

	}

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			PlayerOuch.Play ();
			_playerhealth.Damage(20);
		}
		if (other.CompareTag("Projectile")) {
			ZombieOuch.Play ();
			_enemyhealth.Damage(10);
		}
	}
}

