using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

	[SerializeField]
	public  float speed;
	public bool movingRight;

	public Transform wallCheck;
	public float wallCheckRadius;
	public LayerMask theWall;
	private bool isHittingWall;

	private bool isNotOnEdge;
	public Transform edgeCheck;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		//Check to see if enemy is hitting a surface/standing on edge
		isHittingWall = Physics2D.OverlapCircle (wallCheck.position, wallCheckRadius, theWall);
		isNotOnEdge = Physics2D.OverlapCircle (edgeCheck.position, wallCheckRadius, theWall);

		if (isHittingWall || !isNotOnEdge) {
			movingRight = !movingRight;
		}

		if (movingRight) {
			transform.localScale = new Vector3 (0.5681f, 0.5681f, 0.5681f);
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		} else {
			transform.localScale = new Vector3 (-0.5681f, 0.5681f, 0.5681f);
			GetComponent<Rigidbody2D>().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D>().velocity.y);
		}
	}
		
}

