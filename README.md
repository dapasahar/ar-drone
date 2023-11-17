# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Targets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Mostrar mensajes según el estado del target

1. Para poder mostrar textos en pantalla creamos un canvas Output Canvas con un texto en su interior Output Text.
2. Convertimos el canvas en un prefab.
3. En el componente `Default Observer Event Handler` del Image Traget, asignamos manejadores de eventos a sus eventos `On Target Found` y `On Traget Lost`
	- `On Target Found` a `Output Text > Text.text` la pasaremos la cadena `"Target encontrado"`
	- `On Target Lost` a `Output Text > Text.text` la pasaremos la cadena `"Target perdido"`
4. Probamos el juego y comprobamos como cambia el texto en pantalla según Vuforia tenga trakeado el target o no.