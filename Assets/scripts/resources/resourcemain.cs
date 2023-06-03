using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resourcemain : MonoBehaviour
{
    public void MainMenu()
   {
    SceneManager.LoadScene("MainMenu");
   }
   public void resources()
   {
        SceneManager.LoadScene("resources");

   }
   public void QuitApp()
   {
    Application.Quit();
   }
}
