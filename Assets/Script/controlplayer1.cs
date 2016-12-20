using UnityEngine;
using System.Collections;

public class controlplayer1 : MonoBehaviour {
	Rigidbody2D rigi;
	public float velocidad = 5f;
	public float power = 1f;
	private Rigidbody2D rb;

	void movimientoderecha(){
		rigi = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector2 (velocidad + power, rb.velocity.y);
		this.transform.localScale = new Vector3 (1, 1, 1);
	}
	void Update () { 
		if (Input.GetKey (KeyCode.RightArrow)) { 
			movimientoderecha ();
		}
	}


	}
