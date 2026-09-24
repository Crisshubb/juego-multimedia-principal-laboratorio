using UnityEngine;

// Conserva el fondo original del PDF cubriendo la pantalla al seguir al jugador.
[DefaultExecutionOrder(100)]
[RequireComponent(typeof(SpriteRenderer))]
public class FondoCamara : MonoBehaviour
{
    public Camera camara;
    SpriteRenderer fondo;
    void Awake()
    {
        fondo = GetComponent<SpriteRenderer>();
        if (camara == null) camara = Camera.main;
    }

    void LateUpdate()
    {
        // Tambien cubre una camara principal activada despues de este fondo.
        if (camara == null) camara = Camera.main;
        if (camara == null || fondo.sprite == null) return;
        var bounds = fondo.sprite.bounds;
        float height = camara.orthographicSize * 2;
        float scale = Mathf.Max(height / bounds.size.y, height * camara.aspect / bounds.size.x);
        transform.localScale = new Vector3(scale, scale, 1);
        var center = bounds.center * scale;
        transform.position = new Vector3(camara.transform.position.x - center.x, camara.transform.position.y - center.y, 1);
    }
}
