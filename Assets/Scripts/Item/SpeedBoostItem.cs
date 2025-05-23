using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBoostItem : MonoBehaviour
{
    [SerializeField] private float speedAmount = 5f;
    [SerializeField] private float duration = 5f;
    [SerializeField] private float respawnTime = 10f;

    private Collider itemCollider;
    private Renderer itemRenderer;

    private void Awake()
    {
        itemCollider = GetComponent<Collider>();
        itemRenderer = itemCollider.GetComponent<Renderer>();
    }

    [SerializeField] private UIEffectTimer uiEffectTimer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCondition condition = other.GetComponent<PlayerCondition>();
            if (condition != null)
            {
                condition.IncreaseSpeed(speedAmount, duration);
                //uiEffectTimer?.ShowSpeedEffect(duration);
                StartCoroutine(Respawn());
            }
        } 
    }

    private IEnumerator Respawn()
    {
        itemCollider.enabled = false;
        itemRenderer.enabled = false;

        yield return new WaitForSeconds(respawnTime);

        itemCollider.enabled = true;
        itemRenderer.enabled = true;
    }
}
