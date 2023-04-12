namespace App.Components

open App.Core
open App.Utils
open Feliz
open Feliz.Router


module GitHub =
    [<ReactComponent(import="Github", from="./icons/Github.jsx")>]
    let Make () = React.imported()

module Link = 
    [<ReactComponent(import="Link", from="./icons/Link.jsx")>]
    let Make() = React.imported()

type Header() =
    interface IComponent with
        [<ReactComponent>]
        member this.make() = Html.div [
            prop.className "border-b border-solid border-gray-200 w-full h-16"
            prop.children [
                Html.header [
                    prop.className "flex justify-between max-w-screen-xl mx-auto items-center h-full"
                    prop.children [
                        Html.a [
                            prop.className "uppercase text-2xl font-semibold text-slate-700 block"
                            prop.onClick (fun x -> x.preventDefault(); Router.navigatePath "/")
                            prop.href "/"
                            prop.text "Starker"
                        ]

                        Html.div [
                            prop.className "flex"
                            prop.children [
                                Html.div [
                                    prop.className [
                                        "flex gap-5 pr-4 mr-4 text-gray-600 items-center"
                                        "border-r border-solid border-gray-200"
                                    ]
                                    prop.children [
                                        Html.a [
                                            prop.className "block pointer hover:text-gray-500"
                                            prop.onClick (fun x -> x.preventDefault(); Router.navigatePath "/#about")
                                            prop.href "/#about"
                                            prop.text "About"
                                        ]

                                        Html.a [
                                            prop.className "block pointer hover:text-gray-500 flex items-center"
                                            prop.href "https://fable.io/"
                                            prop.target "_blank"
                                            prop.rel "noopener noreferrer"
                                            prop.children [
                                                Html.span [
                                                    prop.className "block mr-1"
                                                    prop.text "Fable"
                                                ]
                                                Link.Make()
                                            ]
                                        ]

                                        Html.a [
                                            prop.className "block pointer hover:text-gray-500 flex items-center"
                                            prop.href "https://zaid-ajaj.github.io/Feliz/#/"
                                            prop.target "_blank"
                                            prop.rel "noopener noreferrer"
                                            prop.children [
                                                Html.span [
                                                    prop.className "block mr-1"
                                                    prop.text "Feliz"
                                                ]
                                                Link.Make()
                                            ]
                                        ]
                                    ]
                                ]

                                Html.a [
                                    prop.className "text-gray-600 block"
                                    prop.href "https://github.com/data-miner00/starker-regen"
                                    prop.target "_blank"
                                    prop.rel "noopener noreferrer"
                                    prop.children [
                                        GitHub.Make()
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]

    member this.make() = (this :> IComponent).make()
