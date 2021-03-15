using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditsScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("credits", 5);
    }

    public void credits()
    {
        SceneManager.LoadScene(0);
    }
}
