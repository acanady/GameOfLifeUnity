using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellSelector : MonoBehaviour
{
    private Ray ray;
    private RaycastHit hit;
    private GameObject sel_cell;
    private Color orig_color;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SelectCell();
        highlightCell();
    }

    public void highlightCell()
    {
        Renderer trenderer;
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(Physics.Raycast(ray, out hit))
        {
            if(sel_cell != null)
                Board.GetRend(sel_cell).material.color = orig_color;
            if (!Input.GetMouseButtonDown(0))
            {
                sel_cell = hit.collider.gameObject;
                trenderer = Board.GetRend(sel_cell);
                orig_color = trenderer.material.color;
                trenderer.material.color = Color.grey;
            }
    
        }
    }

    public void SelectCell()
    {
        Renderer trenderer;
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {

                trenderer = Board.GetRend(hit.collider.gameObject);
                if (orig_color == Color.black)
                {
                    Debug.Log("Color is black");
                    trenderer.material.color = Color.white;
                    orig_color = Color.white;
                }
                else
                {
                    trenderer.material.color = Color.black;
                    orig_color = Color.black;
                }
                
            }
                
        }
    }
}
