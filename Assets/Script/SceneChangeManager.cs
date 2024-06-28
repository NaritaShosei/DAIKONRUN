using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    [SerializeField] string _sceneName;
    [SerializeField] float _invokeTime = 1f;
    AudioSource _audioSource;
    bool _isPlaying = true;
    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    public static void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GetScene()
    {
        Invoke(nameof(Scene), _invokeTime);
    }
    void Scene()
    {
        SceneChange(_sceneName);
    }
    public void AudioPlay()
    {
        if (_isPlaying)
        {
            _audioSource.Play();
        }
        _isPlaying = false;
    }
}
