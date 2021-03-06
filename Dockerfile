FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env
WORKDIR /app

# Copy stuff
COPY ./Plaything ./Plaything
# Build ready to run
RUN dotnet publish -c Release -r linux-x64 --no-self-contained -o out ./Plaything

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1
ENV ASPNETCORE_URLS=http://*:5000
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["./Plaything"]