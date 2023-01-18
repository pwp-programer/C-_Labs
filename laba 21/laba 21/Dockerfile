FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["laba 21/laba 21.csproj", "laba 21/"]
RUN dotnet restore "laba 21/laba 21.csproj"
COPY . .
WORKDIR "/src/laba 21"
RUN dotnet build "laba 21.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "laba 21.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "laba 21.dll"]
