using UnityEngine;

public class Dropper : MonoBehaviour
{
    MeshRenderer meshRenderer;
    Rigidbody rb;
    [SerializeField] float TimeToWait = 2f;
    bool dropped = false;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rb = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        rb.useGravity = false;
    }

    void Update()
    {
        if (!dropped && Time.time > TimeToWait)
        {
            meshRenderer.enabled = true;
            rb.useGravity = true;
            dropped = true;
        }
    }
}