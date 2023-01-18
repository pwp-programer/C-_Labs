FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["laba 16/laba 16.csproj", "laba 16/"]
RUN dotnet restore "laba 16/laba 16.csproj"
COPY . .
WORKDIR "/src/laba 16"
RUN dotnet build "laba 16.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "laba 16.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "laba 16.dll"]
