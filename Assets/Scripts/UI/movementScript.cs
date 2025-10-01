using UnityEngine;
using UnityEngine.InputSystem;

public class movementScript : MonoBehaviour
{
    InputAction move;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        move = InputSystem.actions.FindAction("move");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveVector = move.ReadValue<Vector2>();
        Debug.Log(moveVector);
        transform.rotation = Quaternion.LookRotation(Vector3.forward, moveVector);
    }
}
