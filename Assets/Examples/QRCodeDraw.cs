using System.Collections;
using System.Collections.Generic;
using QRCode;
using UnityEngine;
using UnityEngine.UI;
using ZXing;

public class QRCodeDraw : MonoBehaviour
{
    public RawImage QRCode; //绘制好的二维码
    public Button DrawButton; //生成按钮
    public string QRCodeText = null; //二维码内容，自己填 
    BarcodeWriter BarcodeWriter; //二维码绘制类

    private void Start()
    {
        DrawButton.onClick.AddListener(() => DrowQRCode(QRCodeText));
    }


    /// <summary>
    /// 绘制二维码
    /// </summary>
    /// <param name="formatStr">二维码信息</param>
    void DrowQRCode(string formatStr)
    {
        Texture2D texture = QRCodeUtil.ShowQRCode(formatStr, 256, 256); //注意：这个宽高度大小256不要变。不然生成的信息不正确
        //256有可能是这个ZXingNet插件指定大小的绘制像素点数值
        QRCode.texture = texture; //显示到UI界面的图片上
    }
}