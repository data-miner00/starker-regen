namespace App

open Feliz
open Browser.Dom

module Index =
    let root = ReactDOM.createRoot(document.getElementById "app")
    root.render(Components.HelloWorld())
