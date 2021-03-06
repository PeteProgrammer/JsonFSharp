﻿module ErrorHandlingSpecs
open FSpec.Dsl
open FSpec.Matchers
open JsonFSharp
open Helpers

let specs =
    describe "Error handling" [
        it "handles invalid input" <| fun _ ->
            let actual = "invalid" |> parseString
            match actual with
            | Success _ -> failwith "Expected fail"
            | Failure _ -> ()

        it "handles invalid input in array" <| fun _ ->
            let actual = "[invalid]" |> parseString
            match actual with
            | Success _ -> failwith "Expected fail"
            | Failure _ -> ()
    ]
