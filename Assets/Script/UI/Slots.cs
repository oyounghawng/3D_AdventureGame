using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Slots : MonoBehaviour
{
    public ItemData item;

    public TextMeshProUGUI mountText;

    public int count = 0;

    private void Start()
    {
        mountText.text = count.ToString();
    }

    public void AddMount()
    {
        count++;
        mountText.text = count.ToString();
    }

    public void UpdateUI()
    {
        mountText.text = count.ToString();
    }
}
