#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Snowflake.API/Snowflake.API.csproj", "Snowflake.API/"]
COPY ["Snowflake.Model/Snowflake.Model.csproj", "Snowflake.Model/"]
RUN dotnet restore "Snowflake.API/Snowflake.API.csproj"
COPY . .
WORKDIR "/src/Snowflake.API"
RUN dotnet build "Snowflake.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Snowflake.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Snowflake.API.dll"]
