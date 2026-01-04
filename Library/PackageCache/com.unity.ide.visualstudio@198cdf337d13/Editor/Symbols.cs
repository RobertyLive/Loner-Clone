nasmInstrModifier	"\<F\(ADD\|MUL\|\(DIV\|SUB\)R\=\)\s\+TO\>"lc=5,ms=e-1
"   the 'to' keyword is not allowed for fpu-pop instructions (yet)
"syn match   nasmInstrModifier	"\<F\(ADD\|MUL\|\(DIV\|SUB\)R\=\)P\s\+TO\>"lc=6,ms=e-1
"  NAsm directives
syn keyword nasmRepeat		TIMES
syn keyword nasmDirective	ALIGN[B] INCBIN EQU NOSPLIT SPLIT
syn keyword nasmDirective	ABSOLUTE BITS SECTION SEGMENT DEFAULT
syn keyword nasmDirective	ENDSECTION ENDSEGMENT
syn keyword nasmDirective	__SECT__
"  Macro created standard directives: (requires %include)
syn case match
syn keyword nasmStdDirective	ENDPROC EPILOGUE LOCALS PROC PROLOGUE USES
syn keyword nasmStdDirective	ENDIF ELSE ELIF ELSIF IF
"syn keyword nasmStdDirective	BREAK CASE DEFAULT ENDSWITCH SWITCH
"syn keyword nasmStdDirective	CASE OF ENDCASE
syn keyword nasmStdDire