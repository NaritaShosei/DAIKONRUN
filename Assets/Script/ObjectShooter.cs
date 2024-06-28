using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ObjectShooter : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] float _interval;
    float _timer = 0;
    [SerializeField] float _speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer >= _interval)
        {
            if (Input.GetKey(KeyCode.Return))
            {
                Instantiate(_prefab, transform.position, Quaternion.identity);
                _timer = 0;
            }
        }
        if (transform.position.y < 3.5f)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += transform.up * _speed * Time.deltaTime;
            }
        }
        if (transform.position.y > -3.5f)
        {
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position += transform.up * -_speed * Time.deltaTime;
            }
        }
    }
}
