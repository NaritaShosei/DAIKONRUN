using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaikonMove : MonoBehaviour
{
    [Header("移動のスピード0が横1が縦")]
    public float[] _moveSpeed;
    int _index;
    Rigidbody2D _rb;
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            _rb.velocity = Vector2.left * _moveSpeed[0] + Vector2.up * _rb.velocity.y;
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.velocity = Vector2.right * _moveSpeed[0] + Vector2.up * _rb.velocity.y;
        }
        if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity = Vector2.up * _moveSpeed[1] + Vector2.right * _rb.velocity.x;
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.velocity = Vector2.down * _moveSpeed[1] + Vector2.right * _rb.velocity.x;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            _rb.velocity = Vector2.right * 0 + Vector2.up * _rb.velocity.y;
        }
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            _rb.velocity = Vector2.up * 0 + Vector2.right * _rb.velocity.x;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Item")
        {
            _index = Random.Range(0, 3);
            if (_index < _moveSpeed.Length)
            {
                _moveSpeed[_index] = _moveSpeed[_index] * -1;
            }
            Destroy(collision.gameObject);
            Debug.Log("ぶつかった");
            Debug.Log(_index);
        }
    }
}
