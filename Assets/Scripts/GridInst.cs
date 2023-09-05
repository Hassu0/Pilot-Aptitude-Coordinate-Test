using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GridInst : MonoBehaviour
{
    [SerializeField] GameObject gridPrefab;
    [SerializeField] float number;
    public TMP_FontAsset font;
    
    void Start()
    {
        for (int i = 0; i < number; i++)
        {
            for (int y = 0; y < number; y++)
            {
                GameObject grid = Instantiate(gridPrefab) as GameObject;
                grid.transform.position = new Vector3((i-8), (y-8), 0f);
                GameObject textObject = new GameObject("Text");
                textObject.transform.position = new Vector3(((float)i - 8), ((float)y - 8.15f), 0f);
                // TextMeshPro bileþenini ekleyin ve metni ayarlayýn
                TextMeshPro textMeshPro = textObject.AddComponent<TextMeshPro>();
                textMeshPro.text = "*"; // Metin içeriðini belirlediðiniz diziye göre alýn
                textMeshPro.color = Color.white;
                textMeshPro.fontSize = 9; // Metin boyutunu ayarlayabilirsiniz
                textMeshPro.alignment = TextAlignmentOptions.Center; // Metin hizalamasýný ayarlayabilirsiniz
                textMeshPro.font = font; // Kullanmak istediðiniz fontu ayarlayýn
            }
        }
    }
}
