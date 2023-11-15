# ARDrone

Proyecto de Unity para la asignatura "Proyecto Entornos Interactivos Avanzados" del 4º curso del Grado en Tecnologías Interactivas.

El objetivo del proyecto es demostrar los aspectos básicos del trabajo en realidad aumentada con Unity y Vuforia usando como targets [Image Tragets](https://developer.vuforia.com/library/objects/image-targets) y [Ground Plane](https://developer.vuforia.com/library/environments/ground-plane).


### Crear el proyecto de Unity

1. En la raiz del repositorio se crean dos carpetas vacías, `Assets` y `ProjectSettings`.
2. Desde Unity Hub se abre la carpeta del repositorio como un nuevo proyecto de Unity.
   Unity generará todos los archivos y directorios necesarios para el proyecto.
3. Cambiar la plataforma de publicación a Android `(File > Build Settings...)`.
4. Instalar los paquetes mínimos necesarios `(Window > Package Manager)`.
   Deberían ser al menos:
   - Unity UI, para poder usar componentes para la interfaz de usuario.
   - Visual Studio Editor, para vincular Unity y Visual Studio 2022 (si se usa otro editor de código, instalar el paquete correspondiente)
   - 2D Sprite, para trabajar con sprites 2D
   - AI Navigation, para trabajar con pathfinding.
5. Crear la estructura básica del proyecto.

```
Assets
└── [AR-Drone]		// Carpeta para los assets propios del proyecto
    └── Scenes		// Carpeta con todas las escenas del proyecto
        └── Main	// Escena inicial del proyecto
```