using UnityEngine;

public class drive : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(0, 0.1f, 0);
        }

    }
}
