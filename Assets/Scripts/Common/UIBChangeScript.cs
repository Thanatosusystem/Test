using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class UIBChangeScript : MonoBehaviour
{
    [SerializeField]
    private Button[] _buttons = null;

    [SerializeField]
    private Color _normalColor = new Color();
    [SerializeField]
    private Color _highlightedColor = new Color();
    [SerializeField]
    private Color _pressedColor = new Color();
    [SerializeField]
    private Color _disabledColor = new Color();


    /// <summary>
    /// ボタンの色を初回に変更する
    /// </summary>
    private void Awake()
    {
        for (int i = 0; i < _buttons.Length; i++)
        {
            Debug.Log(i);
            ColorBlock cb = _buttons[i].colors;
            cb.normalColor = _normalColor;
            cb.highlightedColor = _highlightedColor;
            cb.pressedColor = _pressedColor;
            cb.disabledColor = _disabledColor;
            _buttons[i].colors = cb;
        }
    }

}
