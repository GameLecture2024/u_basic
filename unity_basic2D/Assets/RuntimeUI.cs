using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeUI : MonoBehaviour
{
    [Header("목숨 Life")]
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Image lifeImage;
    [Header("동전 Coin")]
    [SerializeField] private TextMeshProUGUI coinText;
    [Header("시간 Time")]
    [SerializeField] private TextMeshProUGUI timeText;
    private float timeValue = 60;
    [Header("점수 Score")]
    [SerializeField] private TextMeshProUGUI scoreText;

    public void OnLifeUpdated(int lifeAmount) // 목숨이 변경되었을 때 ( 증가, 감소 ) 텍스트 Ui로 출력해주세요.
    {
        lifeText.SetText($"X{lifeAmount}");
    }

    public void OnCoinUpdated(int coinAmount)
    {
        // coin의 갯수가 음수가 되면?

        coinText.SetText($"X{coinAmount}");
    }

    public void OnTimeUpdated()
    {
        timeText.SetText($"{timeValue}");
    }
    public void OnScoreUpdated()
    {

    }

    private void Update()
    {
        timeValue -= Time.deltaTime;
        OnTimeUpdated();
    }
}
