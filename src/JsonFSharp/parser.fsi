// Signature file for parser generated by fsyacc
module JsonFSharp.Parsers
type token = 
  | EOF
  | LBRAC
  | RBRAC
  | NULL
  | BOOL of (bool)
  | EXCEPTION of (string)
  | DOUBLE of (double)
  | STRING of (string)
type tokenId = 
    | TOKEN_EOF
    | TOKEN_LBRAC
    | TOKEN_RBRAC
    | TOKEN_NULL
    | TOKEN_BOOL
    | TOKEN_EXCEPTION
    | TOKEN_DOUBLE
    | TOKEN_STRING
    | TOKEN_end_of_input
    | TOKEN_error
type nonTerminalId = 
    | NONTERM__startstart
    | NONTERM_start
    | NONTERM_value
/// This function maps integers indexes to symbolic token ids
val tagOfToken: token -> int

/// This function maps integers indexes to symbolic token ids
val tokenTagToTokenId: int -> tokenId

/// This function maps production indexes returned in syntax errors to strings representing the non terminal that would be produced by that production
val prodIdxToNonTerminal: int -> nonTerminalId

/// This function gets the name of a token as a string
val token_to_string: token -> string
val start : (Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> token) -> Microsoft.FSharp.Text.Lexing.LexBuffer<'cty> -> ( JsonFSharp.ParseResult ) 
