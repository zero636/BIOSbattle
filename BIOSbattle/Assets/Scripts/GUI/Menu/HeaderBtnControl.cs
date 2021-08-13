using System.Drawing;
using TMPro;
using UnityEditor.U2D.Path.GUIFramework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class HeaderBtnControl : MonoBehaviour
{
    [SerializeField] private UnityEngine.UI.Button btnMain;
    [SerializeField] private TextMeshProUGUI tmpMain;

    [SerializeField] private UnityEngine.UI.Button btnOptions;
    [SerializeField] private TextMeshProUGUI tmpOptions;

    [SerializeField] private UnityEngine.UI.Button btnInfo;
    [SerializeField] private TextMeshProUGUI tmpInfo;

    [SerializeField] private UnityEngine.UI.Button btnExit;
    [SerializeField] private TextMeshProUGUI tmpExit;

    
    
    public void ColorChangeMain()
    {
        btnMain.image.color = new Color32(204, 204, 204, 255);
        
        
        tmpMain.faceColor = new Color32(00, 00, 167, 255);
        tmpOptions.faceColor = new Color32(204, 204, 204, 255);
        tmpInfo.faceColor = new Color32(204, 204, 204, 255);
        tmpExit.faceColor = new Color32(204, 204, 204, 255);
        
        /*
         tmpMain.color = new Color(00, 00, 167, 255);
        tmpOptions.color = new Color(204, 204, 204, 255);
        tmpInfo.color = new Color(204, 204, 204, 255);
        tmpExit.color = new Color(204, 204, 204, 255);
        */
    }
    
    public void ColorChangeOptions()
    {
        btnOptions.image.color = new Color32(204, 204, 204, 255);
        
        
        tmpMain.faceColor = new Color32(204, 204, 204, 255);
        tmpOptions.faceColor = new Color32(00, 00, 167, 255);
        tmpInfo.faceColor = new Color32(204, 204, 204, 255);
        tmpExit.faceColor = new Color32(204, 204, 204, 255);
        
        /*
        tmpMain.color = new Color(204, 204, 204, 255);
        tmpOptions.color = new Color(00, 00, 167, 255);
        tmpInfo.color = new Color(204, 204, 204, 255);
        tmpExit.color = new Color(204, 204, 204, 255);
        */
    }
    
    public void ColorChangeInfo()
    {
        btnInfo.image.color = new Color32(204, 204, 204, 255);
        
        
        tmpMain.faceColor = new Color32(204, 204, 204, 255);
        tmpOptions.faceColor = new Color32(204, 204, 204, 255);
        tmpInfo.faceColor = new Color32(00, 00, 167, 255);
        tmpExit.faceColor = new Color32(204, 204, 204, 255);

        /*
        tmpMain.color = new Color(204, 204, 204, 255);
        tmpOptions.color = new Color(204, 204, 204, 255);
        tmpInfo.color = new Color(00, 00, 167, 255);
        tmpExit.color = new Color(204, 204, 204, 255);
        */
    }
    
    public void ColorChangeExit()
    {
        btnExit.image.color = new Color32(204, 204, 204, 255);
        
        
        tmpMain.faceColor = new Color32(204, 204, 204, 255);
        tmpOptions.faceColor = new Color32(204, 204, 204, 255);
        tmpInfo.faceColor = new Color32(204, 204, 204, 255);
        tmpExit.faceColor = new Color32(00, 00, 167, 255);
        
        /*
        tmpMain.color = new Color(204, 204, 204, 255);
        tmpOptions.color = new Color(204, 204, 204, 255);
        tmpInfo.color = new Color(204, 204, 204, 255);
        tmpExit.color = new Color(00, 00, 167, 255);
        */
    }
}
