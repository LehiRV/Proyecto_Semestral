using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Colicion : MonoBehaviour {

	Rigidbody2D rb;


	void Start () {




		Vector2 pos = transform.position;
		pos.y = 0;

		pos.x = 11;
		transform.position = pos;


		rb = GetComponent<Rigidbody2D> ();
		rb.AddForce(new Vector2 (-500,0));

	}


	void Update () {

		if (transform.position.x <= -11) {
			Destroy (gameObject);
		}
	}


}
