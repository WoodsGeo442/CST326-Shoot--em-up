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

    public void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
        Destroy(collision.gameObject);
    }
}
