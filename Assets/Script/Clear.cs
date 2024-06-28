using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clear : MonoBehaviour
{
    [SerializeField] string _sceneName;
    // Start is called before the first frame update
    void Start()
    {
        DistanceText.IsClear = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("ÉNÉäÉA");
            DistanceText.IsClear = true;
            SceneChangeManager.SceneChange(_sceneName);
        }
    }
}
