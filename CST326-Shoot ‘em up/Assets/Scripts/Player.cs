using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bullet;
    private Animator playerAnimator;

    public Transform shottingOffset;

    public GameObject characterPlayer;

    public GameManager gameManagerScript;

    public float modifier = 1;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
    }

    public void RespawnPlayer(){
        characterPlayer.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxis("Horizontal");
      transform.Translate((transform.right*-1) * horizontal * modifier* Time.deltaTime);
      if (Input.GetKeyDown(KeyCode.Space))
      {

        playerAnimator.SetTrigger("Shoot");
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");
        Destroy(shot, 3f);
      }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(collision.gameObject); // destroy bullet
        //Debug.Log("Ouch!");
        if(collision.gameObject.name == "EnemyBullet(Clone)"){
            Destroy(collision.gameObject);
            GetComponent<Animator>().SetTrigger("PlayerDeath");
            characterPlayer = gameObject;
            gameObject.SetActive(false);
            gameManagerScript.GetComponent<GameManager>().endGame();
        }
    }
}
