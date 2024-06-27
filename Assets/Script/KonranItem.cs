using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonranItem : MonoBehaviour
{
    [SerializeField] float _moveSpeed;
    Rigidbody2D _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _rigidbody.velocity = new Vector2(-_moveSpeed, 0);
    }

    // Update is called once per frame
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
