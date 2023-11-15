# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Tragets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Instalar y configurar las Image Targets de Vuforia

Para poder usar Image Targets con Vuforia hay que registrase como desarrollador de Vuforia, conseguir una App License Key y crear una Database con sus correspondientes Targets [Más información](https://developer.vuforia.com/library/getting-started/register-vuforia-engine-developer)

En este caso, por cuestiones de seguridad y funcionalidad, se usarán los Targets incluidos en el proyecto de demo de Vuforia (disponible en [Vuforia Core Samples](https://assetstore.unity.com/packages/templates/packs/vuforia-core-samples-99026)) que no necesitan License Key para ser usados. Las imágenes están disponibles para su descarga en [Target Samples](https://developer.vuforia.com/sites/default/files/vuforia-library/docs/target_samples/unity/mars_target_images.pdf)

Si se quiere usar otros Targets el proceso sería:

1. En Unity, abrir la configuración de Vuforia (`Window > Vuforia Configuration`).
2. Introducir la License Key en el campo `App License Key`.
3. Cargar una base de datos con el botón `Add Database`.