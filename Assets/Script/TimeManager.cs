using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField] float _timer = 30;
    public static float _time;
    Text _text;
    // Start is called before the first frame update
    void Start()
    {
        _text = GameObject.Find("TimerText").GetComponent<Text>();
        _time = _timer;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        _time -= Time.deltaTime;
        _text.text = _time.ToString();
    }
}
