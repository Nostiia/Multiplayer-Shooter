using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private GameObject _chooseAvatarCanvas;
    [SerializeField] private GameObject _mainMenuCanvas;
    private void Start()
    {
        _chooseAvatarCanvas.SetActive(false);
        _mainMenuCanvas.SetActive(true);
    }
    public void CreateRoom()
    {
        Debug.Log("CreateRoomButton");
    }

    public void Connect()
    {
        Debug.Log("Connect Button");
    }

    public void ChooseAvater()
    {
        _chooseAvatarCanvas.SetActive(true);
        _mainMenuCanvas.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ActivateMainMenu()
    {
        _mainMenuCanvas.SetActive(true);
    }
    public void DeactivateChooseAvatar()
    {
        _chooseAvatarCanvas.SetActive(false);
    }

    public void CloseChooseAvatar()
    {
        _chooseAvatarCanvas.SetActive(false);
        _mainMenuCanvas.SetActive(true);
    }

}
