using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeLoader : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "NextScene";
    [SerializeField] private float delay = 5f;

    void Start()
    {
        Invoke(nameof(LoadScene), delay);
    }

    private void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}