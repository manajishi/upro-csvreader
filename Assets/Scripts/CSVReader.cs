using UnityEngine;
using System.Collections.Generic;
using System.IO;

public class CSVReader : MonoBehaviour
{
    public CSVData csvData;

    void Start()
    {
        //CSVファイルのパス
        string filePath = "Assets/Resources/sample.csv";
        //CSVデータの読み取り
        List<CSVData.CSVRow> rows = ReadCSV(filePath);
        //ScriptableObjectにデータを設定
        csvData.Rows = rows.ToArray();
    }

    List<CSVData.CSVRow> ReadCSV(string path)
    {
        List<CSVData.CSVRow> rows = new List<CSVData.CSVRow>();

        try
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    // CSVRowオブジェクトにデータを格納
                    CSVData.CSVRow row = new CSVData.CSVRow();
                    row.Name = values[0];
                    row.Line = values[1];
                    row.mode = int.Parse(values[2]);
                    rows.Add(row);
                }
            }
        }
        catch (System.Exception e)
        {
            Debug.LogError($"Error reading CSV: {e.Message}");
        }

        return rows;
    }
}
