using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject enemyBullet;

    public float modifier = 1;

    public ScoreSystem scoreScript;

    public EnemyFire enemyFireScript;

    public GameObject MainEnemy;

    public GameObject OrangeEnemy;

    public GameObject GreenEnemy;

    public GameObject RedEnemy;

    public float nextShot = 1.0f;

    public int EnemyFire;

    public float time = 0.0f;

    public void Reset(){
        MainEnemy.SetActive(true);
        OrangeEnemy.SetActive(true);
        GreenEnemy.SetActive(true);
        RedEnemy.SetActive(true);
    }

    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Ouch!");
        if(collision.gameObject.name == "Bullet(Clone)"){
            Destroy(collision.gameObject);
            //Debug.Log(gameObject.name);
            if(gameObject.name == "Enemy")
            {
                GetComponent<Animator>().SetTrigger("Death");
                MainEnemy = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("MainEnemy");
                gameObject.SetActive(false);
            }

            else if(gameObject.name == "OrangeEnemy")
            {
                GetComponent<Animator>().SetTrigger("OrangeDeath");
                OrangeEnemy = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("OrangeEnemy");
                gameObject.SetActive(false);
            }

            else if(gameObject.name == "GreenEnemy")
            {
                GetComponent<Animator>().SetTrigger("GreenDeath");
                GreenEnemy = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("GreenEnemy");
                gameObject.SetActive(false);
            }

            else if(gameObject.name == "RedEnemy")
            {
                GetComponent<Animator>().SetTrigger("RedDeath");
                RedEnemy = gameObject;
                scoreScript.GetComponent<ScoreSystem>().addScore("RedEnemy");
                gameObject.SetActive(false);
            }
            //Debug.Log("Ouch!");
            //Debug.Log(EnemyCount);
       }
    }
}
