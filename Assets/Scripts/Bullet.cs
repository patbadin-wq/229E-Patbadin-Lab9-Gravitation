using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float force = 0;
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(-force, 0, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Rigidbody>().AddTorque(0, 100, 0);
    }
}
