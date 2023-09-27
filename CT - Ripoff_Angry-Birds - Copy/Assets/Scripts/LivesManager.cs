using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivesManager : MonoBehaviour
{
    public int lives;
    public GameObject[] hearts;
    public GameObject slime;

    public void RemoveLife()
    {
        if (lives > 0)
        {
            lives -= 1;
            hearts[lives].SetActive(false);
            print("Imagine LOsing a Lifeeee!! Lives: " + lives);
        }

        if (lives <= 0)
        {
            slime.SetActive(false);
            SceneManager.LoadScene(0);
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
