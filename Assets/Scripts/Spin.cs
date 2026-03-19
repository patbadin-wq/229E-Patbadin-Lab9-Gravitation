using UnityEngine;

public class Spin : MonoBehaviour
{
    [SerializeField] private float torque = 0;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddTorque(0, 0, torque);
    }
}
