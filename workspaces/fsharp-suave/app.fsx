#r "System.Xml.Linq.dll"
#r "packages/Suave/lib/net40/Suave.dll"
#r "packages/FSharp.Data/lib/net40/FSharp.Data.dll"
open System
open System.IO
open Suave
open Suave.Web
open Suave.Http
open Suave.Types
open FSharp.Data

//clean the code and uncomment next line after each turn
let app = Successful.OK "--- Next player! ---"

//---- start code here -------
