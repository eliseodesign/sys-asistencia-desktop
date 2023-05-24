# Sistema De Automatización De Asistencia Biometrica Estudiantil Para La ESFE

Este proyecto es un sistema que utiliza un lector de huella dactilar DigitalPersona UareU 4500 para automatizar la toma de asistencia de los alumnos.

## Requisitos
* Microsoft Visual Studio instalado.
* Base de datos [BDSysAsistencia](https://github.com/eliseodesign/sys-asistencia-db).
* Lector de huella digital DigitalPersona UareU 4500.
* SDK del Lector instalado.
* Dependencias específicas importadas en Visual Studio.
* Sistema operativo Windows 10.

## Instalación
1. Clonar este repositorio en tu máquina local.
3. Clonar [sys-asistencia-db](https://github.com/eliseodesign/sys-asistencia-db) y ejecutar run.bat, sino deseas hacer esto puedes ejecutar los scripts por separado
2. Abrir el proyecto en Visual Studio.
3. Importar las dependencias buscar la carpeta bin y seleccionar las siguientes .dll

```md
C:\
└── Program Files\
    └── DigitalPersona\
        └── One Touch SDK\
            └── .NET\
                └── Bin\
                    - DPFPDevNET.dll
                    - DPFPEngNET.dll
                    - DPFPShrNET.dll
                    - DPFPVerNET.dll

```

## Uso
Una vez que el proyecto esté en ejecución, el usuario puede utilizar el lector de huella dactilar para registrar su asistencia. El sistema mostrará un mensaje de confirmación de asistencia registrada con éxito.

