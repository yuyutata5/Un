using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomu : MonoBehaviour {

	// Use this for initialization

		public GameObject explosionPrefab;
		void OnTriggerEnter2D(Collider2D coll)
		{
			Instantiate(explosionPrefab, transform.position, Quaternion.identity);
			//Destroy(gameObject);  
			Destroy(coll.gameObject);    
		}
	}
	
	// Update is called once per frame
