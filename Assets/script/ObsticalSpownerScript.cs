using System.Threading;
using Unity.Mathematics;
using UnityEngine;

public class ObsticalSpownerScript : MonoBehaviour
{
    [SerializeField] GameObject Opstical;
    [SerializeField]float spawnrate = 2;
    private float Timere=0;
    [SerializeField]float yrang=3f;
    [SerializeField]float Destroyobj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ObjSpawner();
    }

    // Update is called once per frame
    void Update()
    {
          if (Timere < spawnrate)
        {
            Timere = Timere + Time.deltaTime;
        }
        else
        {
           ObjSpawner();
           Timere=0;
        }
        
        
    }

    void ObjSpawner()
    {
      
        float RangY = UnityEngine.Random.Range(-yrang , yrang);
        GameObject Opstobj= Instantiate(Opstical,transform.position=new Vector3(20,RangY,0),transform.rotation);
        Destroy(Opstobj,Destroyobj); 
    }


}
