#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Unillanos.Ingenieria.Proyecto/Unillanos.Ingenieria.Proyecto.csproj", "Unillanos.Ingenieria.Proyecto/"]
RUN dotnet restore "Unillanos.Ingenieria.Proyecto/Unillanos.Ingenieria.Proyecto.csproj"
COPY . .
WORKDIR "/src/Unillanos.Ingenieria.Proyecto"
RUN dotnet build "Unillanos.Ingenieria.Proyecto.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Unillanos.Ingenieria.Proyecto.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Unillanos.Ingenieria.Proyecto.dll"]