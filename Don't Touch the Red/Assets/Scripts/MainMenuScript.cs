using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    
   public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public GameObject CreditWindow;
   
   public void ShowCredits()
    {
        CreditWindow.SetActive(true); 
    }

    public void CloseCredits()
    {
        CreditWindow.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}   

