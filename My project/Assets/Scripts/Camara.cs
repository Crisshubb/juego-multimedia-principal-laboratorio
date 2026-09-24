using UnityEngine;

public class Camara : MonoBehaviour
{
    public Transform target;
    [SerializeField] Vector2 desplazamiento;

    void Awake()
    {
        if (target == null)
        {
            var jugador = FindFirstObjectByType<Jugador>();
            if (jugador != null) target = jugador.transform;
        }
    }

    void LateUpdate()
    {
        if (target != null)
            transform.position = new Vector3(
                target.position.x + desplazamiento.x,
                target.position.y + desplazamiento.y,
                transform.position.z);
    }
}
