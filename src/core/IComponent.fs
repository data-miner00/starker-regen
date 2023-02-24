namespace App.Core

open Fable.React

type IComponent =
    abstract member make : unit -> ReactElement
