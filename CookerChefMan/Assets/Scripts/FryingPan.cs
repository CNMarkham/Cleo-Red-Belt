using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPan : MonoBehaviour
{
    public GameObject friedEgg;

    public string cookedFood = "";

    // Start is called before the first frame update
    void Start()
    {
        friedEgg.SetActive(false);
    }

    public void FriedEgg()
    {
        friedEgg.SetActive(true);
        cookedFood = "friedEgg";
        
    }

    public void CleanPan()
    {
        friedEgg.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
