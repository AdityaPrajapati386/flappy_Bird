using UnityEngine;
using UnityEngine.SceneManagement;
public class Transection : MonoBehaviour
{
    [SerializeField] GameObject Mainmanu;
   // Start is called once before the first execution of Update after the MonoBehaviour is created
       public void LoadScene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
