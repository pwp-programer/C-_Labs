FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Laba 23/Laba 23.csproj", "Laba 23/"]
RUN dotnet restore "Laba 23/Laba 23.csproj"
COPY . .
WORKDIR "/src/Laba 23"
RUN dotnet build "Laba 23.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Laba 23.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Laba 23.dll"]
