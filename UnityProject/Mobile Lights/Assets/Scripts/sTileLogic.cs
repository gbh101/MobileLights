using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TileType {Square,Plus,X,TriangleUp,TriangleDown,TriangleLeft,
                        TriangleRight,VerticalLine,HorizontalLine,SlashLeft,
                        SlashRight,Generic,NoLight};

public class sTileLogic : MonoBehaviour {

    public enum tileType {  square, plus, x, triangleUp, triangleDown,
                            triangleLeft, triangleRight, verticalLine,
                            horizontalLine, slashLeft, slashRight,
                            generic, noLight};

    public tileType TileEnum;

    public Sprite mySprite;
    public GameObject myTrigger;

    public Sprite genericSprite;
    public GameObject squareTrigger;
    public Sprite squareSprite;
    public GameObject plusTrigger;
    public Sprite plusSprite;
    public GameObject xTrigger;
    public Sprite xSprite;
    public GameObject triangleUpTrigger;
    public Sprite triangleUpSprite;
    public GameObject triangleDownTrigger;
    public Sprite triangleDownSprite;
    public GameObject triangleLeftTrigger;
    public Sprite triangleLeftSprite;
    public GameObject triangleRightTrigger;
    public Sprite triangleRightSprite;
    public GameObject verticalLineTrigger;
    public Sprite verticalLineSprite;
    public GameObject horizontalLineTrigger;
    public Sprite horizontalLineSprite;
    public GameObject slashLeftTrigger;
    public Sprite slashLeftSprite;
    public GameObject slashRightTrigger;
    public Sprite slashRightSprite;

    private bool lit;

    void Awake()
    {
		if (TileEnum == tileType.square)
        {
            myTrigger = squareTrigger;
            mySprite = squareSprite;
        }
        else if (TileEnum == tileType.plus)
        {
            myTrigger = plusTrigger;
            mySprite = plusSprite;
        }
        else if (TileEnum == tileType.x)
        {
            myTrigger = xTrigger;
            mySprite = xSprite;
        }
        else if (TileEnum == tileType.triangleUp)
        {
            myTrigger = triangleUpTrigger;
            mySprite = triangleUpSprite;
        }
        else if (TileEnum == tileType.triangleDown)
        {
            myTrigger = triangleDownTrigger;
            mySprite = triangleDownSprite;
        }
        else if (TileEnum == tileType.triangleLeft)
        {
            myTrigger = triangleLeftTrigger;
            mySprite = triangleLeftSprite;
        }
        else if (TileEnum == tileType.triangleRight)
        {
            myTrigger = triangleRightTrigger;
            mySprite = triangleRightSprite;
        }
        else if (TileEnum == tileType.verticalLine)
        {
            myTrigger = verticalLineTrigger;
            mySprite = verticalLineSprite;
        }
        else if (TileEnum == tileType.horizontalLine)
        {
            myTrigger = horizontalLineTrigger;
            mySprite = horizontalLineSprite;
        }
        else if (TileEnum == tileType.slashLeft)
        {
            myTrigger = slashLeftTrigger;
            mySprite = slashLeftSprite;
        }
        else if (TileEnum == tileType.slashRight)
        {
            myTrigger = slashRightTrigger;
            mySprite = slashRightSprite;
        }
        else if (TileEnum == tileType.generic)
        {
            myTrigger = null;
            mySprite = genericSprite;
        }
        else if (TileEnum == tileType.noLight)
        {
            myTrigger = null;
            mySprite = null;
        }
        else
        {
            Debug.Log("Tile type not recognized");
        }

        GetComponent<SpriteRenderer>().sprite = mySprite;
        GetComponent<SpriteRenderer>().color = new Vector4 (1f, 1f, 1f, 0.5f);
    }
	
    void OnMouseEnter()
    {
        if(TileEnum != tileType.generic && TileEnum != tileType.noLight)
        {
            GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0.75f);
        }
    }

    void OnMouseDown()
    {
        if (TileEnum != tileType.generic && TileEnum != tileType.noLight)
        {
            lit = !lit;

            if (lit)
            {
                GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 1f);
            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0.5f);
            }
        }
    }

    void OnMouseExit()
    {

        if (TileEnum != tileType.generic && TileEnum != tileType.noLight)
        {
            if (lit)
            {
                GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 1f);
            }
            else
            {
                GetComponent<SpriteRenderer>().color = new Vector4(1f, 1f, 1f, 0.5f);
            }
        }
    }
}
