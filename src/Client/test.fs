module test

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

let reactElement (name: string) (props: 'a) : ReactElement = import "createElement" "react"

type InputProps = interface end

type input =
    static member inline id (value: string) = unbox<InputProps>("id", value)

type Dash =
    static member inline input (props: InputProps list) = reactElement (import "Input" "dash-core-components") (createObj !!props) 
