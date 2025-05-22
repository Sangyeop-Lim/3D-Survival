using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamagable
{
    void TakePhysicalDamage(int damage);
}

public class PlayerCondition : MonoBehaviour, IDamagable
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }
    //Condition hunger {  get { return uiCondition.hunger; } }
    Condition stamina {  get { return uiCondition.stamina; } }
    Condition speed {  get { return uiCondition.speed; } }

    //public float noHungerHealthDecay;

    public event Action onTakeDamage;

    void Update()
    {
        //hunger.Subtract(hunger.passiveValue * Time.deltaTime);
        
        stamina.Add(stamina.passiveValue * Time.deltaTime);

        //if (hunger.curValue == 0f)
        //{
        //    health.Subtract(noHungerHealthDecay * Time.deltaTime);
        //}

        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Heal(float amout)
    {
        health.Add(amout);
    }

    //public void Eat(float amout)
    //{
    //    hunger.Add(amout);
    //}

    public void Die()
    {
        Debug.Log("ав╬З╢ы!");
    }

    public void TakePhysicalDamage(int damage)
    {
        health.Subtract(damage);
        onTakeDamage?.Invoke();
    }

    public bool UseStamina(float amount)
    {
        if (stamina.curValue - amount < 0f)
        {
            return false;
        }

        stamina.Subtract(amount);
        return true;
    }

    public void IncreaseSpeed(float amount, float duration)
    {
        PlayerController controller = GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.moveSpeed += amount;
            StartCoroutine(RestoreSpeed(controller, amount, duration));
        }
    }

    private IEnumerator RestoreSpeed(PlayerController controller, float amount, float duration)
    {
        yield return new WaitForSeconds(duration);

        controller.moveSpeed -= amount;
    }
}