" Vim syntax file
" Language:	Chatito
" Maintainer:	ObserverOfTime <chronobserver@disroot.org>
" Filenames:	*.chatito
" Last Change:	2022 Sep 19

if exists('b:current_syntax')
    finish
endif

" Comment
syn keyword chatitoTodo contained TODO FIXME XXX
syn match chatitoComment /^#.*/ contains=chatitoTodo,@Spell
syn match chatitoComment +^//.*+ contains=chatitoTodo,@Spell

" Import
syn match chatitoImport /^import \+.*$/ transparent contains=chatitoImportKeyword,chatitoImportFile
syn keyword chatitoImportKeyword import contained nextgroup=chatitoImportFile
syn match chatitoImportFile /.*$/ contained skipwhite

" Intent
syn match chatitoIntent /^%\[[^\]?]\+\]\((.\+)\)\=$/ contains=chatitoArgs

" Slot
syn match chatitoSlot /^@\[[^\]?#]\+\(#[^\]?#]\+\)\=\]\((.\+)\)\=$/ contains=chatitoArgs,chatitoVariation
syn match chatitoSlot /@\[[^\]?#]\+\(#[^\]?#]\+\)\=?\=\]/ contained contains=chatitoOpt,chatitoVariation

" Alias
syn match chatitoAlias /^\~\[[^\]?]\+\]\=$/
syn match chatitoAl