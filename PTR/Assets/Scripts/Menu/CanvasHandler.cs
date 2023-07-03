using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasHandler : MonoBehaviour
{
    public void LoadMainLevel()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        while (true)
        {
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(1);
        }
    }
}
