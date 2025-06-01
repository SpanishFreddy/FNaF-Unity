using UnityEngine;
using UnityEngine.SceneManagement;

public class NewspaperLoader : MonoBehaviour
{
    public string sceneToLoad = "NextScene";
    public GameObject newspaper;
    public GameObject blackImage;
    public Animator[] animatedImages;

    private bool sequenceStarted = false;

    public void StartSequence()
    {
        if (!sequenceStarted)
        {
            sequenceStarted = true;
            StartCoroutine(Sequence());
        }
    }

    private System.Collections.IEnumerator Sequence()
    {
        foreach (var animator in animatedImages)
        {
            if (animator != null)
                animator.speed = 0;
        }

        if (newspaper != null)
            newspaper.SetActive(true);

        yield return new WaitForSeconds(3f);

        if (blackImage != null)
            blackImage.SetActive(true);

        yield return new WaitForSeconds(10f);

        SceneManager.LoadScene(sceneToLoad);
    }
}