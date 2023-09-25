using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Drops : MonoBehaviour
{
    [SerializeField] private TMP_Text[] textPanelDrops;
    [SerializeField] private Image[] img;
    [SerializeField] private GameObject buttonsDrops;
    [SerializeField] private TMP_Text[] textButtonsDrops;

    public void ActiveButtonsDrops()
    {
        buttonsDrops.SetActive(true);
    }
    public void ActiveOption(int index)
    {
        ActiveTextButtonsDrops(index);
        ActiveImg(index);
        buttonsDrops.SetActive(false);
    }
    private void ActiveTextButtonsDrops(int index)
    {
        for (int i = 0; i < textButtonsDrops.Length; i++)
        {
            if (i == index)
            {
                for (int j = 0; j < textPanelDrops.Length; j++)
                {
                    textPanelDrops[j].text = textButtonsDrops[index].text;
                }
            }
        }
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
