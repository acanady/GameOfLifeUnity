using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public float lerpTime;
    public float speed;
    //private float lerpTime = 1f;
    private float currentLerpTime;
    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.transform.localScale = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.localScale, new Vector3(.5f,.25f,.5f) )> 0.1){
            currentLerpTime += Time.deltaTime;
            float t = currentLerpTime / lerpTime;
            this.gameObject.transform.localScale = Vector3.Lerp(this.gameObject.transform.localScale, new Vector3(.5f, .25f, .5f), Mathf.Sin(t * Mathf.PI * 0.5f) * speed);
        }
        
    }
}
