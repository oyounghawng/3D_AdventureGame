using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperJump : MonoBehaviour
{
    public float power;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Rigidbody _rigid = collision.gameObject.GetComponent<Rigidbody>();
            _rigid.AddForce(Vector3.up * power, ForceMode.Impulse);
        }
    }
}
