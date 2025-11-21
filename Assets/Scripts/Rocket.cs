using UnityEngine;

public class Rocket : MonoBehaviour
{

    public GameObject Explosion;
    public LayerMask Ground;
    public bool IsThirdRocket;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 30);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter2D(Collision2D col){
        Debug.Log(col.collider.gameObject.layer);
        if(col.collider.gameObject.layer == 7){
            Destroy(gameObject);
        }
        if(col.collider.gameObject.layer == 8){
            GetComponent<Rigidbody2D>().linearVelocity = Vector3.Reflect(GetComponent<Rigidbody2D>().linearVelocity, col.contacts[0].normal);
        }
        if(col.collider.gameObject.layer != 7 && col.collider.gameObject.layer != 8){
            var expl = Instantiate(Explosion, transform.position, Quaternion.identity);
            expl.GetComponent<Explosion>().isThirdRocket = IsThirdRocket;
            Destroy(gameObject);
          
        }
       
      
        
    }
}
