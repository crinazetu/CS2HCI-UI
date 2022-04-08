using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hovercode : MonoBehaviour
{
   public GameObject Infotext;
   private bool clicked = false;

   public void OnclickCarbon(){
       if (!clicked){
           Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y+200, 0);
       GameObject infoobject = Instantiate(Infotext, position, Quaternion.identity);
       infoobject.transform.SetParent(GameObject.Find("Sustainabilityinfo").transform);
       infoobject.GetComponent<hoverinfo>().information.text = "Amount of greenhouse gas emissions produced during growth, leading to climate change. Measured in kilograms of Carbon dioxide and equivalents per product.";
       clicked = !clicked;
       } else {
           OnUnclick();
       }
   }

    public void OnclickLand(){
       if (!clicked){
           Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y+200, 0);
       GameObject infoobject = Instantiate(Infotext, position, Quaternion.identity);
       infoobject.transform.SetParent(GameObject.Find("Sustainabilityinfo").transform);
       infoobject.GetComponent<hoverinfo>().information.text = "Area of land taken for crops or livestock, measured in metres squared per product.";
       clicked = !clicked;
       } else {
           OnUnclick();
       }
   }

    public void OnclickWater(){
       if (!clicked){
           Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y+200, 0);
       GameObject infoobject = Instantiate(Infotext, position, Quaternion.identity);
       infoobject.transform.SetParent(GameObject.Find("Sustainabilityinfo").transform);
       infoobject.GetComponent<hoverinfo>().information.text = "Freshwater withdrawals made to produce this item, increasing water scarcity, measured in litres per product.";
       clicked = !clicked;
       } else {
           OnUnclick();
       }
   }

    public void OnclickEutro(){
       if (!clicked){
           Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y+200, 0);
       GameObject infoobject = Instantiate(Infotext, position, Quaternion.identity);
       infoobject.transform.SetParent(GameObject.Find("Sustainabilityinfo").transform);
       infoobject.GetComponent<hoverinfo>().information.text = "The runoff of excess nutrients into the surrounding environment, polluting ecosytems. Measured in grams of phosphate equivalents per product.";
       clicked = !clicked;
       } else {
           OnUnclick();
       }
   }

    public void OnclickFoodMiles(){
       if (!clicked){
           Vector3 position = new Vector3(Input.mousePosition.x, Input.mousePosition.y+200, 0);
       GameObject infoobject = Instantiate(Infotext, position, Quaternion.identity);
       infoobject.transform.SetParent(GameObject.Find("Sustainabilityinfo").transform);
       infoobject.GetComponent<hoverinfo>().information.text = "Distance travelled from the origin to this store, measured in miles per product.";
       clicked = !clicked;
       } else {
           OnUnclick();
       }
   }

   public void OnUnclick(){
      
      Destroy(GameObject.Find("hoverinfo(Clone)"));
      clicked = !clicked;
       
   }
}
