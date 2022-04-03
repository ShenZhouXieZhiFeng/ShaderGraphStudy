using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class MathTest : MonoBehaviour
{
    public float a;
    public float b;
    public float x;

    public float RES;

    // Start is called before the first frame update
    void Start()
    {
        //Graphics.DrawMeshInstanced
    }

    // Update is called once per frame
    void Update()
    {
        RES = Mathf.SmoothStep(a, b, x);
    }
}
