using UnityEngine;
using UnityEngine.SceneManagement;
public class LoadGame : MonoBehaviour
{
    
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
}
