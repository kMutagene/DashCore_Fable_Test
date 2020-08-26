module PlotlyGraphComponent

open Fable.Core
open Fable.Core.JsInterop
open Fable.React
open Fable.React.Props

type ResponsiveOptions =
    | True
    | False
    | Auto

type PlotlyFigure = {
    Data    : obj
    Layout  : obj
    Frames  : obj
}

let dcc_Graph : obj = import "Graph" "dash-core-components"

type GraphProps =
    | Id                    of string
    | Clear_on_unhover      of bool
    | Figure                of PlotlyFigure

    static member Responsive (responsiveOptions: ResponsiveOptions) =
        let value =
            match responsiveOptions with
            | ResponsiveOptions.True    -> unbox true
            | ResponsiveOptions.False   -> unbox false
            | ResponsiveOptions.Auto    -> unbox "auto"

        unbox("responsive", value)

let inline dccGraph (p:GraphProps list) c =
    ReactBindings.React.createElement(dcc_Graph,p,c)


