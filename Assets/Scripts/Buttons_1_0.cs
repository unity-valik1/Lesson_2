using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Buttons_1_0 : MonoBehaviour
{
    public TMP_Text textPanelButtons;
    private Button button;
    private string newTextPanelButtons = "One Clicked";

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        textPanelButtons.text = newTextPanelButtons;
    }
}
