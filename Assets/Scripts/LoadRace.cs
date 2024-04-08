using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering.PostProcessing;

public class LoadRace : MonoBehaviour
{
    public void LoadScene(){
        SceneManager.LoadScene("Course");
    }
}
