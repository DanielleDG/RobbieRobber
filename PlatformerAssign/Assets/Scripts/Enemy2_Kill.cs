using UnityEngine;
using System.Collections;

public class Enemy2_Kill : MonoBehaviour {
	public float playerRange;
	public PlayerController player;
	public Animator anim;

	public Transform firingPoint;
	public GameObject bullet;

	void Start(){
		anim = this.GetComponent<Animator> ();
	}

	void Update(){
		Debug.DrawLine (new Vector3 (transform.position.x - playerRange, transform.position.y
			, transform.position.z), new Vector3 (transform.position.x + playerRange, transform.position.y
				, transform.position.z));
		if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x
			< transform.position.x + playerRange) {
			anim.SetBool ("playerInRange", true);
			Instantiate (bullet, firingPoint.position, firingPoint.rotation);
		}
		if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x
			> transform.position.x - playerRange) 
		{
			anim.SetBool ("playerInRange", true);
			Instantiate (bullet, firingPoint.position, firingPoint.rotation);
		}
			

	}
}
