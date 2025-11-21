using UnityEngine;

public class Rocket : MonoBehaviour
{

    public GameObject Explosion;
    public LayerMask Ground;
    public bool IsThirdRocket;
    public LayerMask RocketBounce;
    public LayerMask RocketAbsorb;
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
        if(col.gameObject.layer != RocketBounce && col.gameObject.layer != RocketAbsorb){
            var expl = Instantiate(Explosion, transform.position, Quaternion.identity);
            expl.GetComponent<Explosion>().isThirdRocket = IsThirdRocket;
            Destroy(gameObject);
        }
        if(col.gameObject.layer == RocketAbsorb){
            Destroy(gameObject);
        }
      
        
    }
}
