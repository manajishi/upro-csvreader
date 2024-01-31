using UnityEngine;

[CreateAssetMenu(fileName = "CSVData", menuName = "ScriptableObjects/CSVData", order = 1)]
public class CSVData : ScriptableObject
{
    [System.Serializable]
    //1行につき３つの要素
    public class CSVRow
    {
        public string Name;
        public string Line;
        public int mode;
    }

    public CSVRow[] Rows;
}
