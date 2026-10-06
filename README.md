# WebSocket en ASP.NET Core

Servidor y cliente WebSocket en C#, sin librerías externas: solo `System.Net.WebSockets`.

- **Servidor** (`WebApplication1/`): ASP.NET Core con un endpoint `/send` que acepta la conexión,
  registra cada mensaje del cliente y responde con la hora del servidor. Mantiene la conexión viva
  con *keep-alive* de 120 s y cierra limpio cuando el cliente se va.
- **Cliente de consola** (`wb-client/`): se conecta a `ws://localhost:5000/send`, envía lo que escribes
  y lee la respuesta por fragmentos hasta el fin del mensaje.
- **Cliente web** (`index.html`): un chat mínimo en el navegador con la API `WebSocket` de JavaScript.

## Cómo correrlo

Requiere el SDK de .NET Core 3.1.

```bash
# terminal 1: servidor
dotnet run --project WebApplication1

# terminal 2: cliente de consola
dotnet run --project wb-client
```

En Visual Studio: **Propiedades de la solución → Proyectos de inicio múltiples**, y marca
`wbserver` y `wbclient` como *Iniciar*.

## Stack
C# · ASP.NET Core 3.1 · WebSockets · MongoDB.Driver (modelo base preparado para persistir mensajes)
