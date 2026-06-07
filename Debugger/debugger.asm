;;;********************************** DEBUGGER **********************************;;;
section .data
	filename db '/home/fateme/Desktop/final-project/test',0
	fd dd 0
	filelen dd 0
	exited db 'Program exited normally.',10
	debugger db 'debugger',10
	code dd 0
	exist db 1
	output dd 0
	entr db 10
	opcode times 8 db -1
	op1 db '1','1','1',','
	op2 db '1','1','1','1','1'
	mov1 db 1,0,0,0,1,0
	mov2 db 1,0,1,1
	mov3 db 1,0,0,0,1,0,1
	mov4 db 1,0,1,0,0,0
	add1 db 0,0,0,0,0,1
	add2 db 1,0,0,0,0,0
	add3 db 0,0,0,0,0,0
	and1 db 0,0,1,0,0,1
	and2 db 0,0,1,0,0,0
	inc1 db 0,1,0,0,0
	dec1 db 0,1,0,0,1
	jmp1 db 1,1,1,0,1,0
	cal  db 1,1,1,0,1,0,0,0
	regtable db 'eax000','ecx001','edx010','ebx011','esp100','ebp101','esi110','edi111'
	xregs db 'Do you want to examine registers?(y/n)'
	prompt db 'Press enter to continue',10
	eaxreg db 'eax '
	ecxreg db 'ecx '
	edxreg db 'edx '
	ebxreg db 'ebx '
	espreg db 'esp '
	ebpreg db 'ebp '
	esireg db 'esi '
	edireg db 'edi '
	digitlen db 1
	op1count dd 4
	op2count dd 3
section .bss
	op resb 3
	n resb 5
	myhandler resd 32
	input resb 600
	opcodeinst resb 3
	yn resb 4
	eaxval resb 3
	ecxval resb 3
	edxval resb 3
	ebxval resb 3
	espval resb 3
	ebpval resb 3
	esival resb 3
	edival resb 3
	digits resb 3
	result resb 3
	regname resb 4
	regval resb 1
section .text
	global main
;;********************************************
main:
	extern sigaction 
	mov eax,5
	mov ebx,filename
	mov ecx,0		; readonly access mode
	mov edx,777
	int 80h

	mov [fd],eax

	mov eax,3
	mov ebx,[fd]
	mov ecx,input
	mov edx,50
	int 80h
	mov [filelen],eax
	
	mov eax,6
	mov ebx,[fd]
	int 80h
	
	mov dword[myhandler],s_handler
	push dword 0
	lea eax,[myhandler]
	push eax
	push dword 5
	call sigaction

	pushf
	pop ax
	or ax,0100h
	push ax
	popf
	call input

	mov eax,4
	mov ebx,1
	mov ecx,exited
	mov edx,25
	int 80h
	
	mov eax,1
	mov ebx,0
	int 80h

	
settrapflag:
	pushf
	pop ax
	or ax,0100h
	push ax
	popf

	ret
;;****************************************
s_handler:

;;-----------reset opcode and op1 and op2-----------
	mov esi,0
for1:	
	cmp esi,8
	je  L9
	mov [opcode+esi],byte 1
	inc esi
	jmp for1
	
L9:	mov esi,0
for2:	cmp esi,3
	je  L10
	mov [op+esi],byte'1'
	inc esi
	jmp for2

L10:	mov esi,0
for3:	cmp esi,3
	je  L12
	mov [op2+esi],byte'1'
	inc esi
	jmp for3
L12:	
	mov eax,4
	mov ebx,1
	mov ecx,debugger
	mov edx,9
	int 80h
	
	mov eax,dword[esp+40h]
	mov al,[eax]
	cmp al,0xC3		; compare with return to the other segment code
	je  end1
	jmp L0
end1:
	mov eax,dword[esp+72]
	and ax,0xFEFF
	mov dword[esp+72],eax
	jmp L1
L0:	
;;---------- find the opcode bits ----------
 	mov eax,dword[esp+40h]
	mov al,[eax]
	mov bl,80h
	mov esi,0
re:	
	cmp esi,8
	je  L2
	mov cl,bl
	and cl,al
	cmp cl,byte 0
	jne next
	mov byte[opcode+esi],cl
next:	
	inc esi
	shr bl,1
	jmp re
;;------ compare the opcode bits to get the opcode name ----------
L2:
	mov esi,0
calcompare:	
	cmp esi,8
	jne MC
	jmp foundcal
MC:
	mov al,byte[cal+esi]
	cmp al,byte[opcode+esi]
	jne continue11
	inc esi
	jmp calcompare
continue11:
	mov esi,0
mov3compare:	
	cmp esi,7
	jne M3
	jmp foundmov3
M3:
	mov al,byte[mov3+esi]
	cmp al,byte[opcode+esi]
	jne continue12
	inc esi
	jmp mov3compare
continue12:

	mov esi,0
mov4compare:	
	cmp esi,6
	jne M4
	jmp foundmov4
M4:
	mov al,byte[mov4+esi]
	cmp al,byte[opcode+esi]
	jne continue13
	inc esi
	jmp mov4compare
continue13:
	mov esi,0
mov1compare:	
	cmp esi,6
	jne M1
	jmp foundmov1
M1:
	mov al,byte[mov1+esi]
	cmp al,byte[opcode+esi]
	jne continue1
	inc esi
	jmp mov1compare
continue1:
	mov esi,0
mov2compare:	
	cmp esi,4
	jne M2
	jmp foundmov2
M2:
	mov al,byte[mov2+esi]
	cmp al,byte[opcode+esi]
	jne continue2
	inc esi
	jmp mov2compare
continue2:
	mov esi,0
add1compare:	
	cmp esi,6
	jne A1
	jmp foundadd1
A1:
	mov al,byte[add1+esi]
	cmp al,[opcode+esi]
	jne continue3
	inc esi
	jmp add1compare
	
continue3:
	mov esi,0
add2compare:	
	cmp esi,6
	jne A2
	jmp foundadd2
A2:	
	mov al,byte[add2+esi]
	cmp al,[opcode+esi]
	jne continue4
	inc esi
	jmp add2compare
continue4:
	mov esi,0
inccompare:	
	cmp esi,5
	jne I
	jmp foundinc
I:	
	mov al,byte[inc1+esi]
	cmp al,[opcode+esi]
	jne continue9
	inc esi
	jmp inccompare
continue9:	
	mov esi,0
deccompare:	
	cmp esi,5
	jne D
	jmp founddec
D:	
	mov al,byte[dec1+esi]
	cmp al,[opcode+esi]
	jne continue5
	inc esi
	jmp deccompare
continue5:
	mov esi,0
Add3compare:	
	cmp esi,6
	jne Add3
	jmp foundAdd3
Add3:	
	mov al,byte[add3+esi]
	cmp al,[opcode+esi]
	jne continue6
	inc esi
	jmp Add3compare
continue6:
	mov esi,0
and1compare:	
	cmp esi,6
	jne And1
	jmp foundand1
And1:
	mov al,byte[and1+esi]
	cmp al,[opcode+esi]
	jne continue7
	inc esi
	jmp and1compare
	
continue7:
	mov esi,0
and2compare:	
	cmp esi,6
	jne And2
	jmp foundand2
And2:	
	mov al,byte[and2+esi]
	cmp al,[opcode+esi]
	jne continue8
	inc esi
	jmp and2compare
continue8:
	mov esi,0
jmpcompare:	
	cmp esi,6
	jne J
	jmp foundjmp
J:	
	mov al,byte[jmp1+esi]
	cmp al,[opcode+esi]
	jne continue10
	inc esi
	jmp jmpcompare
continue10:
	mov esi,0
SQ:	cmp esi,6
	je  SR
	add [opcode+esi],byte'0'
	mov eax,4
	mov ebx,1
	mov ecx,opcode
	add ecx,esi
	mov edx,1
	int 80h
	inc esi
	jmp SQ
SR:			
	ret
;;------------------------------------------
foundmov1:			;mov  reg to reg
	mov dword[opcodeinst],'mov '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov al,[eax]
	mov bl,4
	mov esi,0
	
M11:	cmp esi,3
	je  M1search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne M1nxt
	mov byte[op+esi],byte'0'
M1nxt:
	inc esi
	shr bl,1
	jmp M11
M1search:
	call srchregop
	mov esi,0
M11cmp:	cmp esi,3
	je  M11endcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp M11cmp
M11endcmp
	mov [op],byte'1'
	mov [op+1],byte'1'
	mov [op+2],byte'1'
	mov eax,dword[esp+40h]	; find op2
	inc eax
	mov al,[eax]
	mov bl,20h
	mov esi,0
	
M21:	cmp esi,3
	je  M11search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne M2nxt
	mov byte[op+esi],byte'0'
M2nxt:
	inc esi
	shr bl,1
	jmp M21
M11search:	
	call srchregop
	mov esi,0
M1cmp:	cmp esi,3
	je  M1endcmp
	mov al,byte[op+esi]
	sub al,byte'0'
	mov byte[op2+esi],al
	inc esi
	jmp M1cmp
M1endcmp
	mov [op2count],dword 3
	jmp print
;;------------------------------------------
foundmov2:			;mov  imm to reg
	mov dword[opcodeinst],'mov '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov eax,dword[esp+40h]	; find op1
	mov al,[eax]
	mov bl,4
	mov esi,0
	
L7:	cmp esi,3
	je  search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne nxt
	mov byte[op+esi],byte'0'
nxt:
	inc esi
	shr bl,1
	jmp L7
search:
	call srchregop
	mov esi,0
M2cmp:	cmp esi,3
	je  M2endcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp M2cmp
M2endcmp
	mov eax,dword[esp+40h]	; find op2
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	mov [op2count],al
	mov ebx,0
repeat1:	
	cmp bl,byte[digitlen]
	je  S1
	mov al,byte[result+ebx]
	mov [op2+ebx],al
	inc ebx
	jmp repeat1
S1:
	jmp print
;;------------------------------------------------
foundmov3:			; mov mem to reg
	mov dword[opcodeinst],'mov '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov al,[eax]
	mov bl,20h
	mov esi,0
	
M31:	cmp esi,3
	je  M3search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne M3nxt
	mov byte[op+esi],byte'0'
M3nxt:
	inc esi
	shr bl,1
	jmp M31
M3search:
	call srchregop
	mov esi,0
M31cmp:	cmp esi,3
	je  M31endcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp M31cmp
M31endcmp

	mov [op],byte'1'
	mov [op+1],byte'1'
	mov [op+2],byte'1'
	mov eax,dword[esp+40h]	; find op2
	inc eax
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	add al,byte 2
	mov [op2count],al
 	mov [op2],byte 43	; insert '[' at start of op2
	mov ebx,0
M3repeat:	
	cmp bl,byte[digitlen]
	je  SM3
	mov al,byte[result+ebx]
	mov [op2+ebx+1],al
	inc ebx
	jmp M3repeat
SM3:
 	mov [op2+ebx+1],byte 45	; insert ']' at end of op2
	jmp print
;;------------------------------------------
foundmov4:			; mov mem to eax
	mov dword[opcodeinst],'mov '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov dword[op1],'eax '
	mov eax,[esp+40h]	; find op2
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	add al,byte 2
	mov [op2count],al
	mov [op2],byte 43
	mov ebx,0
M4repeat:
	cmp bl,byte[digitlen]
	je  SM4
	mov al,byte[result+ebx]
	mov [op2+ebx+1],al
	inc ebx
	jmp M4repeat
SM4:
	mov [op2+ebx+1],byte 45
	jmp print
;;------------------------------------------
foundadd1:			; add imm to eax
	mov dword[opcodeinst],'add '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov dword[op1],'eax,'

	mov eax,[esp+40h]	; find op2
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	mov [op2count],al
	mov ebx,0
repeat2:
	cmp bl,byte[digitlen]
	je  S2
	mov al,byte[result+ebx]
	mov [op2+ebx],al
	inc ebx
	jmp repeat2
S2:
	jmp print

;;------------------------------------------------
foundadd2:			; add imm to reg
	mov dword[opcodeinst],'add '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov al,[eax]
	mov bl,4
	mov esi,0
	
L11:	cmp esi,3
	je  search1
	mov cl,bl
	and cl,al
	cmp cl,0
	jne nxt1
	mov byte[op+esi],byte'0'
nxt1:
	inc esi
	shr bl,1
	jmp L11
search1:
	call srchregop
	mov esi,0
A1cmp:	cmp esi,3
	je  A1endcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp A1cmp
A1endcmp
	mov eax,dword[esp+40h]	; find op2
	inc eax
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	mov [op2count],al
	mov ebx,0
repeat3:	
	cmp bl,byte[digitlen]
	je  S3
	mov al,byte[result+ebx]
	mov [op2+ebx],al
	inc ebx
	jmp repeat3
S3:	
	jmp print
;;-----------------------------------------------------
foundAdd3:			; add reg to reg
	mov dword[opcodeinst],'add '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov al,[eax]
	mov bl,4
	mov esi,0
	
Add31:	cmp esi,3
	je  Add31search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne Add31nxt
	mov byte[op+esi],byte'0'
Add31nxt:
	inc esi
	shr bl,1
	jmp Add31
Add31search:
	call srchregop
	
	mov esi,0
Add31cmp:
	cmp esi,3
	je  Add31endcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp Add31cmp
Add31endcmp
	mov [op],byte'1'
	mov [op+1],byte'1'
	mov [op+2],byte'1'
	mov eax,dword[esp+40h]	; find op2
	inc eax
	mov al,[eax]
	mov bl,20h
	mov esi,0
	
Add32:	cmp esi,3
	je  Add32search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne Add32nxt
	mov byte[op+esi],byte'0'
Add32nxt:
	inc esi
	shr bl,1
	jmp Add32
Add32search:	
	call srchregop
	mov esi,0
Add32cmp:
	cmp esi,3
	je  Add32endcmp
	mov al,byte[op+esi]
	sub al,byte'0'
	mov byte[op2+esi],al
	inc esi
	jmp Add32cmp
Add32endcmp
	mov [op2count],dword 3
	jmp print
;;-----------------------------------------------------
foundinc:
	
	mov dword[opcodeinst],'inc '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 3
	mov eax,dword[esp+40h]	; find op1
	mov al,[eax]
	mov bl,4
	mov esi,0
	
I1:	cmp esi,3
	je  Isearch
	mov cl,bl
	and cl,al
	cmp cl,0
	jne Inxt
	mov byte[op+esi],byte'0'
Inxt:
	inc esi
	shr bl,1
	jmp I1
Isearch:
	call srchregop
	mov esi,0
Icmp:	cmp esi,3
	je  Iendcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp Icmp
Iendcmp
	mov [op2count],dword 0
	jmp print
;;-----------------------------------------------------
founddec:
	
	mov dword[opcodeinst],'dec '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 3
	mov eax,dword[esp+40h]	; find op1
	mov al,[eax]
	mov bl,4
	mov esi,0
	
D1:	cmp esi,3
	je  Dsearch
	mov cl,bl
	and cl,al
	cmp cl,0
	jne Dnxt
	mov byte[op+esi],byte'0'
Dnxt:
	inc esi
	shr bl,1
	jmp D1
Dsearch:
	call srchregop
	mov esi,0
Dcmp:	cmp esi,3
	je  Dendcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp Dcmp
Dendcmp
	mov [op2count],dword 0
	jmp print
;;-----------------------------------------------------
foundjmp:
	
	mov dword[opcodeinst],'jmp '
	mov [opcodeinst+4],byte' '
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	mov [op1count],al
	mov ebx,0
jmprpt:	
	cmp bl,byte[digitlen]
	je  endrpt
	mov al,byte[result+ebx]
	add al,byte'0'
	mov [op1+ebx],al
	inc ebx
	jmp jmprpt
endrpt:
	mov [op2count],dword 0
	jmp print
;;-----------------------------------------------------
foundcal:
	
	mov dword[opcodeinst],'call'
	mov [opcodeinst+4],byte' '
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	mov [op1count],al
	mov ebx,0
calrpt:	
	cmp bl,byte[digitlen]
	je  endcalrpt
	mov al,byte[result+ebx]
	add al,byte'0'
	mov [op1+ebx],al
	inc ebx
	jmp calrpt
endcalrpt:
	mov [op2count],dword 0
	jmp print

;;-----------------------------------------------------
foundand1:			; and imm to eax
	mov dword[opcodeinst],'and '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov dword[op1],'eax,'

	mov eax,[esp+40h]	; find op2
	inc eax
	mov bl,[eax]
	mov eax,0
	mov al,bl
	call tokdigits
	mov al,[digitlen]
	mov [op2count],al
	mov ebx,0
and1repeat:
	cmp bl,byte[digitlen]
	je  and1end
	mov al,byte[result+ebx]
	mov [op2+ebx],al
	inc ebx
	jmp and1repeat
and1end:
	jmp print
;;-----------------------------------------------------
foundand2:			; and reg to reg
	mov dword[opcodeinst],'and '
	mov [opcodeinst+4],byte' '
	mov [op1count],dword 4
	mov eax,dword[esp+40h]	; find op1
	inc eax
	mov al,[eax]
	mov bl,4
	mov esi,0
	
And31:	cmp esi,3
	je  And31search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne And31nxt
	mov byte[op+esi],byte'0'
And31nxt:
	inc esi
	shr bl,1
	jmp And31
And31search:
	call srchregop
	
	mov esi,0
And31cmp:
	cmp esi,3
	je  And31endcmp
	mov al,byte[op+esi]
	mov byte[op1+esi],al
	inc esi
	jmp And31cmp
And31endcmp
	mov [op],byte'1'
	mov [op+1],byte'1'
	mov [op+2],byte'1'
	mov eax,dword[esp+40h]	; find op2
	inc eax
	mov al,[eax]
	mov bl,20h
	mov esi,0
	
And32:	cmp esi,3
	je  And32search
	mov cl,bl
	and cl,al
	cmp cl,0
	jne And32nxt
	mov byte[op+esi],byte'0'
And32nxt:
	inc esi
	shr bl,1
	jmp And32
And32search:	
	call srchregop
	mov esi,0
And32cmp:
	cmp esi,3
	je  And32endcmp
	mov al,byte[op+esi]
	sub al,byte'0'
	mov byte[op2+esi],al
	inc esi
	jmp And32cmp
And32endcmp
	mov [op2count],dword 3
	jmp print
;;-----------------------------------------------------
print:
	mov eax,4		; write opcode
	mov ebx,1
	mov ecx,opcodeinst
	mov edx,5
	int 80h
	
	mov eax,4		; write op1
	mov ebx,1
	mov ecx,op1
	mov edx,[op1count]
	int 80h
	

	add [op2],byte'0'	; write op2
	add [op2+1],byte'0'
	add [op2+2],byte'0'
	add [op2+3],byte'0'
	add [op2+4],byte'0'
	mov eax,0
	mov al,byte[digitlen]
	mov esi,eax
	mov edi,0
P1:	cmp esi,dword 0
	je P2
	mov eax,4	
	mov ebx,1
	mov ecx,op2
	mov edx,[op2count]
	int 80h

P2:	

	mov eax,4		; new line
	mov ebx,1
	mov ecx,entr
	mov edx,1
	int 80h
L1:
	mov eax,4
	mov ebx,1
	mov ecx,xregs
	mov edx,38
	int 80h
	
	mov eax,3
	mov ebx,0
	mov ecx,yn
	mov edx,2
	int 80h

	cmp [yn],byte'y'
	je  yes
	jmp end
yes:	
;;-------- print regiters------
	;; eax
	mov eax,dword[eaxreg]
	mov [regname],eax
	mov al,byte[esp+52]
	mov [regval],al
	call printreg
	
	;; ecx
	mov eax,dword[ecxreg]
	mov [regname],eax
	mov al,byte[esp+48]
	mov [regval],al
	call printreg
	
	;; edx
	mov eax,dword[edxreg]
	mov [regname],eax
	mov al,byte[esp+44]
	mov [regval],al
	call printreg
	
	;; ebx
	mov eax,dword[ebxreg]
	mov [regname],eax
	mov al,byte[esp+40]
	mov [regval],al
	call printreg
	
	;; esp
	mov eax,dword[espreg]
	mov [regname],eax
	mov al,byte[esp+36]
	mov [regval],al
	call printreg
	
	;; ebp
	mov eax,dword[ebpreg]
	mov [regname],eax
	mov al,byte[esp+32]
	mov [regval],al
	call printreg
	
	;; esi
	mov eax,dword[esireg]
	mov [regname],eax
	mov al,byte[esp+28]
	mov [regval],al
	call printreg
	
	;; edi
	mov eax,dword[edireg]
	mov [regname],eax
	mov al,byte[esp+24]
	mov [regval],al
	call printreg

end:
	mov eax,4
	mov ebx,1
	mov ecx,prompt
	mov edx,24
	int 80h
	
	mov eax,3
	mov ebx,0
	mov ecx,n
	mov edx,2
	int 80h
	
	ret
;;********************************************
srchregop:
	mov esi,0
srchlop1:	
	mov edi,3
	mov ebp,0
	cmp esi,8
	je  foundop1
srchlop2:
	cmp edi,6
	je  foundop1
	imul ebx,esi,6
	mov al,byte[regtable+ebx+edi]
	cmp al,byte[op+ebp]
	jne break
	inc edi
	inc ebp
	jmp srchlop2
break:
	inc esi
	jmp srchlop1

foundop1:
	mov edi,0
L5:	
	cmp edi,3
	je  exit1
	mov al,byte[regtable+ebx+edi]
	mov [op+edi],al
	inc edi
	jmp L5

exit1:	
	ret

;;**********************************************
tokdigits:
	mov ebx,0
	mov edx,0
	mov [result],byte 0
	mov [result+1],byte 0
	mov [result+2],byte 0
divagain:
	cmp eax,dword 0
	je  reverse
	mov edx,0
	mov ecx,10
	div ecx
	mov [digits+ebx],dl
	inc ebx
	jmp divagain

reverse:
	mov [digitlen],bl
	cmp bl,byte 0
	jne D2
	inc byte[digitlen]
	mov [digits+ebx],dl
	inc ebx
D2:	
	dec ebx
	mov edi,0
revagain:	
	cmp ebx,dword -1
	je  return
	mov al,[digits+ebx]
	mov [result+edi],al
	dec ebx
	inc edi
	jmp revagain
return:
	ret
;;;***********************************************
printreg:

	mov eax,4
	mov ebx,1
	mov ecx,regname
	mov edx,4
	int 80h
	
	mov al,byte[regval]
	call tokdigits
	add [result],byte'0'
	add [result+1],byte'0'
	add [result+2],byte'0'
	mov eax,0
	mov al,byte[digitlen]
	mov esi,eax
	dec esi
	mov edi,0
redo:	
	cmp esi,dword -1
	je  N1
	mov eax,4
	mov ebx,1
	mov ecx,result
	add ecx,edi
	mov edx,1
	int 80h
	inc edi
	dec esi
	jmp redo
N1:	
	mov eax,4
	mov ebx,1
	mov ecx,entr
	mov edx,1
	int 80h
	
	ret
