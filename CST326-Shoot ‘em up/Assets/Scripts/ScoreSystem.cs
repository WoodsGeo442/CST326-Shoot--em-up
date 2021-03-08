using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private Text scoreText;

    [SerializeField] private Text hiScoreText;

    [SerializeField] private Text congratsText;

    public float score;

    public float hiScore;

    public BarricadeScript barricadeScript;

    public Enemy enemyScript;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        hiScore = 0;
    }

    public void RefreshScore()
    {
        score = 0;
        scoreText.text = "000" + score;
        barricadeScript.GetComponent<BarricadeScript>().Reset();
        enemyScript.GetComponent<Enemy>().Reset();
    }

    public void addScore(string enemyName)
    {
        Debug.Log("Score Recorded");
        if(enemyName == "EnemySquare")
        {
            score += 10;
        }

        else if(enemyName == "EnemyCircle")
        {
            score += 20;
        }

        else if(enemyName == "EnemyPentagon")
        {
            score += 50;
        }

        else if(enemyName == "EnemyCapsule")
        {
            score += 100;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            RefreshScore();
        }

        if(score >= 1000)
        {
            scoreText.text = "" + score;
        }
         else if (score >= 100)
        {
            scoreText.text = "0" + score;
        }

        else if (score >= 10)
        {
            scoreText.text = "00" + score;
        }

        else
        {
            scoreText.text = "000" + score;
        }

        if(score >= hiScore)
        {
            hiScore = score;
            if(score >= 1000)
            {
                hiScoreText.text = "" + hiScore;
            }
            else if (score >= 100)
            {
                hiScoreText.text = "0" + hiScore;
            }

            else if (score >= 10)
            {
                hiScoreText.text = "00" + hiScore;
            }

            else
            {
                hiScoreText.text = "000" + hiScore;
            }
        }
    }
}
