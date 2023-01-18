FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Secondary/Secondary.csproj", "Secondary/"]
RUN dotnet restore "Secondary/Secondary.csproj"
COPY . .
WORKDIR "/src/Secondary"
RUN dotnet build "Secondary.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Secondary.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Secondary.dll"]
