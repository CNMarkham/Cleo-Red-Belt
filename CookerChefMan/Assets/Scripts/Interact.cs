 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Toaster toaster;

    public string triggerName = "";

    public GameObject breadPrefab;

    public GameObject heldItem;
    public string heldItemName;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "bread")
            {
                HandBread();
                heldItemName = "breadSlice";
            }

            if (triggerName == "Toaster")
            {
                Debug.Log("Im at the Toaster!");
                if(heldItemName == "breadSlice")
                {
                    toaster.ToastBread();
                    PlaceHeldItem();

/*                    print("Ready to Toast!");
                    Destroy(heldItem);
                    heldItemName = "";
                    toaster.ToastBread();*/
                }
                else
                {
                    print("Codey is empty Handed");
                    if(toaster.cookedFood == "toast")
                    {
                        HandBread();
                        heldItemName = "toastSlice";
                        toaster.CleanToaster();

                    }
                }

            }


            if (triggerName == "Receivers")
            {
                PlaceHeldItem();
                GameObject.Find("Everything/FoodOnPlate/Receivers/FrenchToast/toastSlice").SetActive(true);
            }
        }

     
    }

    private void HandBread()
    {
        heldItem = Instantiate(breadPrefab, transform, false);
        heldItem.transform.localPosition = new Vector3(1, 1, 0);
        heldItem.transform.localScale = new Vector3(3, 3, 3);
    }

    private void PlaceHeldItem()
    {
        Destroy(heldItem);
        heldItemName = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }

    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}
