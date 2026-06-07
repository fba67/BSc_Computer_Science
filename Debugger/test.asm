bits 32
section .text
	global _start
_start:
	
	mov ebx,128
	mov esi,8
	jmp L0
	mov esi,2
L0:	mov edi,4
	dec ebx
	mov eax,53
L1:	add esi,2
	inc esi
	add eax,7
	mov eax,28
	ret
