namespace App.Pages

open Feliz
open Fable.Core
open App.Components

module Landing =
    [<ImportMember("../lib/gradient.js")>]
    let initGradient(): unit = jsNative

    [<ReactComponent>]
    let Make () =
        React.useEffect(fun () -> initGradient())

        Html.div [
            prop.children [
                Header().make()

                Html.div [
                    prop.className [
                        "h-[calc(100vh-64px)] w-full relative"
                    ]
                    prop.children [
                        Html.div [
                            prop.className [
                                "absolute w-full h-full -z-10 xl:p-4"
                            ]
                            prop.children [
                                Html.div [
                                    prop.className "relative h-full"
                                    prop.children [
                                        Html.div [
                                            prop.className [
                                                "absolute rounded-xl bg-slate-700 h-full w-full"
                                            ]
                                        ]
                                        Html.canvas [
                                            prop.className [
                                                "absolute rounded-xl block h-full w-full"
                                            ]
                                            prop.id "gradient-canvas"
                                        ]
                                    ]
                                ]
                            ]
                        ]
                        Html.div [
                            prop.className [
                                "flex"
                                "justify-center items-center h-full"
                            ]
                            prop.style [
                                style.backgroundImage "radial-gradient(circle,var(--primary),var(--primary) 1.5px,transparent 1.5px,transparent)"
                                style.backgroundSize "2.5rem 2.5rem"
                                style.backgroundRepeat.repeat
                            ]
                            prop.children [
                                Html.div [
                                    prop.className [
                                        "flex max-w-6xl mx-auto px-2 md:px-8 py-12 flex-1 gap-4 text-white"
                                    ]
                                    prop.children [
                                        Html.div [
                                            prop.className "flex flex-col gap-6 basis-1/2 shrink-0"
                                            prop.children [
                                                Html.h1 [
                                                    prop.style [ style.lineHeight (length.em 1.375) ]
                                                    prop.className [
                                                        "text-4xl md:text-6xl font-bold"
                                                    ]
                                                    prop.text "React Application Reimagined"
                                                ]

                                                Html.p [
                                                    prop.className [
                                                        "text-2xl font-semibold text-gray-200"
                                                    ]
                                                    prop.children [
                                                        Html.text "Embracing the joy with "
                                                        Html.span [
                                                            prop.className [
                                                                "underline font-semibold"
                                                            ]
                                                            prop.text "F#"
                                                        ]
                                                    ]
                                                ]

                                                Html.ul [
                                                    prop.className [
                                                        "pl-5 opacity-80"
                                                    ]
                                                    prop.children [
                                                        Html.li [
                                                            prop.className [
                                                                "list-tick text-2xl pl-2"
                                                            ]
                                                            prop.text "Succinct Syntax with Type-safety enforced."
                                                        ]

                                                        Html.li [
                                                            prop.className [
                                                                "list-tick text-2xl pl-2"
                                                            ]
                                                            prop.text "Styling with TailwindCSS."
                                                        ]

                                                        Html.li [
                                                            prop.className [
                                                                "list-tick text-2xl pl-2"
                                                            ]
                                                            prop.text "Blazing fast build process with esbuild."
                                                        ]
                                                    ]
                                                ]

                                                Html.div [
                                                    prop.className [
                                                        "mt-4 flex gap-2"
                                                    ]
                                                    prop.children [
                                                        Html.a [
                                                            prop.className [
                                                                "block text-2xl font-bold rounded-lg px-6 py-3 bg-black/10 hover:bg-black/20 focus:bg-black/25 backdrop-filter backdrop-blur-sm"
                                                            ]
                                                            prop.text "Get Started"
                                                        ]
                                                        Html.a [
                                                            prop.className [
                                                                "block text-2xl font-semibold px-6 py-3 hover:bg-white/10 rounded-lg"
                                                            ]
                                                            prop.text "Read More"
                                                        ]
                                                    ]
                                                ]

                                                Html.p [
                                                    prop.className "text-gray-300 text-xl"
                                                    prop.text "ps. It's really fun to work with!"
                                                ]
                                            ]
                                        ]

                                        Html.div [
                                            prop.className "basis-1/2"
                                            prop.children [
                                                Showcase.Make()
                                            ]
                                        ]
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
