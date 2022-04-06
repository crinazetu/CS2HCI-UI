using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hovercode : MonoBehaviour
{
   public GameObject Infotext;

   public void OnHoverCarbon(){
       GameObject infoobject = Instantiate(Infotext, Input.mousePosition, Quaternion.identity);
       infoobject.transform.SetParent(GameObject.Find("Sustainabilityinfo").transform);
       infoobject.GetComponent<hoverinfo>().information.text = "Carbon footprint info";
   }

   public void OnExitHover(){
      Destroy( GameObject.Find("hoverinfo(Clone)"));
   }
}
