FROM mcr.microsoft.com/dotnet/sdk:3.1-alpine AS build

WORKDIR /usr/src/app

COPY ./WMI-Backend.csproj ./

RUN dotnet restore ./WMI-Backend.csproj

COPY . .

RUN dotnet publish -o out

FROM mcr.microsoft.com/dotnet/aspnet:3.1-alpine AS target

WORKDIR /usr/src/app

COPY --from=build /usr/src/app/out .

ENTRYPOINT [ "dotnet", "WMI-Backend.dll" ]