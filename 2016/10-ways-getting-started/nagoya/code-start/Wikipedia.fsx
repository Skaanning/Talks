﻿#load "packages/FsLab/FsLab.fsx"
open System
open FSharp.Data
open XPlot.GoogleCharts

let us = Globalization.CultureInfo.GetCultureInfo("en-US")

// DEMO: Print information from Wikipedia:
// - https://en.wikipedia.org/wiki/Prefectures_of_Japan
// - https://en.wikipedia.org/wiki/Statutory_city_(Czech_Republic)
