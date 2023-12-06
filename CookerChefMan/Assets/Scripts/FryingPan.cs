using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FryingPan : MonoBehaviour
{
    [Header("Prefrabs")]
    public GameObject friedEgg;

    [Header("Inventory")]
    public string cookedFood = "";
    public bool isCooking = false;

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
        isCooking = true;
        smoke.Play();
        friedEgg.SetActive(true);
        Invoke("CompleteCooking", 8f);
        
    }

    public void CleanPan()
    {
        friedEgg.SetActive(false);
        cookedFood = "";
        complete.Stop();
    }

    private void CompleteCooking()
    {        
        cookedFood = "friedEgg";
        isCooking = false;
        smoke.Stop();
        complete.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
