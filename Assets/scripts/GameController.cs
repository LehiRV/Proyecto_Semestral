using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{





    public static int score = 20;


    void Start()
    {

      

    }


    void Update()
    {

    }



    public void lose()
    {
        GameObject txtObj = GameObject.Find("gameOverText");
        Text txt = txtObj.GetComponent<Text>();
        txt.enabled = true;


        if (score > PlayerPrefs.GetInt("hScore"))
        {
            PlayerPrefs.SetInt("hScore", score);

        }

        score = 20;

        StartCoroutine("loseProcess");

    }
    IEnumerator loseProcess()
    {
        yield return new WaitForSeconds(3);

    }


}
