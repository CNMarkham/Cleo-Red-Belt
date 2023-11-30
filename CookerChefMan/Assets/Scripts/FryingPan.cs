using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPan : MonoBehaviour
{
    [Header("Prefrabs")]
    public GameObject friedEgg;

    [Header("Inventory")]
    public string cookedFood = "";

    [Header("Particles")]
    public ParticleSystem smoke;
    public ParticleSystem complete;

    // Start is called before the first frame update
    void Start()
    {
        friedEgg.SetActive(false);
    }

    public void FriedEgg()
    {
        smoke.Play();
        friedEgg.SetActive(true);
        cookedFood = "friedEgg";
        
    }

    public void CleanPan()
    {
        friedEgg.SetActive(false);
        cookedFood = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
