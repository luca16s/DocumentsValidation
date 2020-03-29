#!/usr/bin/env bash
cd ../CpfCommonTools.Tests/
dotnet restore
dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=opencover /p:CoverletOutput="../CpfCommonTools.xml"