using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muerte : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		if (col.tag.Equals ("Player")) {



				Destroy (col.gameObject);// quitar col. desaparecen los asteroides

				GameObject gcObj = GameObject.FindGameObjectWithTag ("GameController");
				GameController gc = gcObj.GetComponent<GameController> ();
				gc.lose ();
			}



	}
}

