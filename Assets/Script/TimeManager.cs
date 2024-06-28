using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] float _timer = 30;
    static float _time;
    Text _text;
    [SerializeField] TextKind _textKind;
    [SerializeField] GameObject _clearSound;
    [SerializeField] GameObject _gameOverSound;
    enum TextKind
    {
        timerText,
        resultText
    }

    // Start is called before the first frame update
    void Start()
    {
        _text = GameObject.Find("TimerText").GetComponent<Text>();
        if (_textKind == TextKind.timerText)
        {
            _time = _timer;
        }
    }

    // Update is called once per frame
    void Update()
    {
        switch (_textKind)
        {
            case TextKind.timerText:
                InGame();
                break;
            case TextKind.resultText:
                Result();
                break;
        }
    }
    void InGame()
    {
        _time -= Time.deltaTime;
        _text.text = "êßå¿éûä‘ : " + _time.ToString("F2");
        if (_time <= 0)
        {
            SceneChangeManager.SceneChange("Result");
        }
    }
    void Result()
    {
        if (_time > 0)
        {
            _text.text = (_timer - _time).ToString("F2") + "ïbÇ≈ÉNÉäÉAÇµÇΩ";
            _gameOverSound.SetActive(false);
        }
        else if (_time <= 0)
        {
            _text.text = "éûä‘êÿÇÍ!!!";
            _clearSound.SetActive(false);
        }
    }
}
