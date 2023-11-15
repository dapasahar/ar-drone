using UnityEngine;

/// <summary>
/// Componente para colocar la marca en el punto del suelo al que mira la c�mara.
/// </summary>
public class MarcaDestino : MonoBehaviour
{
    [Tooltip("Capas que se considerar�n parte del suelo")]
    [SerializeField] LayerMask suelo;

    Camera cam;

    void Start()
    {
        // Como c�mara usaremos la MainCamera de la escena (en principio la ARCamera de Vuforia)
        cam = Camera.main;
    }

    void Update()
    {
        // Trazamos un rayo desde la c�mara por el centro del viewport (la pantalla)
        Ray lineaVision = cam.ViewportPointToRay(new Vector3(.5f, .5f, 0));

        // Si el rayo intersecta cualquier objeto del suelo
        if(Physics.Raycast(lineaVision, out RaycastHit hitInfo, 100f, suelo))
        {
            // Colocamos el GameObject en el punto de intersecci�n
            transform.position = hitInfo.point;
        }
    }
}
