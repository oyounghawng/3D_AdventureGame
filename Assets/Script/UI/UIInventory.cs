using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class UIInventory : MonoBehaviour
{
    private PlayerController controller;
    private PlayerConditions condition;

    public GameObject inventoryWindow;

    public Slots heart;
    public Slots speed;
    private void Start()
    {
        controller = GameManager.instance.Player.controller;
        condition = GameManager.instance.Player.conditions;

        controller.inventory += Toggle;
        GameManager.instance.Player.addItem += AddItem;

        inventoryWindow.SetActive(false);
    }

    private void Toggle()
    {
        if (inventoryWindow.activeInHierarchy)
        {
            inventoryWindow.SetActive(false);
        }
        else
        {
            inventoryWindow.SetActive(true);
        }
    }

    private void AddItem()
    {
        ItemData itemData = GameManager.instance.Player.itemData;

        if (itemData.displayNmae == "체력포션")
        {
            heart.AddMount();
        }
        else if (itemData.displayNmae == "속도물약")
        {
            speed.AddMount();
        }
    }

    public void AddHealth()
    {
        if (heart.count <= 0)
            return;

        heart.count--;
        ItemData data = heart.item;
        heart.UpdateUI();
        for (int i = 0; i < data.consumables.Length; i++)
        {
            condition.health.Add(data.consumables[i].value);
        }
    }

    public void AddSpeed()
    {
        if (speed.count <= 0)
            return;

        speed.count--;
        speed.UpdateUI();
        ItemData data = speed.item;
        float curSpeed = controller.moveSpeed;
        for (int i = 0; i < data.consumables.Length; i++)
        {
            curSpeed += data.consumables[i].value;
        }
        controller.SpeedUP(curSpeed);
    }


}
