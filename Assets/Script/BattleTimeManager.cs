using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleTimeManager : MonoBehaviour
{
    float _time = 0;
    static float _timer;
    Text _text;
    [SerializeField] TextKind _textKind;
    enum TextKind
    {
        battleText,
        battleResultText
    }
    // Start is called before the first frame update
    void Start()
    {
        _text = GameObject.Find("TimerText").GetComponent<Text>();
        if (_textKind == TextKind.battleText)
        {
            _timer = _time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (_textKind)
        {
            case TextKind.battleText:
                BattleInGame();
                break;
            case TextKind.battleResultText:
                BattleResult();
                break;
        }
    }
    void BattleInGame()
    {
        _timer += Time.deltaTime;
        _text.text = "Œo‰ßŽžŠÔ : " + _timer.ToString("F2");
        if (_timer <= 0)
        {
            SceneChangeManager.SceneChange("BattleResult");
        }
    }
    void BattleResult()
    {
        _text.text = _timer.ToString("F2") + "‚ÅƒS[ƒ‹!!!";
    }
}
