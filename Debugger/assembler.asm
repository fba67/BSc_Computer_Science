;;;********************************** ASSEMBLER **********************************;;;
section .data
	opcodetable db '-add000000','-and001000','call111010','-cmp001110','-dec111111','-div111101','-inc11111?','-jmp111010','-mov100010',-'mul111100','-shl110100','-shr110101','-sub001010','-xor001100','-jne000011','-not111101'
	regtable db '-al000','-ax000','eax000','-cl001','-cx001','ecx001','-dl010','-dx010','edx010','-bl011','-bx011','ebx011','-ah100','-sp100','esp100','-ch101','-bp101','ebp101','-dh110','-si110','esi110','-bh111','-di111','edi111','x'
	memop1 db 0 ;shows that whether the op1 is a memory(1) or not(0)
	memop2 db 0 ;shows that whether the op2 is a memory(1) or not(0)
	opcodetok times 4 db -1
	op1 times 20 db -1
	op2 times 20 db -1
	mem times 20 db -1
	memtok1 times 8 db -1
	memtok2 times 8 db -1
	memtok3 times 8 db -1
	regind dd 0 ;to keep the register field index at regtable
	error1 db 0
	error1_prompt db 'error: invalid opcode',10
	error2 db 0
	error2_prompt db 'error: invalid combination of opcode and operand',10
	result times 3 db -1
	srchval times 5 db -1
	immbytecnt db 0
	immval times 8 db -1
	immcalcres times 32 db '0'
	outlen dd 0
	infadres db '/home/fateme/Desktop/final-project/code.txt',0
	outfadres db '/home/fateme/Desktop/final-project/out.txt',0
	bitoutf db '/home/fateme/Desktop/final-project/bitout.txt',0
	bitout times 125 db 0xFF
	bitind db 0
	fd dd 0
	bitfd dd 0
	scale db -1
	out_file times 500 db -1
	infd dd 0
	totalB dd 0
	outptr dd 0
section .bss
	code resb 1000
	instruction resb 50
	opcode resb 6
	d resb 1
	w resb 1
	mod resb 2
	reg resb 3
	rm resb 3
	base resb 3
	index resb 3
	SS1 resb 2
	immidiate resb 32
section .text
	global _start
;;**********************************************************
_start:
	mov eax,5
	mov ebx,infadres
	mov ecx,0
	mov edx,777
	int 80h
	mov [infd],eax
	mov eax,3
	mov ebx,[infd]
	mov ecx,code
	mov edx,1000
	int 80h
	mov [totalB],eax
	mov dword[outptr],out_file
	mov esi,0
	push esi
codelop:			; initializinfg fields
	mov [scale],byte -1
	mov [index],byte '1'
	mov [index+1],byte '0'
	mov [index+2],byte '0'
	
	mov [base],byte '1'
	mov [base+1],byte '0'
	mov [base+2],byte '1'
	
	mov [rm],byte 0
	mov [rm+1],byte 0
	mov [rm+2],byte 0
	
	mov [reg],byte 0
	mov [reg+1],byte 0
	mov [reg+2],byte 0

	mov [mod],byte 0
	mov [mod+1],byte 0
	mov [SS1],byte '0'
	mov [SS1+1],byte '0'

	mov [d],byte 0
	mov [w],byte 0
	mov [result],byte -1
	mov [immval],byte -1
	mov [immbytecnt],byte 0
	mov ebp,0
RA:	
	cmp ebp,dword 32
	je  CNF
	mov [immidiate+ebp],byte '0'
	inc ebp
	jmp RA
CNF:
	mov ebp,0
RA1:	
	cmp ebp,20
	je  CNF1
	mov [op1+ebp],byte -1
	mov [op2+ebp],byte -1
	mov [mem+ebp],byte -1
	inc ebp
	jmp RA1
CNF1:	
	mov [memop1],byte 0
	mov [memop2],byte 0
	mov [error1],byte 0
	mov [error2],byte 0
	mov edi,0
reset:	
	cmp edi,50
	je  T1
	mov [instruction+edi],byte 0
	inc edi
	jmp reset
T1:	pop esi
	cmp esi,[totalB]
	jne C0
	jmp exit
C0:	mov edi,0
instlop
	mov al,byte[code+esi]
	cmp al,byte 10
	je  inst
	mov al,byte[code+esi]
	mov [instruction+edi],al
	inc esi
	inc edi
	jmp instlop
inst:
	inc esi
	push esi
	mov [instruction+edi],byte 10
	call codetokenizer
	call setopcode
	cmp [memop1],byte 0
	je  op1reg
op2cmp:	cmp [memop2],byte 0
	jne F1
	jmp  op2regimm
F1:	
	mov [error2],byte 1
	jmp printerrors
;;--------- first operand is a register ---------------------
op1reg:
	cmp [memop2],byte 0	; chek whether the second operand is a memory or not
	je  F2
	jmp setmemop2
;;--------- first operand is a reg and second one is a non-mem ---------------------
F2:	
	mov esi,0
lop1:	cmp esi,3
	je  endlop1
	mov al,[op1+esi]
	mov [srchval+esi],al
	inc esi
	jmp lop1
endlop1:
	call srchregtble
	call setW
	mov esi,0
	cmp [result],byte -1	; the first operand was an immidiate
	jne rmcmp1
	mov [error2],byte 1
	jmp printerrors
;;------------- set rm ---------------------
rmcmp1:	cmp esi,3
	je  endrm1
	mov al,[result+esi]
	mov [rm+esi],al
	inc esi
	jmp rmcmp1
endrm1:
;;------------- set mod --------------------
	mov [mod],word'11'
;;------------------------------------------
	mov esi,0
lop2:	
	cmp esi,3
	je  endlop2
	mov al,[op2+esi]
	mov [srchval+esi],al
	inc esi
	jmp lop2
endlop2:
	call srchregtble
	mov esi,0

	cmp [result],byte -1
	je  F3
	jmp regcmp1
F3:
;;-------- the second operand is an immidate ---------
	mov [reg],word'00'
	mov [reg+2],byte'0'
	mov esi,0
for3:	cmp [op2+esi],byte -1
	je  endfor3
	mov al,[op2+esi]
	mov [immval+esi],al
	inc esi
	jmp for3
endfor3:	
	call immcalculate
	jmp nxtstep
;;-------- register to register -------
	mov esi,0
lop3:	cmp esi,3
	je  endlop3
	mov al,[op1+esi]
	mov [srchval+esi],al
	inc esi
	jmp lop3
endlop3:
	call srchregtble
	call setW
	mov esi,0
rmcmp2:	cmp esi,3
	je  endrm2
	mov al,[result+esi]
	mov [rm+esi],al
	inc esi
	jmp rmcmp2
endrm2:
	mov [mod],word'11'
	jmp nxtstep
regcmp1:
	cmp esi,3
	je  endreg1
	mov al,[result+esi]
	mov [reg+esi],al
	inc esi
	jmp regcmp1
endreg1:
	mov esi,0
	mov [mod],word'00'
	jmp nxtstep
;;-------------- op1 reg, op2 mem -------------
setmemop2:			
	mov esi,0
lop4:	cmp esi,3
	je  endlop4
	mov al,[op1+esi]
	mov [srchval+esi],al
	inc esi
	jmp lop4
endlop4:
	call srchregtble
	call setW
	mov esi,0
regcmp3:
	cmp esi,3
	je  endreg3
	mov al,[result+esi]
	mov [reg+esi],al
	inc esi
	jmp regcmp3
endreg3:	
	mov esi,1	
L0:	
	cmp [op2+esi],byte -1
	je  tokenizing
	mov al,byte[op2+esi]
	mov [mem+esi-1],al
	inc esi
	jmp L0
tokenizing:	
	call memorytokenizer
	mov [rm],byte'1'
	mov [rm+1],byte'0'
	mov [rm+2],byte'0'
	
	call setmod
	jmp nxtstep
;;------ op1 mem, op2 reg or imm ------
op2regimm:
	mov esi,0
for4:	cmp [op1+esi],byte -1
	je  endfor4
	mov al,[op1+esi]
	mov [mem+esi],al
	inc esi
	jmp for4
endfor4:
	call memorytokenizer
	call setW
	mov esi,0
	mov [rm],byte'1'
	mov [rm+1],byte'0'
	mov [rm+2],byte'0'
	mov esi,0
lop7:
	cmp esi,3
	je  endlop7
	mov al,[op2+esi]
	mov [srchval+esi],al
	inc esi
	jmp lop7
endlop7:
	call srchregtble
	cmp [result],byte -1
	je  immop2
;;------------ second operand is a register -------
	call setW
	mov esi,0
for5:	cmp esi,3
	je  endfor5
	mov al,[result+esi]
	mov [reg+esi],al
	inc esi
	jmp for5
endfor5:
	call setmod
	jmp nxtstep
;;------------ second operand is an immidiate -------
immop2:
	mov esi,0
for7:	cmp [op2+esi],byte -1
	je  endfor7
	mov al,[op2+esi]
	mov [immval+esi],al
	inc esi
	jmp for7
endfor7:
	call immcalculate
nxtstep:
	call setD
printerrors:
	cmp [error1],byte 1
	jne nxterr
	mov eax,4
	mov ebx,1
	mov ecx,error1_prompt
	mov edx,22
	int 80h
nxterr:	cmp [error2],byte 1
	jne end
	mov eax,4
	mov ebx,1
	mov ecx,error2_prompt
	mov edx,49
	int 80h
	jmp enderr
end:
	mov eax,5
	mov ebx,outfadres
	mov ecx,2
	mov edx,0777
	int 80h
        mov [fd],eax
	
	mov edx,[outptr]
	mov eax,dword[opcode]
	mov [edx],eax
	mov ax,word[opcode+4]
	mov [edx+4],ax
	mov al,[d]
	mov [edx+6],al
	mov al,[w]
	mov [edx+7],al
	mov ax,word[mod]
	mov [edx+8],ax
	mov ax,word[reg]
	mov [edx+10],ax
	mov al,[reg+2]
	mov [edx+12],al
	mov ax,word[rm]
	mov [edx+13],ax
	mov al,[rm+2]
	mov [edx+15],al
	cmp [memop1],byte 1
	je  SIB
	cmp [memop2],byte 1
	je  SIB
	jmp imm
SIB:
	mov ax,word[SS1]
	mov [edx+16],ax
	mov ax,word[index]
	mov [edx+18],ax
	mov al,byte[index+2]
	mov [edx+20],al
	mov ax,word[base]
	mov [edx+21],ax
	mov al,byte[base+2]
	mov [edx+23],al
	mov ebx,0
	mov eax,0
	mov al,byte[immbytecnt]
	imul ebx,eax,8
	mov edi,0
	mov esi,24
repeat1:
	cmp edi,ebx
	je  writefile
	mov al,[immidiate+edi]
	mov [edx+esi],al
	inc esi
	inc edi
	jmp repeat1
imm:
	mov ebx,0
	mov eax,0
	mov al,byte[immbytecnt]
	imul ebx,eax,8
	mov edi,0
	mov esi,16
repeat2:
	cmp edi,ebx
	je  writefile
	mov al,[immidiate+edi]
	mov [edx+esi],al
	inc esi
	inc edi
	jmp repeat2
writefile:
	mov [edx+esi],byte 10

	mov [outlen],eax
	add edx,esi
	inc edx
	mov [outptr],edx
	jmp codelop
exit:		
	mov esi,0
writeagain:	
	cmp [out_file+esi],byte -1
	je  closef
	mov eax,4
	mov ebx,[fd]
	mov ecx,out_file
	add ecx,esi
	mov edx,1
 	int 80h
	inc esi
	jmp writeagain
closef:	
	mov eax,6
	mov ebx,[fd]
	int 80h

	mov dword[outlen],esi
	
	mov bl,80h		; bl=10000000
	mov ebp,-1
	mov edi,0
	mov esi,0
j1:	
	cmp esi,[outlen]
	je  j4
	
	mov byte[bitind],byte 0
	inc ebp
	mov bl,80h
j2:	cmp [bitind],byte 8
	je  j1
	mov dl,byte[out_file+esi]
	cmp dl,byte 10
	jne j5
	inc esi
	cmp esi,[outlen]
	je  j4
	jmp j2
j5:
	sub dl,byte'0'
	and dl,byte 1
	cmp dl,byte 0
	jne j0
	mov cl,bl
	not cl
	and byte[bitout+ebp],cl
j0:	shr bl,1
	inc esi
	inc byte[bitind]
	jmp j2
j4:

;; create bitfile
	mov eax,5
	mov ebx,bitoutf
	mov ecx,01101
	mov edx,511
	int 80h 
;; write to bitfile
	mov [bitfd],eax
	mov eax,4
	mov ebx,[bitfd]
	mov ecx,bitout
	inc ebp
	mov edx,ebp
	int 80h
	mov eax,6
	mov ebx,[bitfd]
	int 80h
enderr:	
	mov eax,1
	mov ebx,0
	int 80h
;;**********************************************************
codetokenizer:
	mov esi,0
;;;;;;; set opcodetok variable ;;;;;;;
opcdlop:
	cmp [instruction+esi],byte 32 ;compare with space character
	je  endopcodetok
	mov al,byte[instruction+esi]
	mov [opcodetok+esi],al
	inc esi
	jmp opcdlop
;;;;;;; skipping the sapces ;;;;;;;
endopcodetok:
jnklop:
	inc esi
	cmp [instruction+esi],byte 32
	jne endjunk
	jmp jnklop
endjunk:
;;;;;;; set op1 variable ;;;;;;;
	mov edi,0
	cmp [instruction+esi],byte 91 ;compare with '['
	jne  op1lop
	mov [memop1],byte 1
	jmp op1memory
op1lop: 
	cmp [instruction+esi],byte 44 ;compare with ','
	je  endop01
	mov al,[instruction+esi]
	mov [op1+edi],al
	inc edi
	inc esi
	jmp op1lop
endop01:	
	jmp jnk2lop
op1memory:
	inc esi
	cmp [instruction+esi],byte 44 ;compare with ','
	je  endop1
	mov al,[instruction+esi]
	mov [op1+edi],al
	inc edi
	jmp op1memory
endop1:
;;;;;;; skipping the sapces ;;;;;;;
jnk2lop:
	inc esi
	cmp [instruction+esi],byte 32
	jne endjunk2
	jmp jnk2lop
endjunk2:
;;;;;;; set op2 vaiable ;;;;;;;
	mov edi,0
	cmp [instruction+esi],byte 91
	jne  op2lop
	mov [memop2],byte 1
op2lop:
	cmp [instruction+esi],byte 10 ;compare with '\n'
	je  endop2
	mov al,[instruction+esi]
	mov [op2+edi],al
	inc edi
	inc esi
	jmp op2lop
endop2:
	ret
;;***********************************************
setopcode:
	mov ebp,0
	mov esi,-1
nextrow:
	inc esi
	cmp esi,16
	je  endsetop
	mov edi,0
	imul eax,esi,10
	cmp [opcodetable+eax],byte 45 ;compare with '-'
	jne cmpre
nextcol:inc edi
	cmp edi,4
	je  found
cmpre:
	mov bl,byte[opcodetable+eax+edi]
	cmp bl,byte[opcodetok+ebp]
	jne nextrow
	inc ebp
	jmp nextcol
found: ;set opcode field
	mov edi,3
	mov ebp,0
again1:
	inc edi
	cmp edi,10
	je  endsetop
	mov bl,byte[opcodetable+eax+edi]
	mov byte[opcode+ebp],bl
	inc ebp
	jmp again1
fail:
	mov [error1],byte 1
endsetop:
	ret
;;***********************************************
srchregtble:
	mov esi,0
srchlop0:
	cmp esi,3
	je  srch
	mov [result+esi],byte -1
	inc esi
	jmp srchlop0
srch:	
	mov esi,0
srchlop1:	
	mov edi,0
	mov ebp,0
	cmp esi,25
	je  exit1
	imul ebx,esi,6
	cmp [regtable+ebx],byte 45
	jne srchlop2
	inc edi
srchlop2:
	cmp edi,3
	je  foundreg
	mov al,byte[regtable+ebx+edi]
	cmp al,byte[srchval+ebp]
	jne break
	inc edi
	inc ebp
	jmp srchlop2
break:
	inc esi
	jmp srchlop1

foundreg:
	inc esi
	mov [regind],esi
	mov edi,3
	mov esi,0
L5:	
	cmp edi,6
	je  exit1
	mov al,byte[regtable+ebx+edi]
	mov [result+esi],al
	inc edi
	inc esi
	jmp L5

exit1:

	ret

;;***********************************************

setD:
	mov [d],byte'0'
	cmp [memop2],byte 1 ;see whether the second operand is a register or not
	jne  endD
	mov [d],byte'1'
endD:
	ret
	
;;***********************************************
setW:
	mov [w],byte'0'
	mov dx,0
	mov ax,word[regind]
	mov bl,byte 3
	div bl
	cmp ah,0
	jne endW
	mov [w],byte'1'
endW:
	ret
	
;;***********************************************
setmod:
	cmp [immbytecnt],byte 0
	je  zero
	cmp [immbytecnt],byte 1
	je  one
	mov [mod],word'10'
	jmp endsetmod
zero:	mov [mod],word'00'
	jmp endsetmod
one:	mov [mod],word'01'
endsetmod:
	ret
	
;;***********************************************
memorytokenizer:
	mov esi,0
	mov edi,0
R1:	cmp [mem+esi],byte 93	; compare with ']'
	jne M1
	jmp singletok
M1:
	cmp [mem+esi],byte 42
	jne M5
	jmp scaletok1
M5:	
	cmp [mem+esi],byte 43	; compare with '+'
	je  gottok1
	mov al,[mem+esi]
	mov [memtok1+edi],al
	mov [srchval+edi],al
	inc esi
	inc edi
	jmp R1
gottok1:
	push esi
	call srchregtble
	pop esi
	mov edi,0
	cmp [result],byte -1
	je  immtok
	mov edi,0
again2:
	cmp edi,dword 3
	je  nxttok2
	mov al,[result+edi]
	mov [base+edi],al
	inc edi
	jmp again2
immtok:
	mov edi,0
again3:	
	cmp [memtok1+edi],byte -1
	je  nxttok2
	mov al,[memtok1+edi]
	mov [immidiate+edi],al
	inc edi
	jmp again3
nxttok2:	
	inc esi
	mov edi,0
R2:	cmp [mem+esi],byte 93	; compare with ']'
	jne  M2
	jmp twopartmem
M2:	
	cmp [mem+esi],byte 43
	je  gottok2
	mov al,[mem+esi]
	mov [memtok2+edi],al
	mov [srchval+edi],al
	inc esi
	inc edi
	jmp R2
gottok2:
	mov edi,0
again4:
	cmp [memtok2+edi],byte -1
	je  basetok
	cmp [memtok2+edi],byte 42 ; compare with '*'
	je  scaletok12
	mov al,[memtok2+edi]
	mov [srchval+edi],al
	inc edi
	jmp again4
scaletok1:
	inc esi
	inc esi
	mov ebp,0
scale1lop:	
	cmp [mem+ebp],byte -1
	je  scaletok12
	mov al,[mem+ebp]
	mov [memtok2+ebp],al
	inc ebp
	jmp scale1lop
scaletok12:
	inc edi
	mov al,[memtok2+edi]
	sub al,byte'0'
	mov [scale],al
	push esi
	call srchregtble
	pop esi
	mov edi,0
again5:	
	cmp edi,dword 3
	je  nxttok3
	mov al,[result+edi]
	mov [index+edi],al
	inc edi
	jmp again5
basetok:
	push esi
	call srchregtble
	pop esi
	mov edi,0
again6:	
	cmp edi,dword 3
	je  nxttok3
	mov al,[result+edi]
	mov [base+edi],al
	inc edi
	jmp again6
nxttok3:
	inc esi
	mov edi,0
R3:	cmp [mem+esi],byte 93	; compare with ']'
	jne  M3
	jmp M4
M3:	
	mov al,[mem+esi]
	mov [memtok3+edi],al
	mov [srchval+edi],al
	inc esi
	inc edi
	jmp R3
M4:
	push esi
	call srchregtble
	pop esi
	cmp [result],byte -1
	je  immtok2
	mov edi,0
again7:	
	cmp [memtok3+edi],byte -1
	je  basetok2
	cmp [memtok3+edi],byte 42
	je  scaletok2
	mov al,[result+edi]
	mov [index+edi],al
	inc edi
	jmp again7
scaletok2:
	inc edi
	mov al,[memtok3+edi]
	sub al,byte'0'
	mov [scale],al
	jmp endmemtok
basetok2:
	mov edi,0
again8:
	cmp edi,dword 3
	jne A1
	jmp  endmemtok
A1:	mov al,[result+edi]
	mov [base+edi],al
	inc edi
	jmp again8
immtok2:
	mov edi,0
again9:	
	cmp [memtok3+edi],byte -1
	je  setimm
	mov al,[memtok3+edi]
	mov [immval+edi],al
	inc edi
	jmp again9
setimm:
	call immcalculate
endimmcalc:
	cmp [scale],byte -1
	jne  S0
	mov [SS1],word'00'
	jmp endmemtok
S0:	cmp [scale],byte 2
	jne S1
	mov ax,word'01'
	mov word[SS1],ax
	jmp endmemtok
S1:	cmp [scale],byte 4
	jne S2
	mov [SS1],word'10'
	jmp endmemtok
S2:	
	mov ax,word'11'
	mov word[SS1],ax
singletok:
	mov edi,0
s_again1:
	cmp [memtok1+edi],byte -1
	je  s_basetok
	cmp [memtok1+edi],byte 42 ; compare with '*'
	je  s_scaletok
	mov al,[memtok1+edi]
	mov [srchval+edi],al
	inc edi
	jmp s_again1
s_scaletok:
	inc edi
	mov al,[memtok1+edi]
	sub al,byte'0'
	mov [scale],al
	push esi
	call srchregtble
	pop esi
	mov edi,0
s_again2:	
	cmp edi,dword 3
	je  endmemtok
	mov al,[result+edi]
	mov [index+edi],al
	inc edi
	jmp s_again2
s_basetok:
	push esi
	call srchregtble
	pop esi
	mov edi,0
s_again3:	
	cmp edi,dword 3
	je  endmemtok
	mov al,[result+edi]
	mov [base+edi],al
	inc edi
	jmp s_again3
twopartmem:
	mov [scale],byte 0
	push esi
	call srchregtble
	pop esi
	mov edi,0
twoagain:	
	cmp edi,dword 3
	je  endmemtok
	mov al,[result+edi]
	mov [index+edi],al
	inc edi
	jmp twoagain
endmemtok:
	ret
;;**********************************************
immcalculate:
	mov edi,0
initcalres:	
	cmp edi,32
	je  endinitcalres
	mov [immcalcres+edi],byte'0'
	inc edi
	jmp initcalres
endinitcalres:
	mov edi,0
subagain:
	cmp [immval+edi],byte -1
	je  endsub
	sub [immval+edi],byte'0'
	inc edi
	jmp subagain
endsub:
	mov esi,0
	mov eax,0
	mov ebx,0
	
	mov bl,[immval+esi]
	dec edi
	mov ecx,edi
mulagain:
	mov eax,10
	mul ebx
	mov ebx,eax
	mov eax,0
	mov al,byte[immval+esi+1]
	add ebx,eax
	inc esi
	cmp esi,edi
	loopne mulagain
	
	mov esi,0
	mov eax,ebx
divagain:
	mov edx,0
	mov ecx,2 		
	div ecx	
	add dl,byte'0'		; qoutient in eax, reminder in edx
	mov [immcalcres+esi],dl
	inc esi
	cmp eax,0
	jne divagain
	mov edi,esi
	mov ecx,esi
	dec ecx
	mov ebp,0
rev:	mov al,[immcalcres+ecx]
	xchg [immcalcres+ebp],al
	mov [immcalcres+ecx],al
	inc ebp
	cmp ecx,ebp
	loopne rev
	cmp esi,0
	jg  C1
	mov [immbytecnt],byte 0
C1:
	cmp esi,8
	jg  C2
	mov [immbytecnt],byte 1
	mov edi,0
copy1:
	cmp edi,esi
	je  endcalculate
	mov bl,byte[immcalcres+edi]
	mov eax,dword immidiate
	sub eax,esi
	add eax,edi
	mov [eax+8],bl
	inc edi
	jmp copy1
	
C2:
	cmp esi,16
	jg  C2
	mov [immbytecnt],byte 2
	mov edi,0
copy2:
	cmp edi,esi
	je  endcalculate
	mov bl,byte[immcalcres+edi]
	mov eax,dword immidiate
	sub eax,esi
	add eax,edi
	mov [eax+16],bl
	inc edi
	jmp copy2
	
	mov edi,esi
CC2:	cmp edi,32
	je  C2
	mov [immcalcres+edi],byte'0'
	inc edi
	jmp CC2
endcalculate
	ret
;;**********************************************
