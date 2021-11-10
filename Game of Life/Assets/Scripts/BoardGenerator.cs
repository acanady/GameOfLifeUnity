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
        camera.transform.position = new Vector3(campos.x + Mathf.Ceil(size / 2) * .6f, campos.y, campos.z + Mathf.Ceil(size / 2) * .6f);
    }
}
