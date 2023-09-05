using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI[] starTexts; // "*" karakterlerini temsil eden TMP Text nesnelerini bu diziye s�r�kleyip b�rak�n veya atay�n.
    public TextMeshProUGUI[] oTexts;    // "O" karakterlerini temsil eden TMP Text nesnelerini bu diziye s�r�kleyip b�rak�n veya atay�n.

    private void Start()
    {
        // Rastgele 10 "*" karakterini a�
        RandomlyOpenStars(10);
    }

    private void RandomlyOpenStars(int countToOpen)
    {
        if (countToOpen <= 0 || countToOpen > starTexts.Length)
        {
            Debug.LogWarning("Ge�ersiz y�ld�z say�s�.");
            return;
        }

        int openedCount = 0;
        while (openedCount < countToOpen)
        {
            int randomIndex = Random.Range(0, starTexts.Length);

            // E�er bu TMP Text nesnesi kapal�ysa, "*" karakterini g�ster
            if (!starTexts[randomIndex].gameObject.activeSelf)
            {
                starTexts[randomIndex].gameObject.SetActive(true);
                openedCount++;
            }
        }
    }
}
