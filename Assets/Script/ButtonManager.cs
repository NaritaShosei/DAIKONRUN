using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] GameObject _explanationText;
    [SerializeField] GameObject _titleTexts;
    [SerializeField] GameObject _panelObj;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void GetText()
    {
        _explanationText.SetActive(true);
        _titleTexts.SetActive(false);
        _panelObj.SetActive(true);
    }
    public void TextFalse()
    {
        _explanationText.SetActive(false);
        _titleTexts.SetActive(true);
        _panelObj.SetActive(false);
    }
}
