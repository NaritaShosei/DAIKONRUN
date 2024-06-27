using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager : MonoBehaviour
{
    [SerializeField] string _sceneName;
    // Start is called before the first frame update
    public static void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
    public void GetScene()
    {
        SceneChange(_sceneName);
    }
}
