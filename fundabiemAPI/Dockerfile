FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY fundabiemAPI/ fundabiemAPI/
#COPY Eagle/Eagle.csproj Eagle/
COPY BrokerServices/BrokerServices.csproj BrokerServices/
COPY DataAccess/EntityModelFundabien/EntityModelFundabien.csproj DataAccess/EntityModelFundabien/

WORKDIR /src/fundabiemAPI
RUN dotnet build fundabiemAPI.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish fundabiemAPI.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "fundabiemAPI.dll"]
