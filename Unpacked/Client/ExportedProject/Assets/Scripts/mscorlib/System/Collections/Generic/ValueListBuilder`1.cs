namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20005E6")]
internal struct ValueListBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001863")]
	private Span<T> _span; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001864")]
	private T[] _arrayFromPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4001865")]
	private int _pos; //Field offset: 0x0

	[Token(Token = "0x170006D0")]
	public int Length
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002B60")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x86D450", Offset = "0x86C650", Length = "0x10")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B5F")]
	public ValueListBuilder`1(Span<T> initialSpan) { }

	[Address(RVA = "0x86C4A0", Offset = "0x86B6A0", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B61")]
	public void Append(T item) { }

	[Address(RVA = "0x86C850", Offset = "0x86BA50", Length = "0xD9")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B62")]
	public ReadOnlySpan<T> AsSpan() { }

	[Address(RVA = "0x86CA20", Offset = "0x86BC20", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B63")]
	public void Dispose() { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B60")]
	public int get_Length() { }

	[Address(RVA = "0x86CDF0", Offset = "0x86BFF0", Length = "0x214")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(Span`1), Member = "TryCopyTo", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x6002B64")]
	private void Grow() { }

}

