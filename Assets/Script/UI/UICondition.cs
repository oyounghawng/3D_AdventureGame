using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICondition : MonoBehaviour
{
    public Condition health;
    private void Start()
    {
        GameManager.instance.Player.conditions.uiCondition = this;
    }
}
