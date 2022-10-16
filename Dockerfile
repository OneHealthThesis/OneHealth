FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /app

# copy csproj and restore as distinct layers
COPY *.sln .
COPY src/PetHealth.Core/*.csproj ./src/PetHealth.Core/
COPY PetHealthInfraetructure/*.csproj ./PetHealthInfraetructure/
COPY PetHealth/*.csproj ./PetHealth/

RUN dotnet restore

# copy and publish app and libraries
COPY src/PetHealth.Core/. ./src/PetHealth.Core/
COPY PetHealthInfraetructure/. ./PetHealthInfraetructure/
COPY PetHealth/. ./PetHealth/

WORKDIR /app/PetHealth
RUN dotnet publish -c release -o pethealth --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS runtime
WORKDIR /app
COPY --from=build /app/PetHealth/pethealth ./
USER 1000

ENTRYPOINT ["dotnet", "PetHealth.dll"]
