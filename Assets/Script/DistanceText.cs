using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class DistanceText : MonoBehaviour
{
    float _dis;
    static float _distance;
    [SerializeField] GameObject _playerObject;
    [SerializeField] GameObject _endObject;
    Text _text;
    public static bool IsClear;
    [SerializeField] TextKind _textKind;
    enum TextKind
    {

        distanceText,
        resultText
    }
    // Start is called before the first frame update
    void Start()
    {
        _text = GameObject.Find("DistanceText").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (_textKind)
        {
            case TextKind.distanceText:
                InGame();
                break;
            case TextKind.resultText:
                Result();
                break;
        }

    }
    void InGame()
    {
        _dis = Vector2.Distance(_playerObject.transform.position, _endObject.transform.position);
        _distance = _dis;
        _text.text = "�S�[���܂�" + _distance.ToString("F0") + "m";
    }
    void Result()
    {
        if (_distance > 50)
        {
            _text.text = "�S�[���܂Ŏc��" + _distance.ToString("F0") + "���������I�I\n�ӂ����Ă�H";
        }
        else if (_distance > 1 && !IsClear)
        {
            _text.text = "�S�[���܂Ŏc��" + _distance.ToString("F0") + "���������I�I\n�ɂ�����";
        }
        else if (IsClear)
        {
            _text.text = "�S�[�����߂łƂ��I�I";
        }
    }
}
