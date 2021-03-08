using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBullet;

    public Transform shottingOffsetSquare;

    public float modifier = 1;

    public ScoreSystem scoreScript;

    public GameObject enemySquare;

    public GameObject enemyCircle;

    public GameObject enemyPentagon;

    public GameObject enemyCapsule;

    public float nextShot = 1.0f;

    public float time = 0.0f;

    //public int number;
    // Start is called before the first frame update

    void Update()
    {
        Fire();
    }

    void Fire()
    {
        time += Time.deltaTime;

        if(time > nextShot)
        {
            nextShot += time;
            GameObject enemyShot = Instantiate(enemyBullet, shottingOffsetSquare.position, Quaternion.identity);
            nextShot -= time;
            time = 0.0f;
            Destroy(enemyShot, 3f);
        }
    }

    public void Reset()
    {
        enemySquare.SetActive(true);
        enemyCircle.SetActive(true);
        enemyPentagon.SetActive(true);
        enemyCapsule.SetActive(true);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Bullet(Clone)"){
            Destroy(collision.gameObject);
            //Debug.Log(gameObject.name);
            if(gameObject.name == "EnemySquare")
            {
                enemySquare = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("EnemySquare");
                gameObject.SetActive(false);
            }

            else if(gameObject.name == "EnemyCircle")
            {
                enemyCircle = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("EnemyCircle");
                gameObject.SetActive(false);
            }

            else if(gameObject.name == "EnemyPentagon")
            {
                enemyPentagon = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("EnemyPentagon");
                gameObject.SetActive(false);
            }

            else if(gameObject.name == "EnemyCapsule")
            {
                enemyCapsule = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("EnemyCapsule");
                gameObject.SetActive(false);
            }
            Debug.Log("Ouch!");
        }
      
    }
}
