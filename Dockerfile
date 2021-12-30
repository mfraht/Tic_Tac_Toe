#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Tic_Tac_Toe.csproj", "."]
RUN dotnet restore "./Tic_Tac_Toe.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Tic_Tac_Toe.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tic_Tac_Toe.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tic_Tac_Toe.dll"]