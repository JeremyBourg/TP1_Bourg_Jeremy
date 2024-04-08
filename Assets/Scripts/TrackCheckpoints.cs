using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    public static TrackCheckpoints Instance;
    public int CheckpointReached;

    private void Awake()
    {
            Instance = this;
    }

    public void IncrementCheckpoints()
    {
        CheckpointReached++;
        // Debug.Log(CheckpointReached);
    }
}