using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaikonMove : MonoBehaviour
{
    [Header("移動のスピード0が横1が縦")]
    public float[] _moveSpeed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal") * _moveSpeed[0] * Time.deltaTime, 0, 0);
        transform.position += new Vector3(0, Input.GetAxisRaw("Vertical") * _moveSpeed[1] * Time.deltaTime, 0);
    }
}
