using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShipBase : MonoBehaviour
{
    public Transform prefabListObj;
    Transform floor;
    Transform wall;

    //In plan, 0=empty, 1=floor, 2=wall
    public short[,] plan;

    public ShipBase(short[,] _plan)
    {
        Dictionary<string, Transform> prefabList;
        prefabList = prefabListObj.GetComponent<PrefabList>().dict;

        floor = prefabList["Floor"];
        wall = prefabList["Wall"];

        plan = _plan;
        Debug.Log(floor);
        Debug.Log(wall);
    }

    public ShipBase(short[,] _plan, Transform _floor, Transform _wall)
    {
        plan = _plan;
        floor = _floor;
        wall = _wall;
    }
    public void spawn(Transform spawnTrans)
    {
        for(int x = 0; x<plan.GetLength(0); x++)
        {
            int xPos = (int)spawnTrans.position.x + x - plan.GetLength(0) / 2;
            for (int y=0; y<plan.GetLength(1); y++)
            {
                int yPos = (int)spawnTrans.position.z + y - plan.GetLength(1) / 2;
                Transform obj;
                switch(plan[x, y])
                {
                    case 0:
                        break;
                    case 1:
                        obj = Instantiate(floor, new Vector3(xPos, 0, yPos), Quaternion.identity);
                        obj.SetParent(spawnTrans, false);
                        break;
                    case 2:
                        obj = Instantiate(wall, new Vector3(x, 0, yPos), Quaternion.identity);
                        obj.SetParent(spawnTrans, false);
                        break;
                }
            }
        }
    }
}
