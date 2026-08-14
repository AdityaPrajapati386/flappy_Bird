using UnityEngine;

public class ObsticalMovment : MonoBehaviour
{
    [SerializeField] int speedOfObstical;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        moveObsticalInNeggitiveSide();
    }

    void moveObsticalInNeggitiveSide()
    {
        transform.Translate(Vector2.left*speedOfObstical*Time.deltaTime);
    }
}
