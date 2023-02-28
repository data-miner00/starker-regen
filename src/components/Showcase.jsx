import React, { useEffect } from "react";
import Prism from "prismjs";
import "prismjs/components/prism-fsharp";
import "../assets/css/prism-one-light-modified.css";

export function Showcase() {
  useEffect(() => {
    if (typeof window != "undefined") {
      Prism.highlightAll();
    }
  }, []);

  const code = `open Feliz

[<ReactComponent>]
let Counter() =
    let (count, setCount) = React.useState(0)
    Html.div [
        Html.button [
            prop.style [ style.marginRight 5 ]
            prop.onClick (fun _ -> setCount(count + 1))
            prop.text "Increment"
        ]
        Html.button [
            prop.style [ style.marginLeft 5 ]
            prop.onClick (fun _ -> setCount(count - 1))
            prop.text "Decrement"
        ]
        Html.h1 count
    ]
  `;

  return (
    <div className="rounded-xl backdrop-filter backdrop-blur-sm pt-4 bg-white/60 dark:bg-black/40 border border-solid border-white/40">
      <div className="px-4">
        <button className="bg-white/50 text-sm rounded-lg px-2 py-1 text-slate-700">
          Counter.fs
        </button>
      </div>
      <pre className="text-lg">
        <code className="language-fsharp selection:bg-violet-200/80">
          {code}
        </code>
      </pre>
    </div>
  );
}
