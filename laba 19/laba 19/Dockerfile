FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["laba 19/laba 19.csproj", "laba 19/"]
RUN dotnet restore "laba 19/laba 19.csproj"
COPY . .
WORKDIR "/src/laba 19"
RUN dotnet build "laba 19.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "laba 19.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "laba 19.dll"]
