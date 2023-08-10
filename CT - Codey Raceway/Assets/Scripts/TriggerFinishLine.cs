using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class TriggerFinishLine : MonoBehaviour
{
    public CheckpointCounter checkpointTracker;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (checkpointTracker.triggeredCheckpoints == checkpointTracker.numberOfCheckpoints)
            {
                print("You Win!");
                SceneManager.LoadScene(1);
            }
            else
            {
                print("Cheese man");
                SceneManager.LoadScene(2);
            }
        }
    }
}
