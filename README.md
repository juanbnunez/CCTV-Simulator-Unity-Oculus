# CCTV-Simulator-Unity-Oculus
CCTV Simulator with Unity for Oculus Meta Quest

- [English](#english)  
- [Español](#español)

---
## Class Diagram
![UML](https://drive.google.com/uc?export=view&id=17OLow6OPDOWpwmWCRrxUjhmYVwOT49nv)


## Español

### Descripción del Proyecto

Este proyecto es un simulador de un sistema de CCTV desarrollado en Unity 2021.3.26f para los dispositivos Oculus Meta Quest. El sistema está diseñado para mostrar múltiples cámaras de seguridad en diferentes pantallas dentro de un entorno virtual, permitiendo la interacción del usuario a través de los Oculus Quest y los controladores asociados. El propósito del sistema es simular la operación de un circuito cerrado de televisión (CCTV), permitiendo cambiar entre diferentes cámaras, visualizar múltiples perspectivas y controlar las cámaras a través de botones de dirección.

El simulador puede ser útil en la evaluación y el entrenamiento en la gestión de sistemas de vigilancia, o para la representación de cámaras en entornos de realidad virtual.

#### Paquetes Utilizados:
- **Meta XR All-in-One SDK** Version 64.0.0
- **Meta XR Interaction SDK OVR Samples** Version 64.0.0

### Instrucciones de Instalación

#### Requisitos Previos:
1. **[Unity 2021.3.26f](https://unity.com/releases/editor/archive)**
2. **[Meta XR All-in-One SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269657?srsltid=AfmBOoomH4ef8MtPOW2FFfZzB_0V33RiS5IiCF7u2wC_dPv0Z88LhxST)** y **[Meta XR Interaction SDK OVR Samples](https://assetstore.unity.com/packages/tools/integration/deprecated-meta-xr-interaction-sdk-ovr-samples-268521?srsltid=AfmBOorfXrgCD-Mn7PdwPhzxlJyM54nL9jpQoyPyB5_vr7TPE-NSzwp3)** instalados desde el Package Manager de Unity.
3. **Oculus Meta Quest** y **Oculus Link**

#### Pasos de Instalación:

1. Clonar el repositorio o descargar el proyecto:
   ```bash
   git clone https://github.com/juanbnunez/CCTV-Simulator-Unity-Oculus.git
   ```

2. Abrir el proyecto en Unity 2021.3.26f.

3. Configurar el proyecto para los Oculus Meta Quest:
   - Ir a **File > Build Settings**.
   - Seleccionar **Android** como plataforma de destino.
   - Asegurarse de que **Oculus** está seleccionado como SDK en las opciones de **XR Plugin Management**.

4. Importar los paquetes necesarios:
   - Instalar **Meta XR All-in-One SDK** y **Meta XR Interaction SDK OVR Samples** desde el **Package Manager**.

5. Conectar los Oculus Meta Quest:
   - Conectar los Oculus Meta Quest a la PC mediante **Oculus Link**.
   - Activar el **Developer Mode** en los Oculus para poder desplegar la aplicación.

6. Construir y desplegar:
   - Ir a **File > Build and Run** para compilar el proyecto y ejecutarlo directamente en los Oculus Meta Quest.

### Guía de Uso

El sistema permite al usuario cambiar entre múltiples cámaras de CCTV a través de un controlador en el entorno de realidad virtual. Las cámaras están vinculadas a texturas de renderizado que se muestran en pantallas dentro del entorno.

![Clase MainController](https://drive.google.com/uc?export=view&id=1G3NBaGOTK5xi_K1WXTvnlgz6yPj6iOP5)

#### Funcionalidades Principales:

- **Cambio de Cámara**: El usuario puede cambiar entre las cámaras de CCTV usando los botones en el controlador (Next, Back, Up, Down, Left, Right).
- **Interacción con Pantallas**: Las cámaras se proyectan en diferentes pantallas dentro del entorno. El usuario puede observar las diferentes perspectivas a través de estas pantallas.

#### Ejemplos de Comandos:

- **Botón "Next"**: Cambia a la siguiente cámara en la lista.
- **Botón "Back"**: Vuelve a la cámara anterior.
- **Botón "Up" / "Down" / "Left" / "Right"**: Mueve la perspectiva de las cámara que se está mostrando en pantalla.

![CameraController](https://drive.google.com/uc?export=view&id=1pYP1ryT_AiNL0s8AjvKocYEbwh6dqDmh)


#### Configuraciones Recomendadas:
- Utilizar el sistema en un área abierta para mayor comodidad al interactuar con los Oculus Meta Quest.
- Configurar la tasa de cuadros por segundo (FPS) a 72Hz para una experiencia más fluida en Oculus Quest.

### Contribuciones y Créditos

Este proyecto fue desarrollado por [Juan Núñez](https://github.com/juanbnunez) como parte del proyecto [Tec-Verse (Metaverso)](https://github.com/diegovega25/Tecverse) de la [Unidad de Ingeniería en Computación, Campus Tecnológico Local San Carlos](https://www.tec.ac.cr/unidad-ingenieria-computacion-san-carlos), con la colaboración de las siguientes herramientas y recursos:

- **Unity Technologies**: Motor de desarrollo del juego.
- **Meta XR SDK**: SDK oficial para el desarrollo en Oculus Meta Quest.
- **Oculus Developer Hub**: Herramienta para gestionar la depuración y el despliegue en los Oculus Quest.

Agradecimiento especial a todos los desarrolladores que colaboraron con consejos y sugerencias.

Agradecemos a los creadores de las tecnologías mencionadas por proporcionar las herramientas que hicieron posible el desarrollo de este simulador.

---

## English

### Project Description

This project is a CCTV system simulator developed in Unity 2021.3.26f for Oculus Meta Quest devices. The system is designed to display multiple security cameras on different screens within a virtual environment, allowing user interaction via Oculus Quest and associated controllers. The purpose of the system is to simulate the operation of a closed-circuit television (CCTV), allowing users to switch between different cameras, view multiple perspectives, and control the cameras through directional buttons.

The simulator can be useful for evaluating and training in the management of surveillance systems, or for representing cameras in virtual reality environments.

#### Used Packages:
- **Meta XR All-in-One SDK** Version 64.0.0
- **Meta XR Interaction SDK OVR Samples** Version 64.0.0

### Installation Instructions

#### Prerequisites:
1. **[Unity 2021.3.26f](https://unity.com/releases/editor/archive)**
2. **[Meta XR All-in-One SDK](https://assetstore.unity.com/packages/tools/integration/meta-xr-all-in-one-sdk-269657?srsltid=AfmBOoomH4ef8MtPOW2FFfZzB_0V33RiS5IiCF7u2wC_dPv0Z88LhxST)** y **[Meta XR Interaction SDK OVR Samples](https://assetstore.unity.com/packages/tools/integration/deprecated-meta-xr-interaction-sdk-ovr-samples-268521?srsltid=AfmBOorfXrgCD-Mn7PdwPhzxlJyM54nL9jpQoyPyB5_vr7TPE-NSzwp3)** installed via Unity's Package Manager.
3. **Oculus Meta Quest** and **Oculus Link** configured.

#### Installation Steps:

1. Clone the repository or download the project:
   ```bash
   git clone https://github.com/juanbnunez/CCTV-Simulator-Unity-Oculus.git
   ```

2. Open the project in Unity 2021.3.26f.

3. Configure the project for Oculus Meta Quest:
   - Go to **File > Build Settings**.
   - Select **Android** as the target platform.
   - Ensure that **Oculus** is selected as the SDK in the **XR Plugin Management** settings.

4. Import necessary packages:
   - Install **Meta XR All-in-One SDK** and **Meta XR Interaction SDK OVR Samples** from the **Package Manager**.

5. Connect Oculus Meta Quest:
   - Connect the Oculus Meta Quest to the PC via **Oculus Link**.
   - Activate **Developer Mode** on the Oculus to deploy the app.

6. Build and deploy:
   - Go to **File > Build and Run** to compile the project and run it directly on the Oculus Meta Quest.

### Usage Guide

The system allows users to switch between multiple CCTV cameras through a controller in the virtual reality environment. The cameras are linked to render textures that display on screens within the environment.

![Clase MainController](https://drive.google.com/uc?export=view&id=1G3NBaGOTK5xi_K1WXTvnlgz6yPj6iOP5)

#### Main Features:

- **Camera Switching**: Users can switch between CCTV cameras using the buttons on the controller (Next, Back, Up, Down, Left, Right).
- **Screen Interaction**: Cameras are projected onto different screens within the environment. Users can view different perspectives through these screens.

#### Command Examples:

- **"Next" Button**: Switches to the next camera in the list.
- **"Back" Button**: Returns to the previous camera.
- **"Up" / "Down" / "Left" / "Right" Buttons**: Moves the perspective of the camera currently displayed on the screen.

![CameraController](https://drive.google.com/uc?export=view&id=1pYP1ryT_AiNL0s8AjvKocYEbwh6dqDmh)

#### Recommended Settings:
- Use the system in an open area for better comfort while interacting with the Oculus Meta Quest.
- Set the frame rate to 72Hz for a smoother experience on Oculus Quest.

### Contributions and Credits

This project was developed by [Juan Núñez](https://github.com/juanbnunez) as part of the [Tec-Verse (Metaverse)](https://github.com/diegovega25/Tecverse) project from the [Computer Engineering Unit, Local Technological Campus San Carlos](https://www.tec.ac.cr/unidad-ingenieria-computacion-san-carlos), with the collaboration of the following tools and resources:

- **Unity Technologies**: Game development engine.
- **Meta XR SDK**: Official SDK for development on Oculus Meta Quest.
- **Oculus Developer Hub**: Tool for managing debugging and deployment on Oculus Quest.

Special thanks to all the developers who contributed with advice and suggestions.

We would also like to thank the creators of the mentioned technologies for providing the tools that made the development of this simulator possible.