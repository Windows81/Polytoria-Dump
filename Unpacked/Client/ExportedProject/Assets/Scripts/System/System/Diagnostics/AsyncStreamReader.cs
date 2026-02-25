namespace System.Diagnostics;

[Token(Token = "0x2000100")]
internal class AsyncStreamReader
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000459")]
	private Stream stream; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400045A")]
	private Encoding encoding; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400045B")]
	private Decoder decoder; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400045C")]
	private Byte[] byteBuffer; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x400045D")]
	private Char[] charBuffer; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x400045E")]
	private bool cancelOperation; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400045F")]
	private ManualResetEvent eofEvent; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x4000460")]
	private object syncObject; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x4000461")]
	private IAsyncResult asyncReadResult; //Field offset: 0x50

	[Address(RVA = "0x17658B0", Offset = "0x1764AB0", Length = "0x5")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061E")]
	internal void CancelOperation() { }

	[Address(RVA = "0x146EBB0", Offset = "0x146DDB0", Length = "0x16")]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600061C")]
	public override void Close() { }

	[Address(RVA = "0x17658C0", Offset = "0x1764AC0", Length = "0x2FD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(Boolean&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002270")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = "System.IO.MonoIO", Member = "Cancel", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SafeHandle), typeof(MonoIOError&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsUnknownMethods(Count = 4)]
	[Token(Token = "0x600061D")]
	protected override void Dispose(bool disposing) { }

	[Address(RVA = "0x1765BC0", Offset = "0x1764DC0", Length = "0x66")]
	[CalledBy(Type = typeof(Process), Member = "WaitForExit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x600061F")]
	internal void WaitUtilEOF() { }

}

