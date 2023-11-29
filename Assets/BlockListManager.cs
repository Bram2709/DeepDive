using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockListManager : MonoBehaviour
{

    public List<string> playerNames;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddPlayerToBlockList(string player)
    {
        try
        {
            playerNames.Add(player);
        }
        catch (System.Exception e)
        {

            Debug.Log(e);
        }
    }

    public void RemovePlayerFromBlockList(string player)
    {
        try
        {
            playerNames.Remove(player);
        }
        catch (System.Exception e)
        {

            Debug.Log(e);
        }
    }
}
