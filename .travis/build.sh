#!/usr/bin/env bash
cd ../CpfCommonTools/
dotnet tool install --global coverlet.console
dotnet restore
dotnet build