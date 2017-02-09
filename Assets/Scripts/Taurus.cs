using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taurus : MonoBehaviour {

    short[,] plan =
        {
            {0,0,0,0,0,0,1,1,0,0,0,0,0,0,0 },
            {0,1,1,1,1,2,1,1,1,1,0,0,0,0,0 },
            {1,1,1,2,1,1,1,1,1,1,1,1,1,1,1 },
            {1,1,1,2,1,1,1,1,1,1,1,1,1,1,1 },
            {0,1,1,1,1,2,1,1,1,1,0,0,0,0,0 },
            {0,0,0,0,0,0,1,1,0,0,0,0,0,0,0 }
        };

    public Transform floor;
    public Transform wall;

	void Start () {
        ShipBase taurus = new ShipBase(plan, floor, wall);
        taurus.spawn();
	}
	
}
