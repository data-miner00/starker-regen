﻿namespace App.Components

open App.Core
open App.Utils
open Feliz
open Feliz.Router
open App.Components.Icons

type Header() =
    interface IComponent with
        [<ReactComponent>]
        member this.make() = Html.div [
            prop.className [ 
                "border-b border-solid border-gray-200"
                "w-full h-16"
            ]
            prop.children [
                Html.header [
                    prop.className [
                        "flex justify-between max-w-screen-xl mx-auto"
                        "items-center h-full"
                    ]
                    prop.children [
                        Html.a [
                            prop.className [
                                "uppercase text-2xl font-semibold text-slate-700 block"
                            ]
                            prop.onClick (fun x -> x.preventDefault(); Router.navigatePath "/")
                            prop.href "/"
                            prop.text "Starker"
                        ]

                        Html.div [
                            prop.className "flex"
                            prop.children [
                                Html.div [
                                    prop.className [
                                        "flex gap-5 mr-6 text-gray-600 font-bold items-center"
                                    ]
                                    prop.children [
                                        Html.a [
                                            prop.className "block pointer hover:text-gray-500"
                                            prop.onClick (fun x -> x.preventDefault(); Router.navigatePath "/#about")
                                            prop.href "/#about"
                                            prop.text "About"
                                        ]

                                        Html.a [
                                            prop.className "block pointer hover:text-gray-500"
                                            prop.href "https://fable.io/"
                                            prop.target "_blank"
                                            prop.text "Fable"
                                        ]

                                        Html.a [
                                            prop.className "block pointer hover:text-gray-500"
                                            prop.href "https://zaid-ajaj.github.io/Feliz/#/"
                                            prop.target "_blank"
                                            prop.text "Feliz"
                                        ]
                                    ]
                                ]

                                Github.Make()
                            ]
                        ]
                    ]
                ]
            ]
        ]

    member this.make() = (this :> IComponent).make()
