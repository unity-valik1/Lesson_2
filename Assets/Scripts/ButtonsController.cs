using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject[] panels;
    void Start()
    {
        ActivePanel(0);
    }

    public void ActivePanel(int index)
    {
        for (int i = 0; i < panels.Length; i++)
        {
            if (i == index)
            {
                panels[index].SetActive(true);
            }
            else
            {
                panels[i].SetActive(false);
            }
        }
    }
}
