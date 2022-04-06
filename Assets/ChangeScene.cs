using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
  public Animator transition;
  
public void Update(){
  if (SceneManager.GetActiveScene().name == "BetterLook" && Input.GetKeyDown(KeyCode.Backspace)){
    StartCoroutine(LoadSceneAnimated("Scan screen"));
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
