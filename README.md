# SolarChimney_Erasmus25
In March and April 2025 a Blended Intensive Programme funded by European Union through ERASMUS+ was held at TOBB University, Department of Architecture, in Ankara, Turkey. 

During that time the AR App was created by Prof. Dr. J. Tümler from Anhalt University, Köthen, Germany.
The AR project makes use of Unity's AR Foundation and was tested on Android only.

![Screenshot of real and virtual solar chimney prototype](https://github.com/HSA-JoT/SolarChimney_Erasmus25/blob/main/Assets/Textures/Photo.jpg?raw=true "Screenshot of real and virtual solar chimney prototype")

## Installation

Download the APK from \Release and install it. It will require access to your camera for the AR functionality. It can save screenshots to your file system at \DCIM on your phone.

## App manual

- Move your phone around slowly to let it detect planes.
- Once you see yellow planes appear, you can tap on a position within a plane and a red sphere will appear to visualise a placement anchor.
- Click on "Next" button to switch to next Solar Chimney prototype.
- Click on "Planes" button do disable/enable plane visualisation.
- Click on "Screenshot" button to generate a screenshot from the current view. It will be stored in \DCIM and us usually not visible in your gallery (use file browser).
- Click on "Exit" to quit the app.

## Unity development

- Fork the repository.
- Open with Unity 6000.0.46f1 with Android Build Support.
- Switch platform to Android (File -> Build profiles -> activate Android).
- Select Build to build the APK, then copy it to your phone and install it.
- OR: Select Build And Run, if your phone is already setup for direct deployment.
