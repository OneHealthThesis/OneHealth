FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.csproj .
RUN dotnet restore

# copy and publish app and libraries
COPY . .
RUN dotnet publish ./PetHealth/PetHealth.csproj -c release -o /app --no-restore

# final stage/image
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app
COPY --from=build /app .
USER 1000
EXPOSE 5000
ENTRYPOINT ["dotnet", "PetHealth.dll"]
