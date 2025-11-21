using UnityEngine;

public abstract class Button : MonoBehaviour
{
   
    public enum ButtonType{
        Shoot,
        Walk,
        ShootNWalk
    }
    public ButtonType buttonType;
    public abstract void OnHit();
    public void OnCollisionEnter2D(Collision2D col){
        if((buttonType == ButtonType.Shoot || buttonType == ButtonType.ShootNWalk)&&col.collider.gameObject.GetComponent<Explosion>()){
            OnHit();
        }
        if((buttonType==ButtonType.Walk||buttonType==ButtonType.ShootNWalk)&&col.collider.gameObject.GetComponent<PlatformerMovement>()){
            OnHit();
        }
    }
}
