FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build-env
WORKDIR /app

# Copy stuff
COPY ./Plaything ./Plaything
# Build ready to run
RUN dotnet publish -c Release --no-self-contained -o out ./Plaything

# Build runtime image
FROM mcr.microsoft.com/dotnet/aspnet:6.0
RUN apt update && apt install curl -y
RUN curl --version
ENV ASPNETCORE_URLS=http://*:5000
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["./Plaything"]
