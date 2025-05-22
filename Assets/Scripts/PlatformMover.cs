using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    [SerializeField] private Transform[] points;
    [SerializeField] private float moveSpeed = 2f;
    [SerializeField] private float waitTime = 1f;

    private int currentTargetIndex = 0;
    private bool isWaiting = false;
    private int direction = 1;

    // Update is called once per frame
    void Update()
    {
        if (points.Length == 0 || isWaiting) return;

        Transform target = points[currentTargetIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, moveSpeed * Time.deltaTime);

        if (Vector3.Distance(transform.position, target.position) < 0.05f)
        {
            StartCoroutine(WaitBeforeNextPoint());
        }
    }

    private IEnumerator WaitBeforeNextPoint()
    {
        isWaiting = true;
        yield return new WaitForSeconds(waitTime);

        currentTargetIndex += direction;

        if (currentTargetIndex >= points.Length)
        {
            currentTargetIndex = points.Length - 2;
            direction = - 1;
        }
        else if (currentTargetIndex < 0)
        {
            currentTargetIndex = 1;
            direction = 1;
        }
            isWaiting = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어 아직 트리거 안에 있음");
            other.transform.parent = transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("플레이어가 트리거에서 나감");
            other.transform.parent = null;
        }
    }
}
