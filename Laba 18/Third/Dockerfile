FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Third/Third.csproj", "Third/"]
RUN dotnet restore "Third/Third.csproj"
COPY . .
WORKDIR "/src/Third"
RUN dotnet build "Third.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Third.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Third.dll"]
