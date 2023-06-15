using System.Collections.Generic;
using UnityEngine;

public class Marker3Move : MonoBehaviour
{
    TrailRenderer TR;

    // Start is called before the first frame update
    void Start()
    {
        TR = GetComponent<TrailRenderer>();
        TR.enabled = false;
        transform.position = PEQ.Epicycloid(0, 4);
        TR.enabled = true;

    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time;
        transform.position = PEQ.Epicycloid((7 / 2) * t);
    }
}
