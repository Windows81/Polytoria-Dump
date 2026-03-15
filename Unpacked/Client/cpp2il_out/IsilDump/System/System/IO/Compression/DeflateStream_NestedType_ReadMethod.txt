Type: System.IO.Compression.DeflateStream+ReadMethod

Method: System.Void .ctor(System.Object object, System.IntPtr method)

Disassembly:
	mov [rsp+8],rbx
	mov [rsp+10h],rbp
	mov [rsp+18h],rsi
	push rdi
	sub rsp,20h
	mov rax,[r8+8]
	mov rbx,r8
	mov [rcx+10h],rax
	mov rdi,rcx
	mov [rcx+28h],rbx
	mov rbp,rdx
	mov [rcx+20h],rdx
	add rcx,20h
	call 000000018020B990h
	movzx esi,byte ptr [rbx+52h]
	mov rcx,rbx
	mov [rdi+40h],rdi
	call 000000018020B9C0h
	test al,al
	je short 00000001815499F9h
	cmp sil,3
	jne short 0000000181549A0Dh
	lea rax,[180015100h]
	jmp short 0000000181549A19h
	cmp sil,2
	jne short 0000000181549A08h
	lea rax,[180042540h]
	jmp short 0000000181549A19h
	test rbp,rbp
	je short 0000000181549A3Dh
	mov rax,[rdi+20h]
	mov [rdi+40h],rax
	mov rax,[rdi+10h]
	mov [rdi+18h],rax
	lea rax,[1801A6610h]
	mov rbx,[rsp+30h]
	mov rbp,[rsp+38h]
	mov rsi,[rsp+40h]
	mov [rdi+38h],rax
	add rsp,20h
	pop rdi
	ret
	lea rdx,[181E5DD00h]
	xor ecx,ecx
	call 000000018020C470h
	mov rcx,rax
	xor edx,edx
	call 000000018020CA70h

ISIL:
	001 Move stack:0x8, rbx
	002 Move stack:0x10, rbp
	003 Move stack:0x18, rsi
	004 ShiftStack -8
	005 Move stack:0x0, rdi
	006 ShiftStack -32
	007 Move rax, [r8+8]
	008 Move rbx, r8
	009 Move [rcx+16], rax
	010 Move rdi, rcx
	011 Move [rcx+40], rbx
	012 Move rbp, rdx
	013 Move [rcx+32], rdx
	014 Add rcx, rcx, 32
	015 Call 0x18020B990, rcx, rdx, r8, r9
	016 Move rsi, [rbx+82]
	017 Move rcx, rbx
	018 Move [rdi+64], rdi
	019 Call 0x18020B9C0, rcx, rdx, r8, r9
	020 Compare rax, 0
	021 JumpIfEqual {26}
	022 Compare rsi, 3
	023 JumpIfNotEqual {32}
	024 LoadAddress rax, [0x180015100]
	025 Goto {35}
	026 Compare rsi, 2
	027 JumpIfNotEqual {30}
	028 LoadAddress rax, [0x180042540]
	029 Goto {35}
	030 Compare rbp, 0
	031 JumpIfEqual {45}
	032 Move rax, [rdi+32]
	033 Move [rdi+64], rax
	034 Move rax, [rdi+16]
	035 Move [rdi+24], rax
	036 LoadAddress rax, [0x1801A6610]
	037 Move rbx, stack:0x30
	038 Move rbp, stack:0x38
	039 Move rsi, stack:0x40
	040 Move [rdi+56], rax
	041 ShiftStack 32
	042 Move rdi, stack:0x0
	043 ShiftStack 8
	044 Return 
	045 LoadAddress rdx, [0x181E5DD00]
	046 Move rcx, 0
	047 Call 0x18020C470, rcx, rdx, r8, r9
	048 Move rcx, rax
	049 Move rdx, 0
	050 Call 0x18020CA70, rcx, rdx, r8, r9

Method: System.Int32 Invoke(System.Byte[] array, System.Int32 offset, System.Int32 count)

Disassembly:
	mov rax,[rcx+28h]
	mov r10,[rcx+18h]
	mov rcx,[rcx+40h]
	mov [rsp+28h],rax
	jmp r10

ISIL:
	001 Move rax, [rcx+40]
	002 Move r10, [rcx+24]
	003 Move rcx, [rcx+64]
	004 Move stack:0x28, rax
	005 CallNoReturn r10

Method: System.IAsyncResult BeginInvoke(System.Byte[] array, System.Int32 offset, System.Int32 count, System.AsyncCallback callback, System.Object object)

Disassembly:
	mov [rsp+20h],r9d
	mov [rsp+18h],r8d
	push rbx
	sub rsp,40h
	mov rbx,rcx
	mov [rsp+20h],rdx
	mov rcx,[182783188h]
	lea rdx,[rsp+60h]
	mov qword ptr [rsp+38h],0
	call 000000018020B970h
	mov rcx,[182783188h]
	lea rdx,[rsp+68h]
	mov [rsp+28h],rax
	call 000000018020B970h
	mov r9,[rsp+78h]
	lea rdx,[rsp+20h]
	mov r8,[rsp+70h]
	mov rcx,rbx
	mov [rsp+30h],rax
	call 000000018020C450h
	add rsp,40h
	pop rbx
	ret

ISIL:
	001 Move stack:0x20, r9
	002 Move stack:0x18, r8
	003 ShiftStack -8
	004 Move stack:0x0, rbx
	005 ShiftStack -64
	006 Move rbx, rcx
	007 Move stack:0x20, rdx
	008 Move rcx, [0x182783188]
	009 LoadAddress rdx, stack:0x60
	010 Move stack:0x38, 0
	011 Call "il2cpp_value_box", rcx, rdx, r8, r9
	012 Move rcx, [0x182783188]
	013 LoadAddress rdx, stack:0x68
	014 Move stack:0x28, rax
	015 Call "il2cpp_value_box", rcx, rdx, r8, r9
	016 Move r9, stack:0x78
	017 LoadAddress rdx, stack:0x20
	018 Move r8, stack:0x70
	019 Move rcx, rbx
	020 Move stack:0x30, rax
	021 Call 0x18020C450, rcx, rdx, r8, r9
	022 ShiftStack 64
	023 Move rbx, stack:0x0
	024 ShiftStack 8
	025 Return rax

Method: System.Int32 EndInvoke(System.IAsyncResult result)

Disassembly:
	sub rsp,28h
	mov rcx,rdx
	xor edx,edx
	call 000000018020C460h
	test rax,rax
	je short 00000001803B2422h
	mov rcx,rax
	call 000000018020BB70h
	mov eax,[rax]
	add rsp,28h
	ret
	call 000000018020CAB0h

ISIL:
	001 ShiftStack -40
	002 Move rcx, rdx
	003 Move rdx, 0
	004 Call 0x18020C460, rcx, rdx, r8, r9
	005 Compare rax, 0
	006 JumpIfEqual {12}
	007 Move rcx, rax
	008 Call "il2cpp_object_unbox", rcx, rdx, r8, r9
	009 Move rax, [rax]
	010 ShiftStack 40
	011 Return rax
	012 Call 0x18020CAB0, rcx, rdx, r8, r9

