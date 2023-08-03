using UnityEngine;
using TMPro;
public class ModifyText : MonoBehaviour
{
    public TMP_Text canvasText;

    public void Start()
    {
        canvasText.text = "You are ded lol";
    }
}
