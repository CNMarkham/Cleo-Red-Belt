 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour
{

    public GameObject breadPrefab;
    public GameObject eggPrefab;
    public GameObject friedEggPrefab;

    public Toaster toaster;
    public FryingPan pan;

    public string triggerName = "";

    public GameObject heldItem;
    public string heldItemName;

    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "bread")
            {
                PickupItem(breadPrefab, "breadSlice");
            }

            if (triggerName == "Egg")
            {
                PickupItem(eggPrefab, "egg");
            }

            if (triggerName == "Toaster")
            {
                Debug.Log("Im at the Toaster!");
                if (heldItemName == "breadSlice")
                {
                    toaster.ToastBread();
                    PlaceHeldItem();
                }
                else
                {
                    print("Codey is empty Handed");
                    if (!toaster.smoke.isPlaying && toaster.cookedFood == "toastSlice")
                    {
                        PickupItem(breadPrefab, "toastSlice");
                        toaster.CleanToaster();

                    }
                }


            }
            if (triggerName == "FryingPan")
            {
                Debug.Log("Im at the FryingPan!");
                if (heldItemName == "egg")
                {
                    pan.FriedEgg();
                    PlaceHeldItem();
                }
            }
            else
            {
                print("Codey is empty Handed");
                if (!pan.smoke.isPlaying && pan.cookedFood == "friedEgg")
                {
                    PickupItem(friedEggPrefab, "friedEgg");
                    pan.CleanPan();
                }
            }

            if (triggerName == "Receivers")
            {
                if (heldItemName == "toastSlice")
                {
                    PlaceHeldItem();
                    GameObject.Find("Everything/FoodOnPlate/Receivers/Receivers1/FrenchToast/toastSlice").SetActive(true);
                    
                }
                if (heldItemName == "friedEgg")
                {
                    PlaceHeldItem();
                    GameObject.Find("Everything/FoodOnPlate/Receivers/Receivers1/FrenchToast/egg").SetActive(true);
                }

            }
        }

     
    }

    private void PickupItem(GameObject itemPrefab, string itemName)
    {
        heldItem = Instantiate(itemPrefab, transform, false);
        heldItem.transform.localPosition = new Vector3(1, 1, 0);
/*        heldItem.transform.localScale = new Vector3(3, 3, 3);*/
        heldItemName = itemName;
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
