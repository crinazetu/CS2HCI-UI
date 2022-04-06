using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnableItemsInBag : MonoBehaviour
{
    public GameObject ItemsInBag;
    public GameObject EmptyBag;
    public GameObject PopupCanvas;
    public GameObject scrollContent;
    public GameObject ProductTemplate;

    public void Update() {
        if (scriptforbool.ShowItms){
            EnableItemsInBagcmd();
        }
    }
    public void EnableItemsInBagcmd(){
        EmptyBag.SetActive(false);
        ItemsInBag.SetActive(true);
    }

    public void OnClickPoppup(){
        PopupCanvas.SetActive(true);
    }

    public void IfPressedNo(){
        PopupCanvas.SetActive(false);
    }
    
    public void IfPressedYes(){
        Destroy(scrollContent.transform.Find("better product prefab").gameObject);
        Instantiate(ProductTemplate);
        ProductTemplate.GetComponent<productdetails>().ProductName.text = "Better Product";
        IfPressedNo();
    }
  
}
