using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpPower = 5.0f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody _rigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (_rigidbody != null)
            {
                _rigidbody.velocity = new Vector3(_rigidbody.velocity.x, 0f, _rigidbody.velocity.z);
                _rigidbody.AddForce(transform.up * jumpPower, ForceMode.Impulse);
                Debug.Log("플레이어가 점프대를 밣음");
            }
        }
    }
}
