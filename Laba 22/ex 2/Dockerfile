FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["ex 2/ex 2.csproj", "ex 2/"]
RUN dotnet restore "ex 2/ex 2.csproj"
COPY . .
WORKDIR "/src/ex 2"
RUN dotnet build "ex 2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "ex 2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "ex 2.dll"]
