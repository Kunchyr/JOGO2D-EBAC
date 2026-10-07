using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void Load(int i)
    {
        SceneManager.LoadScene(i);
    }
    public void Load(string s)
    {
        SceneManager.LoadScene(s);
    }
}