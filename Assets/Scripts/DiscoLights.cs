using UnityEngine;

public class DiscoLights : MonoBehaviour
{
    [SerializeField] GameObject lightsParent=null;

    private void FixedUpdate(){
        lightsParent.transform.Rotate(new Vector3(180*Time.fixedDeltaTime,
                                                  150*Time.fixedDeltaTime,
                                                  360*Time.fixedDeltaTime));
    }
}
