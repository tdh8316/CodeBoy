using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    public static List<int> script = new List<int>();

    public static readonly int UP = 0;
    public static readonly int DOWN = 1;
    public static readonly int LEFT = 2;
    public static readonly int RIGHT = 3;

    public static string S_MOVERIGHT = "움직이기: →\n";
    public static string S_MOVEDOWN = "움직이기: ↓\n";
    public static string S_MOVEUP = "움직이기: ↑\n";
}
