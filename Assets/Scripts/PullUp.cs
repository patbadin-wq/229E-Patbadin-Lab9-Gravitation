using UnityEngine;

public class PullUp : MonoBehaviour
{
    // T = MG + MA 
    //   = M(G + A)
    public float Tension;
    public float Mass;
    public float Accel;

    private Rigidbody _rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        Mass = _rb.mass;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // T = MG + MA = M(G + A)
        Tension = Mass * (-Physics.gravity.y + Accel);
        _rb.AddForce(Vector3.up * Tension);
    }
}
