# Juego Multimedia Principal

Proyecto de Alexcito basado en el documento **Creando un videojuego 2D con Unity** de Rubén Gonzalo Soria Soria (2026). Esta copia parte de [JuegoMultimediaPrincipal](https://github.com/lpzealexjoelquispeti-dot/JuegoMultimediaPrincipal) y conserva sus commits originales; los cambios posteriores están separados por fases en el historial.

- Unity **6000.3.16f1**, plantilla Universal 2D.
- Abrir la carpeta `My project` desde Unity Hub. No abrir la raíz del repositorio como proyecto Unity.
- Recursos originales **Legacy Fantasy - High Forest** y **Legacy Fantasy - Debug Map**, de Anokolisa, tal como indica el PDF.
- Plataforma: escritorio, con teclado. Android queda fuera del alcance.
- Se sigue el orden del tutorial, corrigiendo los problemas de implementación y completando el pisotón del caracol.

## Avances

1. Proyecto base y configuración de Git.
2. Escenario, físicas, movimiento, salto, animaciones y cámara.
3. Recolección, marcador, peligros, reinicio y caracol.

El proyecto se limita a escritorio: A/D o flechas para moverse y espacio para saltar. Las abejas aumentan el marcador; tocar el jabalí, el caracol por un costado o caer fuera del nivel reinicia la escena. Se puede derrotar al caracol al caer sobre él.

## Abrir y probar

1. Instalar o seleccionar **Unity 6000.3.16f1** en Unity Hub y añadir `My project` como proyecto.
2. Abrir `Assets/Scenes/NivelBosque.unity` y pulsar **Play**. Esa escena también está habilitada como escena inicial en Build Settings.
3. Mover al jugador con **A/D** o las flechas; saltar con **Espacio**. Si Unity pregunta por la configuración de entrada, elegir **Both** y dejar que el editor reinicie.
4. Comprobar la recolección de las tres abejas y el contador; probar el reinicio al tocar el jabalí, el caracol lateralmente o el límite de caída. Caer encima del caracol debe aplastarlo y hacer rebotar al jugador.

No se requiere Android ni se incluyen pasos de compilación para esa plataforma. Los archivos generados por Unity (`Library`, `Temp`, `Logs` y compilaciones) están excluidos de Git.

## Recursos

Fuente oficial: https://anokolisa.itch.io/sidescroller-pixelart-sprites-asset-pack-forest-16x16

Los gráficos pertenecen a Anokolisa; sus condiciones de uso son independientes del código de este proyecto.
