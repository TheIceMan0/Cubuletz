using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void Scene(int x)
    {
        SceneManager.LoadScene(x);
    }
}