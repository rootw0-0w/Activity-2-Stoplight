using System.Collections;
using UnityEngine;

public class stoplight : MonoBehaviour
{
    public GameObject stoplight1, stoplight2, stoplight3;
    public MeshRenderer rend1, rend2, rend3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rend1 = stoplight1.GetComponent<MeshRenderer>();
        rend2 = stoplight2.GetComponent<MeshRenderer>();
        rend3 = stoplight3.GetComponent<MeshRenderer>();
       
        StartCoroutine(ColorCycle());
    }
   IEnumerator ColorCycle()
    {
        while (true)
        {
            rend1.material.color = Color.red;
            rend2.material.color = Color.gray;
            rend3.material.color = Color.gray;
            yield return new WaitForSeconds(5);

            rend3.material.color = Color.green;
            rend2.material.color = Color.gray;
            rend1.material.color = Color.gray;
            yield return new WaitForSeconds(5);

            rend2.material.color = Color.yellow;
            rend3.material.color = Color.gray;
            rend1.material.color = Color.gray;
            yield return new WaitForSeconds(2);


            StartCoroutine(ColorCycle());
        }
    }
    
       void Update()
    {
        
    }
}