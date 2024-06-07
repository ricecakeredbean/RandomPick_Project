using UnityEngine.SceneManagement;

public static class SceneLoadSystem
{
    public static void LoadScene(int index)
    {
        SceneManager.LoadScene(index);
    }

    public static void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
