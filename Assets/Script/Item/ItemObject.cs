using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour,IInteractable
{
    public ItemData data;

    public string GetInteractPrompt()
    {
        string str = $"{data.displayNmae}\n{data.description}";
        return str;
    }

    public void OnInteract()
    {
        GameManager.instance.Player.itemData = data;
        GameManager.instance.Player.addItem?.Invoke();
        Destroy(gameObject);
    }
}
