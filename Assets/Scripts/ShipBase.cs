using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBase : MonoBehaviour
{
    //In plan, 0=empty, 1=floor, 2=wall
    public short[,] plan;
    public Transform floor;
    public Transform wall;

    public ShipBase(short[,] _plan, Transform _floor, Transform _wall)
    {
        plan = _plan;
        floor = _floor;
        wall = _wall;
    }
    public void spawn()
    {
        for(int x = 0; x<plan.GetLength(0); x++)
        {
            //int xPos = (int)transform.position.x + x - plan.GetLength(0) / 2;
            for (int y=0; y<plan.GetLength(1); y++)
            {
                //int yPos = (int)transform.position.y + y - plan.GetLength(1) / 2;
                Transform obj;
                switch(plan[x, y])
                {
                    case 0:
                        break;
                    case 1:
                        obj = Instantiate(floor, new Vector3(x, 0, y), Quaternion.identity);
                        //obj.SetParent(transform, false);
                        break;
                    case 2:
                        obj = Instantiate(wall, new Vector3(x, 0, y), Quaternion.identity);
                        //obj.SetParent(transform, false);
                        break;
                }
            }
        }
    }
}
