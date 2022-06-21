#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["server/Dapr.OtherSubscribeByYamlApi/Dapr.OtherSubscribeByYamlApi.csproj", "server/Dapr.OtherSubscribeByYamlApi/"]
RUN dotnet restore "server/Dapr.OtherSubscribeByYamlApi/Dapr.OtherSubscribeByYamlApi.csproj"
COPY . .
WORKDIR "/src/server/Dapr.OtherSubscribeByYamlApi"
RUN dotnet build "Dapr.OtherSubscribeByYamlApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Dapr.OtherSubscribeByYamlApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Dapr.OtherSubscribeByYamlApi.dll"]