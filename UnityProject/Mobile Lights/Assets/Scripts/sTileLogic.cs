using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType {Square,Plus,X,TriangleUp,TriangleDown,TriangleLeft,
                        TriangleRight,VerticalLine,HorizontalLine,SlashLeft,
                        SlashRight,Generic,NoLight};

public class sTileLogic : MonoBehaviour {

    public enum tileType { square, plus, x, triangleUp, triangleDown, triangleLeft,
                            triangleRight, verticalLine, horizontalLine, slashLeft,
                            slashRight, generic, noLight };

    public tileType TileEnum;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
