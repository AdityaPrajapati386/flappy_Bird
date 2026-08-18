using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class scoremantener : MonoBehaviour
{ 
    [SerializeField] Text Score;
    [SerializeField]GameObject gameoverscreen;
    private int scoreNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameoverscreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

      [ContextMenu ("ince=rice")]
    public void AddScore()
    {
        scoreNumber += 1;
        Score.text=scoreNumber.ToString();
    }

    public void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale=1f;
    }

    public void Gameend()
    {

        gameoverscreen.SetActive(true);
        Time.timeScale=0f;
    }

    public void Mainmenus( string scenenameManu)
    {
        
        SceneManager.LoadScene(scenenameManu);
        Time.timeScale=1f;
    }
}
