using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        TileBoard.Instance.CreateBoard();
    }
}
