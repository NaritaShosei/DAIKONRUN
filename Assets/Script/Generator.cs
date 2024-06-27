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
    float _position = 5;
    // Start is called before the first frame update
    void Start()
    {
        
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
        if (_player.transform.position.x >= _position)
        {
            _randomItemSpawn.y = Random.Range(_startObject.transform.position.y, _endObject.transform.position.y);
            _randomItemSpawn.x = _startObject.transform.position.x;
            Instantiate(_wallPrefab, _randomItemSpawn, Quaternion.identity);
            _position += 5;
        }
    }
}
