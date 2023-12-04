using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : MonoBehaviour
{
    [Header("Components")]
    [SerializeField] Rigidbody2D _rigidbody;

    [SerializeField] float _speed;

    private Vector2 m_movementInput;

    private void FixedUpdate()
    {
        //Movement Calculation
        _rigidbody.velocity = m_movementInput * _speed;
    }

    private void OnMove(InputValue inputValue)
    {
        m_movementInput =  inputValue.Get<Vector2>();
    }
}
