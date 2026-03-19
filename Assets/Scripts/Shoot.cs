using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform shooter;
    public float shootForce;

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            Fire();
        }
    }

    void Fire()
    {
        GameObject bullet = Instantiate(bulletPrefab, shooter.position, transform.rotation);
        Rigidbody rigidbody = bullet.GetComponent<Rigidbody>();
        rigidbody.AddForce(shooter.forward * shootForce, ForceMode.Impulse);
        Destroy(bullet, 3);
    }
}
