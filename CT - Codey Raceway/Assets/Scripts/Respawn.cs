using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("UtouchUdie"))
        {
            SceneManager.LoadScene(0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
