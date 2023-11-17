# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Targets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Usar Ground Plane para posicionar l aescena

1. Creamos una nueva escena GroundPlane
2. Eliminamos de la escena la cámara que se crea por defecto.
3. Creamos una cámara AR (`GameObject > Vuforia Engine > AR Camera`) y ajustamos en su componente `Vuforia Behaviour` la opción `World Center Mode` a `FIRST_TARGET`, para que coloque en el centro de la escena el primer target que encuentre (en nuestro caso el que crearemos después) y la cámara se posicione en relación a este.
4. Creamos un Ground Plane Stage (`GameObject > Vuforia Engine > Ground Plane > Ground Plane Stage`).
5. Creamos un Plane Finder (`GameObject > Vuforia Engine > Ground Plane > Plane Finder`).
6. Configuramos el componente `Content Positioning Behaviour` con los siguientes valores:
	- `Anchor Stage` - Asignamos el Ground Plane Stage que hemos creado previamente.
	- `Duplicate Stage` - Desmarcamos el checkbox.
7. Colocamos el prefab Escena como hijo del Ground Plane Stage.
8. Probamos el juego. Si usamos una webcam, para simular un suelo, podemos imprimir y utilizar la imágen disponible en el proyecto en `Assets/Editor/Vuforia/ImageTargetTextures/VuforiaEmulator/emulator_ground_plane_scaled.jpg`.
9. Al probar el juego comprobaremos que cuando Vuforia encuentra una superficie plana, se dibuja un retícula indicándolo (esta retícula se puede personalizar com la propiedad `Plane Indicator` del componente `Plane Finder`) y entonces, haciendo clic, el usuario puede colocar la escena.