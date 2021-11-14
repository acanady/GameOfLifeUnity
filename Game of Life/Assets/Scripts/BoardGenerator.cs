using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BoardGenerator : MonoBehaviour
{
    public GameObject prefab;
    public int size;
    private GameObject cell;
    public GameObject camera;
    private Vector3 campos;
    public float boardLength;
    public float frustHeight;
    public float fieldofView;

    // Start is called before the first frame update
    void Start()
    {
        GenerateBoard();
    }

   
    public void GenerateBoard()
    {
        
        camera = Camera.main.gameObject;
        campos = camera.transform.position;
        Board.CreateBoard(size);
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                cell = GameObject.Instantiate(prefab, new Vector3(i * .5f + i * .1f, 0, j * .5f + j * .1f), Quaternion.identity);
                cell.transform.SetParent(this.gameObject.transform);
                Board.SetCell(i, j, cell);
                Board.SetRend(cell,cell.GetComponent<Renderer>());
            }

        }

        boardLength = Mathf.Abs(Board.GetCell(0, 0).transform.position.z - Board.GetCell(0, size - 1).transform.position.z);
        frustHeight = boardLength + 1f;
        float halfpos = Board.GetCell(0, size - 1).transform.position.z / 2f;
        camera.transform.position = new Vector3(halfpos, frustHeight,halfpos);
      
      
        
    }
}
