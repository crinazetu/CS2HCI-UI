using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public Animator transition;
  
public void Update(){
  
  if (Input.GetKeyDown(KeyCode.Backspace)){
    //StartCoroutine(LoadSceneAnimated("Scan screen"));

    if (SceneManager.GetActiveScene().name == "BetterLook"){
    StartCoroutine(LoadSceneAnimated("Scan screen"));
  }

  if (SceneManager.GetActiveScene().name == "Login"){
    StartCoroutine(LoadSceneAnimated("StartScreen"));
  }

  if (SceneManager.GetActiveScene().name == "Camera Screen"){
    StartCoroutine(LoadSceneAnimated("Scan screen"));
  }
  }
  
}

  public void LoadScene(string sceneName) {

    StartCoroutine(LoadSceneAnimated(sceneName));
  }

  public IEnumerator LoadSceneAnimated(string SceneNameAnim){

   transition.SetTrigger("Start");
   yield return new WaitForSeconds(1);
   SceneManager.LoadScene(SceneNameAnim);
  }

}
