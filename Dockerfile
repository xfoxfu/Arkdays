FROM mcr.microsoft.com/dotnet/core/sdk:5.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY ./Noha.Arkdays/*.csproj ./Noha.Arkdays/
COPY ./Noha.Arkdays.Types/*.csproj ./Noha.Arkdays.Types/
COPY ./Noha.Arkdays.CLITools/*.csproj ./Noha.Arkdays.CLITools/
RUN dotnet restore

# copy everything else and build app
COPY ./Noha.Arkdays/ ./Noha.Arkdays/
COPY ./Noha.Arkdays.Types/ ./Noha.Arkdays.Types/
COPY ./Noha.Arkdays.CLITools/ ./Noha.Arkdays.CLITools/
RUN dotnet publish -c Release -o dist
RUN dotnet run -p Noha.Arkdays.CLITools -- hot-update
RUN dotnet run -p Noha.Arkdays.CLITools -- download-table

COPY ./Data ./Data/

FROM mcr.microsoft.com/dotnet/core/aspnet:5.0 AS runtime
WORKDIR /app
COPY --from=build /app/dist ./
COPY --from=build /app/Data /Data
ENTRYPOINT ["dotnet", "Noha.Arkdays.dll"]
EXPOSE 80
