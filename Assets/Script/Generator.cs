using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
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
    float _position;
    [SerializeField] float _endPos;
    float _plusPos;
    // Start is called before the first frame update
    void Start()
    {
        _position = this.transform.position.x - 3;
        while (_position < _endPos)
        {
            _randomItemSpawn.y = Random.Range(-2, 2);
            _randomItemSpawn.x = _position + _plusPos;
            Instantiate(_wallPrefab, _randomItemSpawn, Quaternion.identity);
            _position += 6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _interval)
        {
            _randomItemSpawn.y = Random.Range(_startObject.transform.position.y, _endObject.transform.position.y);
            _randomItemSpawn.x = _startObject.transform.position.x;
            Instantiate(_itemPrefab, _randomItemSpawn, Quaternion.identity);
            _timer = 0;
        }
    }
}
