using UnityEngine;

public class spin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public float rspeed = 45f;
    public float rate = 1f;
    public float travel = 2f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rspeed * Time.deltaTime, 0);
        float wave = Mathf.Sin(Time.time * rate) * travel;
        transform.Translate(0, wave * Time.deltaTime, 0);
    }
}
