using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Plataforma : MonoBehaviour {

	Rigidbody2D rb;

	public float delta = 3f;  
	public float Velocity = 0.2f; 
	private Vector3 startPos;

	void Start () {
		
	}


	void Update () {


		Vector3 v = startPos;
		v.x = 2.5f;
		v.y += (delta * 0.5f) * Mathf.Sin (Time.time * Velocity);
		transform.position = v;
	



	}



}