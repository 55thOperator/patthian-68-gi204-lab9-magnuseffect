using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusSoccerKick : MonoBehaviour
{
    Rigidbody rb;
    public float spinSpeed;
    public float kickForce;
    public float magnusStrenght = 0.5f;

    bool isShot = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !isShot)
        {
            rb.AddForce(Vector3.forward * kickForce, ForceMode.Impulse);

            rb.AddTorque(Vector3.up * spinSpeed);

            isShot = true;
        }
    }

    private void FixedUpdate()
    {
        if (!isShot) return;
        Vector3 velocity = rb.linearVelocity;
        Vector3 spin = rb.angularVelocity;

        Vector3 magnusForce = magnusStrenght * Vector3.Cross(spin, velocity);
        rb.AddForce(magnusForce);
    }
}
