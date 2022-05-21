using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class TowerRotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent < Rigidbody >();
    }

    private void Update()
    {

        /*if (Input.touchCount > 0)   \\ управление для тача на мобилках
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                float torque = touch.deltaPosition.x * Time.deltaTime * _rotateSpeed;
                _rigidbody.AddTorque(Vector3.up * torque);
            }
        }*/
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation *= Quaternion.Euler(0f, 50f * Time.deltaTime * _rotateSpeed, 0f);
        }


        if (Input.GetKey(KeyCode.B) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation *= Quaternion.Euler(0f, -50f * Time.deltaTime * _rotateSpeed, 0f);
        }

        



    }
}
