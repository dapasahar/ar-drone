# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Targets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Primera prueba con Image Target

Como primer ejercicio, y para comprobar que, efectivamente, todo está bien configurado, podemos hacer que una Image Target muestre un cubo en la escena.

1. Eliminamos de la escena la cámara que se crea por defecto.
2. Creamos una cámara AR (`GameObject > Vuforia Engine > AR Camera`) y ajustamos en su componente `Vuforia Behaviour` la opción `World Center Mode` a `FIRST_TARGET`, para que coloque en el centro de la escena el primer target que encuentre (en nuestro caso el que crearemos después) y la cámara se posicione en relación a este.
3. Creamos un Image Target (`GameObject > Vuforia Engine > Image Target`).
4. Configuramos el componente `Image Target` con los siguientes valores:
	- `Type` - `From Database`
	- `Database` - Seleccionamos la que corresonda de las que tengamos importadas (en este proyecto `VuforiaMars_Images`)
	- `Image Target` - Seleccionamos el que corresponda de los que contenga la Database (en este proyecto `Drone`)
5. Creamos un cubo como hijo del Image Target y lo escalamos 0.05 unidades en los tres ejes y lo colocamos un poco por encima de la imagen.

#### Probar la aplicación

Para probar la aplicación una de las opciones más comodas es utilizar una webcam USB conectada al ordenador, que podamos mover libremente para simular el dispositivo móvil. 

1. En la cofiguración de Vuforia (`Window > Vuforia Configuration`), en la opción `PlayMode Type` seleccionamos `WEBCAM` y en `Camera Device` la webcam que tengamos conectada.
2. Deberíamos disponer de la imagen impresa en papel o cualquier medio que nos permita enfocarla con la webcam.
3. Probamos la escena como cualquier otra de Unity.
4. En la ventana `Game` podremos ver lo que enfoca la webcam, y cuando encuadre la imagen veremos que aparece el cubo.