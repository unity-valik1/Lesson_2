using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private TMP_Text textPanelButtons;
    [SerializeField] private Button[] buttons;
    private string[] newTextPanelButtons = { "One Clicked" , "Two Clicked"};

    public void TextButtons(int index)
    {
        textPanelButtons.text = newTextPanelButtons[index];
    }
    public void DisableButton()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = false;
        }
    }
    public void ActiveButtons()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].interactable = true;
        }
    }
}
