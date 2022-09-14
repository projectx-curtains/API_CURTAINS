FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
ENV ASPNETCORE_ENVIRONMENT=Production
ENV ASPNETCORE_URLS=http://0.0.0.0:8080
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
ADD Curtains /src/
RUN dotnet restore "Curtains.Api/Curtains.Api.csproj"
RUN dotnet build "Curtains.Api/Curtains.Api.csproj" -c Release -o /app
FROM build AS publish
RUN dotnet publish "Curtains.Api/Curtains.Api.csproj" -c Release -o /app
FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Curtains.Api.dll"]