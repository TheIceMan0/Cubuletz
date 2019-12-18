
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void Scene()
    {
        SceneManager.LoadScene(2);
    }

    public void Scene2()
    {
        SceneManager.LoadScene(3);
    }
    public void Scene3()
    {
        SceneManager.LoadScene(4);
    }
    public void Scene4()
    {
        SceneManager.LoadScene(5);
    }
}