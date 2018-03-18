
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public int sceneIndex;
    public void LoadByIndex( int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }
}