# ServicePool

## Releases

**Package Manager**  
```sh
PM> Install-Package TheXDS.ServicePool
```

**.NET CLI**  
```sh
dotnet add package TheXDS.ServicePool
```

**Paket CLI**  
```sh
paket add TheXDS.ServicePool
```

**Referencia de paquete**  
```xml
<PackageReference Include="TheXDS.ServicePool" Version="0.1.0" />
```

**Ventana interactiva (CSI)**  
```
#r "nuget: TheXDS.ServicePool, 0.1.0"
```

## Building
### Prerequisites
- [.Net SDK 5.0](https://dotnet.microsoft.com/) or higher.

### Build ServicePool
```sh
dotnet build ./src/ServicePool.sln
```
The resulting binaries will be in the `Build/bin` directory.

### Testing ServicePool
```sh
dotnet test ./src/ServicePool.sln
```