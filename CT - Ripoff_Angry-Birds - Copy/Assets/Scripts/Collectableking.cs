using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectableking : MonoBehaviour
{
    private void OnCollisionEnter(Collision C)
    {
        if (C.gameObject.CompareTag("Player"))
        {
            gameObject.SetActive(false);
            SceneManager.LoadScene(0);
        }
    }
}
