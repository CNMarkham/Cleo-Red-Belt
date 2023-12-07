 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toaster : MonoBehaviour
{

    [Header("Prefrabs")]
    public GameObject friedEgg;
    public GameObject toast;

    [Header("Inventory")]
    public string cookedFood = "";

    [Header("Particles")]
    public ParticleSystem smoke;
    public ParticleSystem complete;

    // Start is called before the first frame update
    void Start()
    {
        toast.SetActive(false);
    }

    public void ToastBread()
    {
        smoke.Play();
        toast.SetActive(true);
        Invoke("CompleteToasting", 6f);
    }

    public void CleanToaster()
    {
        toast.SetActive(false);
        cookedFood = "";
        complete.Stop();
    }

    private void CompleteToasting()
    {
        cookedFood = "toastSlice";
        smoke.Stop();
        complete.Play();
    }

    // when complete is played than codey is able to pick up the food :) You can not take the food when the smoke is playing and the complete is not playing qw
}
