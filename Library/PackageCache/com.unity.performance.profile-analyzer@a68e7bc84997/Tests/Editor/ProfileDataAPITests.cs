PSXADD CMPNSXADD
syn keyword nasmInstructionCMPCCXADD CMPPXADD CMPNPXADD CMPLXADD CMPNLXADD CMPLEXADD
syn keyword nasmInstructionCMPCCXADD CMPNLEXADD
" FRET
syn keyword nasmInstructionFRET ERETS ERETU LKGS
" WRMSRNS_MSRLIST
syn keyword nasmInstructionWRMSRNS_MSRLIST WRMSRNS RDMSRLIST WRMSRLIST
" HRESET
syn keyword nasmInstructionHRESET HRESET 
" PTWRITE
syn keyword nasmInstructionPTWRITE PTWRITE 
" HINTNOP
syn keyword nasmInstructionHINTNOP HINT_NOP0 HINT_NOP1 HINT_NOP2 HINT_NOP3 HINT_NOP4
syn keyword nasmInstructionHINTNOP HINT_NOP5 HINT_NOP6 HINT_NOP7 HINT_NOP8 HINT_NOP9
syn keyword nasmInstructionHINTNOP HINT_NOP10 HINT_NOP11 HINT_NOP12 HINT_NOP13 HINT_NOP14
syn keyword nasmInstructionHINTNOP HINT_NOP15 HINT_NOP16 HINT_NOP17 HINT_NOP18 HINT_NOP19
syn keyword nasmInstructionHINTNOP HINT_NOP20 HINT_NOP21 HINT_NOP22 HINT_NOP23 HINT_NOP24
syn keyword nasmInstructionHINTNOP HINT_NOP25 HINT_NOP26 HINT_NOP27 HINT_NOP28 HINT_NOP29
syn keyword nasmInstructionHINTNOP HINT_NOP30 HINT_NOP31 HINT_NOP32 HINT_NOP33 HINT_NOP34
syn keyword nasmInstructionHINTNOP HINT_NOP35 HINT_NOP36 HINT_NOP37 HINT_NOP38 HINT_NOP39
syn keyword nasmInstructionHINTNOP HINT_NOP40 HINT_NOP41 HINT_NOP42 HINT_NOP43 HINT_NOP44
syn keyword nasmInstructionHINTNOP HINT_NOP45 HINT_NOP46 HINT_NOP47 HINT_NOP48 HINT_NOP49
syn keyword nasmInstructionHINTNOP HINT_NOP50 HINT_NOP51 HINT_NOP52 HINT_NOP53 HINT_NOP54
syn keyword nasmInstructionHINTNOP HINT_NOP55 HINT_NOP56 HINT_NOP57 HINT_NOP58 HINT_NOP59
syn keyword nasmInstructionHINTNOP HINT_NOP60 HINT_NOP61 HINT_NOP62 HINT_NOP63
"  Cyrix instructions (requires Cyrix processor)
syn keyword nasmCrxInstruction	PADDSIW PAVEB PDISTIB PMAGW PMULHRWC PMULHRIW
syn keyword nasmCrxInstruction	PMVGEZB PMVLZB PMVNZB PMVZB PSUBSIW
syn keyword nasmCrxInstruction	RDSHR RSDC RSLDT SMINT SMINTOLD SVDC SVLDT SVTS
syn keyword nasmCrxInstruction	WRSHR BB0_RESET BB1_RESET
syn keyword nasmCrxInstruction	CPU_WRITE CPU_READ DMINT RDM PMACHRIW

" Debugging Instructions: (privileged)
syn keyword nasmDbgInstruction	INT1 INT3 RDMSR RDTSC RDPMC WRMSR INT01 INT03


" Synchronize Syntax:
syn sync clear
syn sync minlines=50		"for multiple region nesting
syn sync match  nasmSync	grouphere nasmMacroDef "^\s*%i\=macro\>"me=s-1
syn sync match	nasmSync	grouphere NONE	       "^\s*%endmacro\>"


" Define the default highlighting.
" Only when an item doesn't have highlighting yet

" Sub Links:
hi def link nasmInMacDirective	nasmDirective
hi def link nasmInMacLabel		na