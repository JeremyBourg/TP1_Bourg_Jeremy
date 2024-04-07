using UnityEngine;

public class Checkpoint : MonoBehaviour
{

    private Collider checkpointCollider;

    private void Start()
    {
        checkpointCollider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            checkpointCollider.enabled = false;
            TrackCheckpoints.Instance.IncrementCheckpoints();
        }
    }
}
