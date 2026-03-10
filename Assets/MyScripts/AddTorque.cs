using UnityEngine;
using UnityEngine.InputSystem;

public class AddTorque : MonoBehaviour
{
    Rigidbody rb;
    public float spinSpeed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            rb.AddTorque(Vector3.forward * spinSpeed);
        }
    }
}
