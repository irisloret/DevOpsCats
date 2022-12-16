FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /source

# Copy everything
COPY app ./app/
# Restore as distinct layers
RUN dotnet restore app
# Build and publish a release
COPY app/. ./app/
WORKDIR /source/app
RUN dotnet publish -c Release -o /app

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:3.1
WORKDIR /app
EXPOSE 80
COPY --from=build /app /.
ENTRYPOINT ["dotnet", "catsProject.dll"]

