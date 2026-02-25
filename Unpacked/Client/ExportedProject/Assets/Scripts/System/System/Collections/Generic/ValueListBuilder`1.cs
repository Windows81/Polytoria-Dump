namespace System.Collections.Generic;

[DefaultMember("Item")]
[IsByRefLike]
[Obsolete("Types with embedded references are not supported in this version of your compiler.", True)]
[Token(Token = "0x20001B3")]
internal struct ValueListBuilder
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AB")]
	private Span<T> _span; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AC")]
	private T[] _arrayFromPool; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40006AD")]
	private int _pos; //Field offset: 0x0

	[Token(Token = "0x170001FF")]
	public T Item
	{
		[Address(RVA = "0x86D460", Offset = "0x86C660", Length = "0x1D")]
		[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
		[CalledBy(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A90")]
		 get { } //Length: 29
	}

	[Token(Token = "0x170001FE")]
	public int Length
	{
		[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000A8F")]
		 get { } //Length: 4
	}

	[Address(RVA = "0x86D450", Offset = "0x86C650", Length = "0x10")]
	[CallerCount(Count = 11)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8E")]
	public ValueListBuilder`1(Span<T> initialSpan) { }

	[Address(RVA = "0x86C410", Offset = "0x86B610", Length = "0x8A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A91")]
	public void Append(T item) { }

	[Address(RVA = "0x86C850", Offset = "0x86BA50", Length = "0xD9")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
	[Calls(Type = typeof(Span`1), Member = "op_Implicit", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Span`1<T>"}, ReturnType = "System.ReadOnlySpan`1<T>")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A92")]
	public ReadOnlySpan<T> AsSpan() { }

	[Address(RVA = "0x86CA20", Offset = "0x86BC20", Length = "0xBD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800300C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A93")]
	public void Dispose() { }

	[Address(RVA = "0x86D460", Offset = "0x86C660", Length = "0x1D")]
	[CalledBy(Type = typeof(RegexWriter), Member = "RegexCodeFromRegexTree", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RegexTree)}, ReturnType = typeof(RegexCode))]
	[CalledBy(Type = typeof(RegexWriter), Member = "PatchJump", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RegexWriter), Member = "EmitFragment", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(RegexNode), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A90")]
	public T get_Item(int index) { }

	[Address(RVA = "0x2F6C00", Offset = "0x2F5E00", Length = "0x4")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A8F")]
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
	[Token(Token = "0x6000A94")]
	private void Grow() { }

	[Address(RVA = "0x86D320", Offset = "0x86C520", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x6000A95")]
	public T Pop() { }

}

