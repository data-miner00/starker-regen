namespace App.Core

open Fable.React

/// <summary>
/// An interface that all React components must implement.
/// </summary>
type IComponent =

    /// <summary>
    /// The method that returns a <see cref="ReactElement"/>.
    /// </summary>
    abstract member make : unit -> ReactElement
