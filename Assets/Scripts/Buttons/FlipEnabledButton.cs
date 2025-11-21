using UnityEngine;

public class FlipEnabledButton : Button{
    public GameObject TargObject;
    public override void OnHit()
    {
        TargObject.SetActive(!TargObject.activeSelf);
    }
}