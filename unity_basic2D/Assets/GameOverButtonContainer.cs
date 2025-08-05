using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButtonContainer : MonoBehaviour
{
    public void ButtonRestart()
    {
        Debug.Log("재시작 버튼");
        SceneManager.LoadScene(1);
    }

    public void ButtonHome()
    {
        Debug.Log("메인메뉴 버튼");
        SceneManager.LoadScene(0);
    }

    public void ButtonExit()
    {
        Debug.Log("게임 종료 버튼");
        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
