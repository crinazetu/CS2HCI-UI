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
       infoobject.GetComponent<hoverinfo>().information.text = "Amount of Carbon Dioxide emissions produced during manufacture and delivery.";
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
       infoobject.GetComponent<hoverinfo>().information.text = "Area of land taken to produce this item.";
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
       infoobject.GetComponent<hoverinfo>().information.text = "Amount of water used to produce this item.";
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
       infoobject.GetComponent<hoverinfo>().information.text = "Eutrophying emissions info";
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
       infoobject.GetComponent<hoverinfo>().information.text = "Food miles info";
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
