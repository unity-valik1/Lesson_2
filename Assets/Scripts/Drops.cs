using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Drops : MonoBehaviour
{
    [SerializeField] private TMP_Text textTop;
    [SerializeField] private TMP_Text textDrops;

    public void ActiveText()
    {
        textTop.text = textDrops.text;
    }
}
