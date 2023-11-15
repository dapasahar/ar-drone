# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Targets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Crear el layout de la escena

En el juego, el jugador mueve la cámara y en el punto del suelo hacia el que apunta esta se dibuja una marca. El dron se dirige siempre a la posición de esa marca, de forma que el jugador pueda controlarlo moviendo la cámara.

Pasamos a crear los elementos mínimos para, más adelante, poder añadir las funcionalidades:

1. Un prefab para la Marca Destino. Dentro de este prefab colocamos un circulo (`GameObject > 2D > Sprites > Circle`) rojo girado para que quede horizontal.
2. Un prefab para el Dron. Dentro colocamos un cubo (`GameObject > 3D > Cube`) escalado de forma que quede más largo en el eje Z para que se aprecie hacia dónde mira y elevado ligeramente para que parezca que flota, y un cuadrado (`GameObject > 2D > Sprites > Square`) con un color negro semitransparente y escalado de forma proporcional al cubo para que parezca su sombra.
3. Un prefab para toda la Escena, que contendrá el Dron, la Marca Destino y un plano que simulará el suelo.
4. Para que el suelo no se visualice, creamos un material Suelo con el shader `DepthMask` y se lo aplicamos.
5. Definimos una capa Suelo y se la aplicamos al GameObject Suelo.
6. Por último, el prefab Escena lo colocamos como hijo del Image Target.

Ahora podemos probar el juego y comprobar que todo se visualiza correctamente.