using UnityEngine;

public class TriggerScore : MonoBehaviour
{
    [SerializeField] scoremantener Logic;
    [SerializeField]GameObject[]obj=new GameObject[2];

    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("logic").GetComponent<scoremantener>();
    }
    // void OnTriggerEnter2D(Collider2D collision)
    // {
        
    //     Logic.AddScore();
    // }

 
}