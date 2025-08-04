using TMPro;
using UnityEngine;

public class TitleLocalize : MonoBehaviour
{
    TextMeshProUGUI titleText;

    [SerializeField] private string engTitle;
    [SerializeField] private string korTitle;
    public bool IsKorean = true;

    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        //titleText.text = "플랫폼 게임";
        //titleText.SetText("플랫폼 게임2");
        // IsKorean true일때 한국어타이틀, IsKorean false일때 영어타이틀
        if (IsKorean)
            titleText.SetText(korTitle);
        else 
            titleText.SetText(engTitle);
    }
}
