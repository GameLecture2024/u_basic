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
        Debug.Log("����� ��ư");
        SceneManager.LoadScene(1);
    }

    public void ButtonHome()
    {
        Debug.Log("���θ޴� ��ư");
        SceneManager.LoadScene(0);
    }

    public void ButtonExit()
    {
        Debug.Log("���� ���� ��ư");
        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
