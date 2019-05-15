using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


	private int restJumps = 3;
	void OnCollisionEnter2D(Collision2D collision)
	{
		
		if (collision.gameObject.tag == "floor")
		{
			// ジャンプ回数をリセットする
			restJumps = 3;
		}
	}


void Update(){
		if (Input.GetKey (KeyCode.RightArrow)) {
			transform.Translate (0.08f, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.Translate (-0.08f, 0, 0);
		}
	
		if (Input.GetKeyDown ("space")) {
			if (restJumps > 0){
				
			GetComponent<Rigidbody2D> ().velocity = Vector3.up * 8.0f;
				restJumps--;

			}

		}
	}

		}



			
