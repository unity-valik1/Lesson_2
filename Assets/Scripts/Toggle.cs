using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Toggle : MonoBehaviour
{
    [SerializeField] private TMP_Text textPanelToggle;
    [SerializeField] private Image[] img;
    private string newTextPanelToggle;

    public void ToggleButtons(int index)
    {
        if(index == 0)
        {
            newTextPanelToggle = "First";
            textPanelToggle.text = newTextPanelToggle;
        }
        else if(index == 1)
        {
            newTextPanelToggle = "Second";
            textPanelToggle.text = newTextPanelToggle;
        }
        else
        {
            newTextPanelToggle = "Third";
            textPanelToggle.text = newTextPanelToggle;
        }
        ActiveImg(index);
    }

    private void ActiveImg(int index)
    {
        for (int i = 0; i < img.Length; i++)
        {
            if (i == index)
            {
                img[index].gameObject.SetActive(true);
            }
            else
            {
                img[i].gameObject.SetActive(false);
            }
        }
    }
}
