#See https://aka.ms/containerfastmode to understand how Visual Studio uses this 
#Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["BuggyBits.csproj", "BuggyBits/"]
RUN dotnet restore "BuggyBits/BuggyBits.csproj"
COPY . .
WORKDIR "/src/BuggyBits"
RUN dotnet build "BuggyBits.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BuggyBits.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BuggyBits.dll"]