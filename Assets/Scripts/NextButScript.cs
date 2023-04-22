using UnityEngine;
using UnityEngine.SceneManagement;


public class NextButScript : MonoBehaviour
{
    public void ChangeScene(int sceneNum)
    {
        SceneManager.LoadScene(sceneNum);
    }
    
}
