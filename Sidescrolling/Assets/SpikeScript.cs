using UnityEngine;
using System.Collections;

public class SpikeScript : MonoBehaviour {

	public int damage;

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			other.GetComponent<PlayerController2D>().TakeDamage(damage);
		}
	}
}
