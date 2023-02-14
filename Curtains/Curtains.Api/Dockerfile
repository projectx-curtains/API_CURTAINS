FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Curtains.Api/Curtains.Api.csproj", "Curtains.Api/"]
COPY ["Curtains.Application/Curtains.Application.csproj", "Curtains.Application/"]
COPY ["Curtains.Domain/Curtains.Domain.csproj", "Curtains.Domain/"]
COPY ["Curtains.Infrastructure/Curtains.Infrastructure.csproj", "Curtains.Infrastructure/"]
RUN dotnet restore "Curtains.Api/Curtains.Api.csproj"
COPY . .
WORKDIR "/src/Curtains.Api"
RUN dotnet build "Curtains.Api.csproj" -o /app/build /p:UseAppHost=false

FROM build AS publish
RUN dotnet publish "Curtains.Api.csproj" -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Curtains.Api.dll"]