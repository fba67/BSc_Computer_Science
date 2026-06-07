# Scanner (lexical analyzer):
This part, which is responsible for recognizing tokens, uses a two-dimensional array to separate the tokens. In the first column of this array, the token itself is stored, and in the second column, its type is stored, which can be one of the following:

Identifier, id

Separator

Operand

Reserved

Int

Float

Char

Error

# Parser (Syntax Analyzer):
This component, based on the grammar designed for the program, takes the user-written program that is lexically correct and parses it using the LALR(1) method, which is a type of bottom-up parsing technique. If the program is grammatically correct, it outputs an “Accept” message; otherwise, it generates an “Error” message.
Additionally, the identification of identifiers that are assigned at the beginning of the program is handled in this section. The software examines the token table up to the point where it reaches the "begin" token, and all identifiers defined before this token with the type "Identifier" are converted to "id". From that point on, in the parser section, whenever an identifier needs to be recognized, only those whose type (i.e., the second field of each token) is "id" will be accepted.

In this program, the parser receives its inputs directly from the token table, where the type of each token is correctly stored in its second field.
