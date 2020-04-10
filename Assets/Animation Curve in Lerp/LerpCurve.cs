using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpCurve : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject ball;
    public Transform start, end;
    public AnimationCurve curve;
    public float percentage;
    // void Update()
    // {
    //     ball.transform.position = Vector3.Lerp(start.position, end.position, curve.Evaluate(percentage));
    // }
    void Start(){
        StartCoroutine(lerp());
    }

    IEnumerator lerp(){
        while(true){
            percentage += Time.deltaTime;
            ball.transform.position = Vector3.Lerp(start.position, end.position, curve.Evaluate(Mathf.Abs(Mathf.Sin(percentage))));
            yield return null;
        }
    }
}
