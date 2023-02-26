namespace App.Core

open Fable.React

/// <summary>
/// An interface that all stateless React components can implement.
/// </summary>
type IComponent =

    /// <summary>
    /// The method that returns a <see cref="ReactElement"/>.
    /// </summary>
    abstract member make : unit -> ReactElement
