using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marker1Move : MonoBehaviour
{
    TrailRenderer TR;

    // Start is called before the first frame update
    void Start()
    {
        TR = GetComponent<TrailRenderer>();
        TR.enabled = false;
        transform.position = PEQ.Freeth(0);
        TR.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Freeth(t);
    }
}
