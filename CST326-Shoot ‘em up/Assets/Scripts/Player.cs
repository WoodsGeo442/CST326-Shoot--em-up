using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
  public GameObject bullet;

  public Transform shottingOffset;

  public float modifier = 1;

    // Update is called once per frame
    void Update()
    {
      float horizontal = Input.GetAxis("Horizontal");
      transform.Translate(transform.right * horizontal * modifier* Time.deltaTime);
      if (Input.GetKeyDown(KeyCode.Space))
      {
        GameObject shot = Instantiate(bullet, shottingOffset.position, Quaternion.identity);
        Debug.Log("Bang!");

        Destroy(shot, 3f);

      }
    }
}
