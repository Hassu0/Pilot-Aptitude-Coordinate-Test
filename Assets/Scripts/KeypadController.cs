using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TMP_InputField inputField;

    // D��me t�kland���nda �a�r�lacak fonksiyon
    public void OnButtonClick(string value)
    {
        // InputField'daki mevcut metni al
        string currentText = inputField.text;

        // E�er metin uzunlu�u 0 ise, sadece rakam� ekle
        if (currentText.Length == 0)
        {
            currentText = value;
        }
        else
        {
            // E�er metin uzunlu�u 1 ise, aralar�na "-" i�areti ekleyerek iki rakam� birle�tir
            if (currentText.Length == 1)
            {
                currentText += "-" + value;
            }
            // E�er metin uzunlu�u 3'ten k���kse, sadece son rakam� ekleyerek mevcut metni g�ncelle
            else if (currentText.Length < 3)
            {
                currentText = currentText.Substring(0, 2) + value;
            }
        }

        // Yeni metni InputField'a atay�n
        inputField.text = currentText;
    }
}
