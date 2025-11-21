using UnityEngine;

public class Explosion : MonoBehaviour
{
    public float force;
    public bool isThirdRocket;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(gameObject, 1);
        if(isThirdRocket){
            transform.localScale *= 2;
            force *= 2.5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other){
        if(other.GetComponent<Explosion>()){
            force *= 2;
        }
    }
}
