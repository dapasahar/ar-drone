# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Targets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Hacer que el Dron siga a la Marca Destino


1. En el panel Navigation (`Window > AI > Navigation`) definimos un nuevo tipo de agente, Dron, para que se ajuste a las dimensiones de nuestro Dron, con las opciones `Radius` 0.05, `Height` 0.12, `Step Height` 0.03
2. Dentro del prefab Escena, al GameObject Suelo le añadimos un componente `NavMeshSuface`.
3. En este componente, seleccionamos como `Agent Type` el que acabamos de crear, en la propiedad `Include Layers` seleccionamos la capa Suelo y pulsamos `Bake` para generar la malla de navegación.
4. Creamos un script de C# `Dron` y se lo asignamos al prefab Dron. Este script requiere la presencia de un componente `NavMeshAgent`, al asignarlo al GameObject se añadirá también un componente de este tipo. (Ver el script para más info)
5. En el comonente `NavMeshAgent` del Dron, establecemos `Agent Type` como el que hemos definido previamente y los parámetros `Radius` y `Height` como los correspondientes del agente.
6. Probamos el juego.