using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
   public void MainMenu()
   {
    SceneManager.LoadScene("MainMenu");
   }
   public void CarScene()
   {
        SceneManager.LoadScene("CarScene");

   }
}
