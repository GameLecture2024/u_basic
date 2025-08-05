using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEditor;

public class IntroButtonContainer : MonoBehaviour
{
    // 4개의 버튼이 포함되어 있습니다.  시작, 튜토리얼, 옵션, 종료

    public void ButtonStart()
    {
        Debug.Log("게임을 시작합니다.");

        SceneManager.LoadScene(1);

    }

    public void ButtonTutorial(GameObject tut)
    {
        Debug.Log("튜토리얼을 실행합니다.");

        tut.SetActive(true);
    }

    public void ButtonOption(GameObject opt)
    {
        Debug.Log("옵션 버튼이 활성화됩니다.");

        opt.SetActive(true);
    }

    public void ButtonExit()
    {
        Debug.Log("게임을 종료합니다.");

        Application.Quit();

#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#endif
    }
}
