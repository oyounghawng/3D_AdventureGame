using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemTpye
{
    Consumable,
}

[System.Serializable]
public class ItemDataConsumable
{
    public float value;
}

[CreateAssetMenu(fileName ="Item", menuName = "NewItem")]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayNmae;
    public string description;
    public ItemTpye type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmoun;

    [Header("Consumalbe")]
    public ItemDataConsumable[] consumables;
}
