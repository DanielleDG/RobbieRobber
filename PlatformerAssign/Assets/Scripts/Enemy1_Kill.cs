using UnityEngine;
using System.Collections;

public class Enemy1_Kill : MonoBehaviour {

	public float playerRange;
	public PlayerController player;
	public Animator anim;

	void Start(){
		anim = this.GetComponent<Animator> ();
	}

	void Update(){
		Debug.DrawLine (new Vector3 (transform.position.x - playerRange, transform.position.y
			, transform.position.z), new Vector3 (transform.position.x + playerRange, transform.position.y
				, transform.position.z));
		if (transform.localScale.x < 0 && player.transform.position.x > transform.position.x && player.transform.position.x
		   < transform.position.x + playerRange) 
		{
			anim.SetBool ("isHittingPlayer", true);

		}
		if (transform.localScale.x > 0 && player.transform.position.x < transform.position.x && player.transform.position.x
			> transform.position.x - playerRange) 
		{
			anim.SetBool ("isHittingPlayer", true);
		}
		
	}

}
