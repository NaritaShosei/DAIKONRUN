using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatol2P : MonoBehaviour
{
    [Header("スポーンしたいもの")]
    [SerializeField] GameObject _itemPrefab;
    [Header("スポーンのインターバル")]
    [SerializeField] float _interval;
    float _timer = 0;
    [Header("ここに入れたオブジェクトとのランダムな間に生成する")]
    [SerializeField] GameObject _startObject;
    [SerializeField] GameObject _endObject;
    Vector2 _randomItemSpawn = new Vector2(0, 0);
    [SerializeField] GameObject _wallPrefab;
    [SerializeField] GameObject _player;
    float _position = 5;
    [SerializeField] float _endPos;
    float _pulusPos = 6;
    // Start is called before the first frame update
    void Start()
    {
        while (_position < _endPos)
        {
            _randomItemSpawn.y = Random.Range(-2,2);
            _randomItemSpawn.x = _position + _pulusPos;
            Instantiate(_wallPrefab,_randomItemSpawn,Quaternion.identity);
            _position += 6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
//float _pos;
//float _endPos;

//while (_pos < _endPos)
//{
//    int index = Random.Range(0, 10)
//  Instansiate(WallPrefab, new Vector2(_pos, (float)index), Quartanion.Indentity);
//    _pos += 5;
//}
