using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Buttons : MonoBehaviour
{
    [SerializeField] private TMP_Text textPanelButtons;
    [SerializeField] private Button[] buttons;
    private string newTextPanelButtons;

    public void OneButton()
    {
        newTextPanelButtons = "One Clicked";
        textPanelButtons.text = newTextPanelButtons;
    }
    public void TwoButton()
    {
        newTextPanelButtons = "Two Clicked";
        textPanelButtons.text = newTextPanelButtons;
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
