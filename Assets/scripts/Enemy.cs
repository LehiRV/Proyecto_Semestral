using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Enemy : MonoBehaviour {

    Rigidbody2D rb;

    public float timerSpeed = 2.0f;
    public float speed = 2.0f;
    public float timer;
    public float timeToMove;
    public float xPos;
    public Vector3 desiredPos;
    void Start()
    {
        xPos = Random.Range(-4.5f, 4.5f);
        desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
    }

    void Update()
    {
        timer += Time.deltaTime * timerSpeed;
        if (timer >= timeToMove)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * speed);
            if (Vector3.Distance(transform.position, desiredPos) <= 0.01f)
            {
                xPos = Random.Range(-4.5f, 4.5f);
                desiredPos = new Vector3(xPos, transform.position.y, transform.position.z);
                timer = 0.0f;
            }
        }
    }

   
}



