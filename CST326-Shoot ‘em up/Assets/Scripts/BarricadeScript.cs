using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadeScript : MonoBehaviour
{
    public GameObject Barricade1;
    public GameObject Barricade2;
    public GameObject Barricade3;
    public GameObject Barricade4;
    public GameObject Barricade5;
    public GameObject Barricade6;
    public GameObject Barricade7;
    public GameObject Barricade8;
    public GameObject Barricade9;
    public GameObject Barricade10;
    public GameObject Barricade11;
    public GameObject Barricade12;
    public GameObject Barricade13;
    public GameObject Barricade14;
    public GameObject Barricade15;
    public GameObject Barricade16;

    public void Reset()
    {
        Barricade1.SetActive(true);
        Barricade2.SetActive(true);
        Barricade3.SetActive(true);
        Barricade4.SetActive(true);
        Barricade5.SetActive(true);
        Barricade6.SetActive(true);
        Barricade7.SetActive(true);
        Barricade8.SetActive(true);
        Barricade9.SetActive(true);
        Barricade10.SetActive(true);
        Barricade11.SetActive(true);
        Barricade12.SetActive(true);
        Barricade13.SetActive(true);
        Barricade14.SetActive(true);
        Barricade15.SetActive(true);
        Barricade16.SetActive(true);

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        Destroy(collision.gameObject);
    }
}
