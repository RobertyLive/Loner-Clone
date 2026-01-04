\d\|[#\.@~]\)\k*}\)"
    hi link nasmInMacCatLabel	nasmInMacLblWarn
  else
    hi link nasmInMacCatLabel	nasmInMacLabel
  endif
else
  syn match  nasmInMacLabel	contained "%\(%\(\w\|[#?@~]\)\k*\>\|{%\(\w\|[#?@~]\)\k*}\)"
  syn match  nasmInMacLabel	contained "%\($\+\(\h\|[?@]\)\k*\>\|{$\+\(\h\|[?@]\)\k*}\)"
  hi link nasmInMacCatLabel	nasmLabelError
endif
syn match   nasmInMacCatLabel	contained "\d\K\k*"lc=1
syn match   nasmInMacLabel	contained "\d}\k\+"lc=2
if !exists("nasm_no_warn")
  syn match  nasmInMacLblWarn	contained "%\(\($\+\|%\)[_~][._~]*\>\|{\($\+\|%\)[_~][._~]*}\)"
endif
syn match   nasmInMacPreProc	contained "^\s*%pop\>"hs=e-3
syn match   nasmInMacPreProc	contained "^\s*%\(push\|repl\)\>"hs=e-4 skipwhite nextgroup=@nasmGrpNxtCtx
"   structures cannot be nested (yet) -> use: 'keepend' and 're='
syn region  nasmInMacStrucDef	contained transparent matchgroup=nasmStructure keepend start="^\s*STRUCT\>"hs=e-5 end="^\s*ENDSTRUCT\>"re=e-9 contains=@nasmGrpCntnMacro
syn region  nasmInMacStrucDef	contained transparent matchgroup=nasmStructure keepend start="^\s*STRUC\>"hs=e-4  end="^\s*ENDSTRUC\>"re=e-8  contains=@nasmGrpCntnMacro
syn region  nasmInMacStrucDef	contained transparent matchgroup=nasmStructure keepend start="\<ISTRUCT\=\>" end="\<IEND\(STRUCT\=\)\=\>" contains=@nasmGrpCntnMacro,nasmInStructure
"   union types are not part of nasm (yet)
"syn region  nasmInMacStrucDef	contained transparent matchgroup=nasmStructure keepend start="^\s*UNION\>"hs=e-4 end="^\s*ENDUNION\>"re=e-8 contains=@nasmGrpCntnMacro
"syn region  nasmInMacStrucDef	contained transparent matchgroup=nasmStructure keepend start="\<IUNION\>" end="\<IEND\(UNION\)\=\>" contains=@nasmGrpCntnMacro,nasmInStructure
syn region  nasmInMacPreConDef	contained transparent matchgroup=nasmInMacPreCondit start="^\s*%ifnidni\>"hs=e-7 start="^\s*%if\(idni\|n\(ctx\|def\|idn\|num\|str\)\)\>"hs=e-6 start="^\s*%if\(ctx\|def\|idn\|nid\|num\|str\)\>"hs=e-5 start="^\s*%ifid\>"hs=e-4 start="^\s*%if\>"hs=e-2 end="%endif\>" contains=@nasmGrpCntnMacro,nasmInMacPreCondit,nasmInPreCondit
" Todo: allow STRUC/ISTRUC to be used inside preprocessor conditional block
syn match   nasmInMacPreCondit	contained transparent "ctx\s"lc=3 skipwhite nextgroup=@nasmGrpNxtCtx
syn match   nasmInMacPreCondit	contained "^\s*%elifctx\>"hs=e-7 skipwhite nextgroup=@nasmGrpNxtCtx
syn match   nasmInMacPreCondit	contained "^\s*%elifnctx\>"hs=e-8 skipwhite nextgroup=@na