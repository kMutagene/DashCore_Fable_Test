module InputComponent

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

type InputProps =
    |Id of string

let dcc_Input : obj = import "Input" "dash-core-components"

let inline dccInput (p:InputProps list) c =
    ReactBindings.React.createElement(dcc_Input,p,c)