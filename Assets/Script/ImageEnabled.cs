using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageEnabled : MonoBehaviour
{
    [SerializeField] Renderer _clearImage;
    [SerializeField] Renderer _gameOverImage;
    // Start is called before the first frame update
    void Start()
    {
        if (DistanceText.IsClear)
        {
            _clearImage.enabled = true;
            _gameOverImage.enabled = false;
        }
        if (!DistanceText.IsClear)
        {
            _clearImage.enabled = false;
            _gameOverImage.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
