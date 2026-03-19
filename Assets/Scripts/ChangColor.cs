using UnityEngine;

public class ChangColor : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<Renderer>().material.color = Color.black;

        other.gameObject.GetComponent<Renderer>().material.color = Color.red;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Renderer>().material.color = Color.orange;
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().material.color = Color.blueViolet;
    }
}
