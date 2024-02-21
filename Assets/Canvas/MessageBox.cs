using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MessageBox : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _boxTextUI;

    public static MessageBox Instante;

    private void Awake()
    {
        if (Instante == null)
        {
            Instante = this;
        }
        else
        {
            Destroy(gameObject);
        }
        gameObject.SetActive(false);
    }

    public void SetText(string text)
    {
        _boxTextUI.text = text;
    }
}
