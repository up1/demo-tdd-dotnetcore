#!/usr/bin/env bash

set -e

export "MiniCover=dotnet minicover"

dotnet restore
dotnet build
cd HelloTests
$MiniCover instrument --workdir ../ --sources "Hello/**/*.cs" --assemblies "HelloTests/bin/**/*.dll"
# $MiniCover reset
dotnet test --no-build
$MiniCover uninstrument --workdir ../
$MiniCover htmlreport --workdir ../ --threshold 90
$MiniCover report --workdir ../ --threshold 90
