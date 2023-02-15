FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Laba 22/Laba 22.csproj", "Laba 22/"]
RUN dotnet restore "Laba 22/Laba 22.csproj"
COPY . .
WORKDIR "/src/Laba 22"
RUN dotnet build "Laba 22.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Laba 22.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Laba 22.dll"]
