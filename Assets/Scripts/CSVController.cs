using UnityEngine;
using TMPro;

public class CSVController : MonoBehaviour
{
    public CSVData csvData; // Inspector で ScriptableObject をアサイン
    int rowNum=0;

    [SerializeField] private TextMeshProUGUI nameText;
    [SerializeField] private TextMeshProUGUI lineText;

    private int index = 0;

    void Start()
    {
        rowNum=csvData.Rows.Length;
        //texRead(index);
        if (csvData != null && csvData.Rows.Length > 0)
        {
            // CSVData.Rows が配列なので、index を指定して要素にアクセスします
            string temp_name_text = csvData.Rows[index].Name;
            string temp_line_text = csvData.Rows[index].Line;

            nameText.text = temp_name_text;
            lineText.text = temp_line_text;

            //texRead(index);
        }
        else
        {
            Debug.LogError("CSVData not assigned or empty!");
        }
    }

    void Update()
    {
        if(rowNum-1>index){
            if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                Debug.Log("Enterキーが押されました");
                index++;
                if (csvData != null && csvData.Rows.Length > 0)
                {
                    // CSVData.Rows が配列なので、index を指定して要素にアクセスします
                    string temp_name_text = csvData.Rows[index].Name;
                    string temp_line_text = csvData.Rows[index].Line;

                    nameText.text = temp_name_text;
                    lineText.text = temp_line_text;

                    //texRead(index);
                }
                else
                {
                    Debug.LogError("CSVData not assigned or empty!");
                }
            }
        }

    }

   /* void texRead(int index){

    }*/
}
