using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoardGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int size;
    private GameObject section;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < size; i++)
        {
            for(int j =  0; j < size; j++)
            {
                section = GameObject.Instantiate(prefab, new Vector3(i + i * .1f, 0, j + j * .1f), Quaternion.identity);
                section.transform.SetParent(this.gameObject.transform);
            }
            
        }
    }
}
