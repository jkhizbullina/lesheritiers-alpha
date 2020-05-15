using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //private GameObject[] pickups;
    public static GameObject Tooltip, Menu, Screen, Gameplay, Background;
    public GameObject ScreenEditor, GameplayEditor, MenuEditor, BackmenuEditor, TooltipEditor, MainMenuEditor, BackgroundEditor;
    
    void Update()
    {
        if (Input.GetKeyDown("escape")) Application.Quit();
    }
    
    void Start()
    {
        Tooltip = TooltipEditor;
        Tooltip.SetActive(true);
        Menu = MenuEditor;
       
        Screen = ScreenEditor;
        Screen.SetActive(false);
        Gameplay = GameplayEditor;
        Gameplay.SetActive(false);
        Background = BackgroundEditor;
        BackgroundEditor.SetActive(false);

        MainMenuEditor.SetActive(true);
        BackmenuEditor.SetActive(true);
    }

    public void StartGame()
    {
        Tooltip.SetActive(true);
        BackmenuEditor.SetActive(false);
    }
}
