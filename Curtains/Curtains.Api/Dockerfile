<<<<<<< HEAD
=======
#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

>>>>>>> 56f1e4665c819b911b68ac0fa7cef151e265113e
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
<<<<<<< HEAD
RUN dotnet build "Curtains.Api.csproj" -o /app/build /p:UseAppHost=false

FROM build AS publish
RUN dotnet publish "Curtains.Api.csproj" -o /app/publish /p:UseAppHost=false
=======
RUN dotnet build "Curtains.Api.csproj" -c Development -o /app/build

FROM build AS publish
RUN dotnet publish "Curtains.Api.csproj" -c Development -o /app/publish /p:UseAppHost=false
>>>>>>> 56f1e4665c819b911b68ac0fa7cef151e265113e

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Curtains.Api.dll"]