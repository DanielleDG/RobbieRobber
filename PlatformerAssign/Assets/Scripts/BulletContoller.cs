using UnityEngine;
using System.Collections;

public class BulletContoller : MonoBehaviour {

	public float speed;
	private Rigidbody2D rd;
	public PlayerController player;

	// Use this for initialization
	void Start () {
		rd = this.GetComponent<Rigidbody2D> ();
		player = FindObjectOfType<PlayerController> ();

		if (player.transform.position.x < transform.position.x) {
			speed = -speed;
		}
	}

	
	// Update is called once per frame
	void Update () {
	
		rd.velocity = new Vector2 (speed, rd.velocity.y);
	}

	void OnTriggerEnter2D(Collider2D other){
		Destroy (gameObject);
	}
}
