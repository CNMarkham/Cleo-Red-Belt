using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DEATH : MonoBehaviour
{

    private void OnCollisionEnter(Collision collider)
    {
        SceneManager.LoadScene(3);
    }



}
