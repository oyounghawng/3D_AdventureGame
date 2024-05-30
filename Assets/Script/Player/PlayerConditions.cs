using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    void TakePhysicalDamge(int damageAmount);
}

public class PlayerConditions : MonoBehaviour, IDamagable
{
    public UICondition uiCondition;

    public Condition health { get { return uiCondition.health; } }

    public event Action onTakeDamage;

    private void Update()
    {
        health.Subtract(health.passiveValue * Time.deltaTime);
    }

    public void TakePhysicalDamge(int damageAmount)
    {
        health.Subtract(damageAmount);
        onTakeDamage?.Invoke();
    }
}
