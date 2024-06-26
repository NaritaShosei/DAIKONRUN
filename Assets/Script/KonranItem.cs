using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KonranItem : MonoBehaviour
{
    int _moveSpeedIndex;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var obj = collision.gameObject.GetComponent<DaikonMove>();
            _moveSpeedIndex = Random.Range(0, obj._moveSpeed.Length);
            obj._moveSpeed[_moveSpeedIndex] = obj._moveSpeed[_moveSpeedIndex] * -1;
            Debug.Log("‚Ô‚Â‚©‚Á‚½");
            Debug.Log(_moveSpeedIndex);
        }
    }
}
