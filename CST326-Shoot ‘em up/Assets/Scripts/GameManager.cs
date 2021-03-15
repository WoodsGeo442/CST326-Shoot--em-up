using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject congratsText;

    public GameObject loserText;

    public Enemy enemyScript;

    public ScoreSystem scoringScript;

    public Player playerScript;

    public GameObject player;

    public float congratsTimer = 1.0f;

    public float time = 0.0f;

    public void endGame()
    {
        if(!player.activeSelf){
            loserText.SetActive(true);
            Invoke("credits", 3);
        } else {
            congratsText.SetActive(true);
            Invoke("credits", 3);
        }
    }

    public void credits()
    {
        enemyScript.GetComponent<Enemy>().Reset();
        scoringScript.GetComponent<ScoreSystem>().RefreshScore();
        playerScript.GetComponent<Player>().RespawnPlayer();
        SceneManager.LoadScene(2);
    }


}
