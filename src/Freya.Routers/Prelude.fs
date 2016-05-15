﻿namespace Freya.Routers

open Aether

(* Prelude *)

(* Option *)

[<RequireQualifiedAccess>]
module Option =

    let unsafe_ : Isomorphism<'a option,'a> =
        Option.get, Some