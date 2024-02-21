using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FiilAnimation : MonoBehaviour
{
    [SerializeField] private Image _image;
    private float _time = 0;
    int colorValue = 255;



    private void Update()
    {
        // _image.fillAmount = _time;
        //_time += Time.deltaTime / 10;

        _image.color = new Color(_time * colorValue, _time * colorValue, _time * colorValue);
        _time += Time.deltaTime / 10;


    }

}
