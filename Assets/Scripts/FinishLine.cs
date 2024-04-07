using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{

    [SerializeField]
    GameObject CheckpointList;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            int totalCheckpoints = GetTotalCheckpoints();
            if (TrackCheckpoints.Instance.CheckpointReached == totalCheckpoints)
            {
                SceneManager.LoadScene("SceneWin");
            }
            else
            {
                SceneManager.LoadScene("SceneLose");
            }
        }
    }

    private int GetTotalCheckpoints()
    {
        return CheckpointList.transform.childCount;
    }

}
