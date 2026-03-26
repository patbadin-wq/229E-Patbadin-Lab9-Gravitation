using UnityEngine;
using UnityEngine.InputSystem;

public class MagnusEffect : MonoBehaviour
{
    public Vector3 KickPower;
    public float SpinAmount = 1.0f;
    public float MagnusStrength = 0.5f;
    private Rigidbody _rb;
    private bool _isShoot = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame && !_isShoot)
        {
            _rb.AddRelativeForce(KickPower, ForceMode.Impulse);
            _rb.AddTorque(Vector3.up * SpinAmount);
            _isShoot = true;
        }
       
    }
    void FixedUpdate()
    {
        if (!_isShoot) return;
        Vector3 velocity = _rb.linearVelocity;
        Vector3 spin = _rb.angularVelocity;

        Vector3 MagnusForce = Vector3.Cross(spin, velocity);
        MagnusForce *= MagnusStrength;
        _rb.AddForce(MagnusForce);
    }
}
