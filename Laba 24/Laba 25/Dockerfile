FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Laba 25/Laba 25.csproj", "Laba 25/"]
RUN dotnet restore "Laba 25/Laba 25.csproj"
COPY . .
WORKDIR "/src/Laba 25"
RUN dotnet build "Laba 25.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Laba 25.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Laba 25.dll"]
