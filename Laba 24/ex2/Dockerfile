FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ex2/ex2.csproj", "ex2/"]
RUN dotnet restore "ex2/ex2.csproj"
COPY . .
WORKDIR "/src/ex2"
RUN dotnet build "ex2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ex2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ex2.dll"]
