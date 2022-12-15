#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AntarisApi/AntarisApi.Web.csproj", "AntarisApi/"]
RUN dotnet restore "AntarisApi/AntarisApi.Web.csproj"
COPY . .
WORKDIR "/src/AntarisApi"
RUN dotnet build "AntarisApi.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AntarisApi.Web.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AntarisApi.Web.dll"]