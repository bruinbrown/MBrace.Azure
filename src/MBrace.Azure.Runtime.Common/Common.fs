﻿namespace MBrace.Azure.Runtime.Common

open MBrace.Continuation

type ILogger =
    inherit ICloudLogger
    abstract Attach : ILogger -> unit

[<AutoOpen>]
module LoggerExtensions =
    type ILogger with
        member __.Logf fmt  = Printf.ksprintf __.Log fmt