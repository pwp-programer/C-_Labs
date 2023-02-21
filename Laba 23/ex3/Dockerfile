FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ex3/ex3.csproj", "ex3/"]
RUN dotnet restore "ex3/ex3.csproj"
COPY . .
WORKDIR "/src/ex3"
RUN dotnet build "ex3.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ex3.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ex3.dll"]
