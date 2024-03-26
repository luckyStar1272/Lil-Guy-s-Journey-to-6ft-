using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorManager : ScriptableObject
{
    //max. number of floors in the game.
    int maxNumFloors = 10;
    
    //current floor player is at.
    int curFloorNum = 1;
    
    //current floor type player is at.
    floorType curType = floorType.enemyFloor;

    public enum floorType {enemyFloor, shopFloor}

    
}
