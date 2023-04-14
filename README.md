# Sistema De Automatización De Asistencia Biometrica Estudiantil Para La ESFE

> Proyecto educativo creado por el grupo 3 en el modulo de codificación de sistemas informaticos de la ESE en el grupo 03-1°TIDS 

Este proyecto es un sistema que utiliza un lector de huella dactilar DigitalPersona UareU 4500 para automatizar la toma de asistencia de los alumnos.

## Requisitos
* Microsoft Visual Studio instalado.
* Lector de huella digital DigitalPersona UareU 4500.
* SDK del Lector instalado.
* Dependencias específicas importadas en Visual Studio.
* Sistema operativo Windows 10.

## Instalación
1. Clonar este repositorio en tu máquina local.
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

