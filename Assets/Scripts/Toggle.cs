using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    [SerializeField] private TMP_Text textPanelToggle;
    [SerializeField] private Text[] textToggle;

    public void ToggleButtons(int index)
    {
        if(index == 0)
        {
            textPanelToggle.text = textToggle[0].text;
        }
        else if(index == 1)
        {
            textPanelToggle.text = textToggle[1].text;
        }
        else
        {
            textPanelToggle.text = textToggle[2].text;
        }
    }
}
