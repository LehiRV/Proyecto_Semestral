using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob : MonoBehaviour {

    int direccion = 1;  //  1 = Derecha, 0 = Izquierda
    float vel = 0.05f;
    public GameObject Player;

	// Use this for initialization
	void Start () {
        
        StartCoroutine("Direccionar");
    }
	
	// Update is called once per frame
	void Update () {
        float dist = Vector3.Distance(Player.transform.position, transform.position);
        //Debug.Log(dist+"  "+ vel);

        //  Si está más cerca aumenta su velocidad, si se aleja la disminuye
        if(dist <= 4.0f)
        {
            vel = 0.08f;
        }
        else
        {
            vel = 0.05f;
        }
        
        //  Se mueve en base a la dirección que lleve
        if (direccion == 1)
        {
            transform.Translate(vel, 0, 0);
        }
        else
        {
            transform.Translate(-vel, 0, 0);
        }
        
    }

    IEnumerator Direccionar()
    {
        while (true)
        {
            //Se cambia la dirección cada medio segundo
            yield return new WaitForSeconds(0.5f);
            direccion = Random.Range(0, 2);
            Debug.Log(direccion);
        }
        
    }

    //  Si se colisiona con la pared, para comodidad visual, cambia la dirección para no parecer que choca
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Pared")
        {
            if(direccion == 1)
            {
                direccion = 0;
            }
            else
            {
                direccion = 1;
            }
        }
    }

}
