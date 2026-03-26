using UnityEngine;
using UnityEngine.InputSystem;

public class TC : MonoBehaviour
{
    public float TorquePower = 1.0f;
    private Rigidbody _rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Keyboard.current.dKey.isPressed)
        {
            _rb.AddRelativeTorque(0, 0, TorquePower);
        }
    }
}
