using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
/// <summary>
/// Componente para controlar el movimiento del Dron
/// </summary>
public class Dron : MonoBehaviour
{
    [Tooltip("Objeto hacia el que se dirige el dron")]
    [SerializeField] Transform objetivo;

    NavMeshAgent agent;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        // Mover el dron hacia la posición del target
        agent.SetDestination(objetivo.position);
    }
}
