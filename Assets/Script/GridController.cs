using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridController : MonoBehaviour {

    public GameObject TilePrefab;
    public GameObject TileRotationTemplate;
    private float CellSize = 1.1f;
    public List<CellData> Cells = new List<CellData>(); 
    public int XSize = 2;
    public int YSize = 3;

    private void Awake()
    {
         CreateGrid();
    }
    private void Start()
    {
       
    }

    void CreateGrid(){
        float size = CellSize;
        if( size<0 )
            size= TilePrefab.transform.localScale.x+ 0.1f;
        for (int x =0; x <XSize; x++){
            for( int y=0; y<YSize; y++){
                //Dati
                Cells.Add(new CellData(x, y, new Vector3(x * size, transform.position.y, y * size)));
            }
        }

      
        for (int x = 0; x<XSize; x++) {
            for (int y = 0; y < YSize; y++)
            {
                CellData cell = FindCell(x, y);
                //Debug
                Instantiate(TilePrefab, new Vector3(x * size, transform.position.y, y * size), TileRotationTemplate.transform.rotation, transform);
            }
        }
    }
#region API
    public bool IsValidPosition(int x,int y)
    {
        if (x < 0 || y < 0)
            return false;
        if (x > XSize - 1 || y > YSize - 1)
            return false;
        return true;
    }
    /// <summary>
    /// Restitusce la WorldPosition per la posizione della cella richiesta.
    /// </summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public Vector3 GetWorldPosition (int x, int y){

        foreach(CellData cell in Cells)
        {
            if(cell.X == x && cell.Y ==y)
               return cell.WorldPosition;
        }
        return Cells[0].WorldPosition;
    }
#endregion

}
