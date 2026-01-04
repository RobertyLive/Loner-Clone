mber	"\<\~\(\d[0-9_]*\|\d[0-9_]*d\|0d[0-9_]\+\)\>"lc=1
syn match   nasmHexNumber	"\<\(\d[0-9a-f_]*h\|0[xh][0-9a-f_]\+\|\$\d[0-9a-f_]*\)\>"
syn match   nasmHexNumber	"\<\~\(\d[0-9a-f_]*h\|0[xh][0-9a-f_]\+\|\$\d[0-9a-f_]*\)\>"lc=1
syn match   nasmBinFloat	"\<\(0[by][01_]*\.[01_]*\(p[+-]\=[0-9_]*\)\=\)\|\(0[by][01_]*p[+-]\=[0-9_]*\)\>"
syn match   nasmOctFloat	"\<\(0[qo][0-7_]*\.[0-7_]*\(p[+-]\=[0-9_]*\)\=\)\|\(0[qo][0-7_]*p[+-]\=[0-9_]*\)\>"
syn match   nasmDecFloat	"\<\(\d[0-9_]*\.[0-9_]*\(e[+-]\=[0-9_]*\)\=\)\|\(\d[0-9_]*e[+-]\=[0-9_]*\)\>"
syn match   nasmHexFloat	"\<\(0[xh][0-9a-f_]\+\.[0-9a-f_]*\(p[+-]\=[0-9_]*\)\=\)\|\(0[xh][0-9a-f_]\+p[+-]\=[0-9_]*\)\>"
syn keyword nasmSpecFloat	Inf NaN SNaN QNaN __?Infinity?__ __?NaN?__ __?SNaN?__ __?QNaN?__
syn match   nasmBcdConst	"\<\(\d[0-9_]*p\|0p[0-9_]\+\)\>"
syn match   nasmNumberError	"\<\~\s*\d\+\.\d*\(e[+-]\=\d\+\)\=\>"


" Netwide Assembler Storage Directives:
"  Storage types
syn keyword nasmTypeError	DF EXTRN FWORD RESF TBYTE
syn keyword nasmType		FAR NEAR SHORT
syn keyword nasmType		BYTE WORD DWORD QWORD DQWORD HWORD DHWORD TWORD
syn keyword nasmType		CDECL FASTCALL NONE PASCAL STDCALL
syn keyword nasmStorage		DB DW DD DQ DT DO DY DZ
syn keyword nasmStorage		RESB RESW RESD RESQ REST RESO RESY RESZ
syn keyword nasmStorage		EXTERN GLOBAL COMMON
"  Structured storage types
syn match   nasmTypeError	"\<\(AT\|I\=\(END\)\=\(STRUCT\=\|UNION\)\|I\=END\)\>"
syn match   nasmStructureLabel	contained "\<\(AT\|I\=\(END\)\=\(STRUCT\=\|UNION\)\|I\=END\)\>"
"   structures cannot be nested (yet) -> use: 'keepend' and 're='
syn cluster nasmGrpCntnStruc	contains=ALLBUT,@nasmGrpInComments,nasmMacroDef,@nasmGrpInMacros,@nasmGrpInPreCondits,nasmStructureDef,@nasmGrpInStrucs
syn region  nasmStructureDef	transparent matchgroup=nasmStructure keepend start="^\s*STRUCT\>"hs=e-5 end="^\s*ENDSTRUCT\>"re=e-9 contains=@nasmGrpCntnStruc
syn region  nasmStructureDef	transparent matchgroup=nasmStructure keepend start="^\s*STRUC\>"hs=e-4  end="^\s*ENDSTRUC\>"re=e-8  contains=@nasmGrpCntnStruc
syn region  nasmStructureDef	transparent matchgroup=nasmStructure keepend start="\<ISTRUCT\=\>" end="\<IEND\(STRUCT\=\)\=\>" contains=@nasmGrpCntnStruc,nasmInStructure
"   union types are not part