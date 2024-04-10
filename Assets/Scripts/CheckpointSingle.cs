using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private Collider checkpointCollider;
    [SerializeField] private ParticleSystem confetti;

    private void Start()
    {
        checkpointCollider = GetComponent<Collider>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            var em = confetti.emission;
            var dur = confetti.main.duration;

            checkpointCollider.enabled = false;
            TrackCheckpoints.Instance.IncrementCheckpoints();

            em.enabled = true;
            confetti.Play();

            Invoke("RemoveEmission", dur);
        }
    }

    void RemoveEmission(){
        var em = confetti.emission;

        em.enabled=false;
    }
}
