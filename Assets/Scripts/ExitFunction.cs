using UnityEngine;

public class ExitFunction : MonoBehaviour
{
    public void quit()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
}