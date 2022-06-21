#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["server/Dapr.SubscribeYamlApi/Dapr.SubscribeYamlApi.csproj", "server/Dapr.SubscribeYamlApi/"]
RUN dotnet restore "server/Dapr.SubscribeYamlApi/Dapr.SubscribeYamlApi.csproj"
COPY . .
WORKDIR "/src/server/Dapr.SubscribeYamlApi"
RUN dotnet build "Dapr.SubscribeYamlApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dapr.SubscribeYamlApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dapr.SubscribeYamlApi.dll"]