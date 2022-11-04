using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.U2D;

public class score : MonoBehaviour
{
    public TextMeshPro scoreText;
    public Object shape;
    public int collisionScore;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collisionScore++;
        scoreText.text = $"Score: {collisionScore}";
    }
}
