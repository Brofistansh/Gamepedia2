using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class scenecontroller : MonoBehaviour
{
   public void MainMenu()
   {
    SceneManager.LoadScene("MainMenu");
   }
   public void ARscene()
   {
        SceneManager.LoadScene("ARscene");

   }
   public void QuitApp()
   {
    Application.Quit();
   }
}
