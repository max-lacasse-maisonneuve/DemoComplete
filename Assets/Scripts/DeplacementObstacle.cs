using UnityEngine;

public class DeplacementObstacle : MonoBehaviour
{
    public float vitesse = 0.01f;
    public float limiteHaut = 10f;
    public float limiteBas = -10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, vitesse, 0, Space.World);
        if (transform.position.y > limiteHaut || transform.position.y < limiteBas)
        {

            // float nouvellePositionX = transform.position.x;
            // float nouvellePositionY = limiteBas;
            // transform.position = new Vector2(nouvellePositionX, nouvellePositionY);
            vitesse = vitesse * -1;
        }
        //Si l'élément sort de l'écran, le replacer 
    }
}
