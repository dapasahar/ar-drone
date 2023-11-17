# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Targets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Mostrar mensajes según el estado del Ground Plane

1. Añadimos a la escena el prefab Output Canvas
2. En el componente `Default Observer Event Handler` del Ground Plane Stage, asignamos un manejador de eventos a su evento `On Traget Lost`
	- `On Target Lost` a `Output Text > Text.text` la pasaremos la cadena `"Target perdido"`
	- `On Target Lost` a `Plane Finder > GameObject.SetActive()` la pasaremos el bool `true`
3. En el componente `Plane Finder Behaviour` del Plane Finder, asignamos un manejador de eventos a su evento `Automatic Hit Test`
	- `Automatic Hit Test` a `Output Text > Text.text` la pasaremos la cadena `"Clic para empezar el juego"`
4. En el componente `Default Observer Event Handler` del Ground Plane Stage, asignamos un manejador de eventos a su evento `On Content Placed`
	- `On Content Placed` a `Output Text > Text.text` la pasaremos la cadena `"Juego colocado"`
	- `On Content Placed` a `Plane Finder > GameObject.SetActive()` la pasaremos el bool `false`
5. Probamos el juego y comprobamos como cambia el texto en pantalla según Vuforia tenga trakeado el target o no.