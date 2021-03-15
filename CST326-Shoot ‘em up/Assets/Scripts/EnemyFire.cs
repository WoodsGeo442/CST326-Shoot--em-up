using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{
    public GameObject enemyBullet;

    public Transform shottingOffsetSquare;

    public Transform orangeShottingOffsetSquare;

    public Transform greenShottingOffsetSquare;

    public Transform redShottingOffsetSquare;

    public GameManager gameManagerScript;

    public GameObject MainEnemy;

    public GameObject OrangeEnemy;

    public GameObject GreenEnemy;

    public GameObject RedEnemy;

    public float nextShot = 1.0f;

    public int EnemyNextShot;

    public float time = 0.0f;

    void Update()
    {
        EnemyNextShot = Random.Range(0, 4);
        Fire(EnemyNextShot);
    }

    void Fire(int enemyID)
    {
        time += Time.deltaTime;
        if (time > nextShot)
        {
            if (enemyID == 0)
            {
                nextShot += time;
                GameObject enemyShot = Instantiate(enemyBullet, shottingOffsetSquare.position, Quaternion.identity);
                nextShot -= time;
                time = 0.0f;
                Destroy(enemyShot, 3f);
                if (!MainEnemy.activeSelf && !OrangeEnemy.activeSelf && !GreenEnemy.activeSelf && !RedEnemy.activeSelf)
                {
                    gameManagerScript.GetComponent<GameManager>().endGame();
                }
            }
            else if (enemyID == 1)
            {
                nextShot += time;
                GameObject enemyShot = Instantiate(enemyBullet, orangeShottingOffsetSquare.position, Quaternion.identity);
                nextShot -= time;
                time = 0.0f;
                Destroy(enemyShot, 3f);
                if (!MainEnemy.activeSelf && !OrangeEnemy.activeSelf && !GreenEnemy.activeSelf && !RedEnemy.activeSelf)
                {
                    gameManagerScript.GetComponent<GameManager>().endGame();
                }
            }
            else if (enemyID == 2)
            {
                nextShot += time;
                GameObject enemyShot = Instantiate(enemyBullet, greenShottingOffsetSquare.position, Quaternion.identity);
                nextShot -= time;
                time = 0.0f;
                Destroy(enemyShot, 3f);
                if (!MainEnemy.activeSelf && !OrangeEnemy.activeSelf && !GreenEnemy.activeSelf && !RedEnemy.activeSelf)
                {
                    gameManagerScript.GetComponent<GameManager>().endGame();
                }
            }
            else if (enemyID == 3)
            {
                nextShot += time;
                GameObject enemyShot = Instantiate(enemyBullet, redShottingOffsetSquare.position, Quaternion.identity);
                nextShot -= time;
                time = 0.0f;
                Destroy(enemyShot, 3f);
                if (!MainEnemy.activeSelf && !OrangeEnemy.activeSelf && !GreenEnemy.activeSelf && !RedEnemy.activeSelf)
                {
                    gameManagerScript.GetComponent<GameManager>().endGame();
                }
            }

        }
    }
}
