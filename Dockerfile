FROM mcr.microsoft.com/dotnet/aspnet:5.0-alpine AS runtime
WORKDIR /app

EXPOSE 443
EXPOSE 80

COPY ["Epita.Apprentis.2023.KataNumber.Api/bin/Debug/net5.0", "/app"]

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT false
RUN apk add --no-cache icu-libs

ENTRYPOINT ["dotnet", "Epita.Apprentis.2023.KataNumber.Api.dll"]