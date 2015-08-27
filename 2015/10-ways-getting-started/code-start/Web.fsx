﻿#r "packages/Suave/lib/net40/Suave.dll"
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"
open FSharp.Data
open Suave
open Suave.Web
open Suave.Http
open Suave.Http.Applicatives
open Suave.Http.Successful

type Weather = JsonProvider<"http://api.openweathermap.org/data/2.5/forecast/daily?units=metric&q=Prague">

let getTemp place = 
  let w = Weather.Load("http://api.openweathermap.org/data/2.5/forecast/daily?units=metric&q=" + place)
  printf "%s, %s" w.City.Name w.City.Country
  printf "<ul>"
  for t in w.List do
    printf "<li>%f</li>" t.Temp.Day
  printf "</ul>"
  
// DEMO: Start web server with default config
// DEMO: Handle "/" and "/city/%s" routes