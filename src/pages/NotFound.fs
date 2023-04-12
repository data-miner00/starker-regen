namespace App.Pages

open Feliz
open Feliz.Router
open Fable.Core
open App.Components

module NotFound =
    [<ReactComponent>]
    let Make() =
        Html.div [
            prop.className "h-screen flex flex-col items-center"
            prop.children [
                Header().make()

                Html.div [
                    prop.className "h-full w-full flex flex-col justify-center items-center"
                    prop.children [
                        Html.h1 [
                            prop.className "font-bold text-5xl tracking-wide uppercase block mb-2 text-slate-800"
                            prop.text "404 Not Found"
                        ]

                        Html.p [
                            prop.className "font-semibold text-xl block text-gray-600 mb-4"
                            prop.text "The page that you are trying to access could not be found."
                        ]

                        Html.a [
                            prop.className "py-1 px-4 block border border-solid border-gray-200 rounded text-xl hover:bg-gray-50"
                            prop.onClick (fun x -> x.preventDefault(); Router.navigatePath "/")
                            prop.href "/"
                            prop.text "Return"
                        ]
                    ]
                ]
            ]
        ]

