using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    [SerializeField] private Renderer roadRenderer;
    [SerializeField] private float speed;
    private float textureSize=3f;

    private void Awake()
    {
     
        textureSize = roadRenderer.material.mainTextureScale.y;
    }
    private void Update()
    {
        float scaleFactor = GameController.GameSpeed * Time.deltaTime * speed;
        roadRenderer.material.mainTextureOffset += new Vector2(0,scaleFactor);
        textureSize -= scaleFactor / 8;
        roadRenderer.material.mainTextureScale = new Vector2(1, Mathf.Max(0.1f,textureSize));

    }

}
