using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    //panels/canvases on main menu (scene 1)
    [SerializeField] public GameObject settingsPanel;
    [SerializeField] public GameObject loadPanel;
    [SerializeField] public GameObject aboutPanel;
    [SerializeField] public GameObject quitConfirmationPanel;
    [SerializeField] private GameObject panelToHide;    //to assign ANY panel in inspector

    //buttons on main menu (scene 1)
    [SerializeField] Button startButton;
    [SerializeField] Button settinsButton;
    [SerializeField] Button closeSettinsButton;
    [SerializeField] Button loadButton;
    [SerializeField] Button closeLoadButton;
    [SerializeField] Button aboutButton;
    [SerializeField] Button closeAboutButton;
    [SerializeField] Button quitButton;           
    [SerializeField] Button confQuitButton;
    [SerializeField] Button denyQuitButton;

    public void StartGame()
    {
        if (startButton)
        {
            SceneManager.LoadScene(1);  //on start load Chapter 1 scene
        }
    }
    public void LoadSaves()
    {
        if (loadButton)
        {
            loadPanel.SetActive(true);
        }
    }
    public void Settings()
    {
        if (settinsButton)
        {
            settingsPanel.SetActive(true);  
        }
    }
    public void About()
    {
        if (aboutButton)
        {
            aboutPanel.SetActive(true);
        }
    }
    public void QuitConfirmation()
    {        
        if (quitButton)
        {
            quitConfirmationPanel.SetActive(true);   
        }
    }
    public void YesQuit()
    {
        if (confQuitButton)
        {
            Application.Quit(); //close application after confirming on conf screen
        }
    }

    public void HidePanel()  //hide assigned panel
    {
        if (panelToHide != null)
            panelToHide.SetActive(false);   //if theres a panel active(true) - hide it
    }
}
