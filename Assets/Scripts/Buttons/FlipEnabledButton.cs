using UnityEngine;

public class FlipEnabledButton : Button{
    public GameObject TargObject;
    public override void OnHit()
    {
        TargObject.SetActive(!TargObject.activeSelf);
    }
    public void Update(){
        if(!TargObject.activeSelf){
            GetComponent<SpriteRenderer>().sprite = Pressed;
        }
        else{
            GetComponent<SpriteRenderer>().sprite = BaseSprite;
        }
    }
}