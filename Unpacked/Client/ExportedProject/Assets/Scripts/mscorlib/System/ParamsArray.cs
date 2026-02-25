namespace System;

[DefaultMember("Item")]
[IsReadOnly]
[Token(Token = "0x2000123")]
internal struct ParamsArray
{
	[Token(Token = "0x400044D")]
	private static readonly Object[] s_oneArgArray; //Field offset: 0x0
	[Token(Token = "0x400044E")]
	private static readonly Object[] s_twoArgArray; //Field offset: 0x8
	[Token(Token = "0x400044F")]
	private static readonly Object[] s_threeArgArray; //Field offset: 0x10
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000450")]
	private readonly object _arg0; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000451")]
	private readonly object _arg1; //Field offset: 0x8
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000452")]
	private readonly object _arg2; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000453")]
	private readonly Object[] _args; //Field offset: 0x18

	[Token(Token = "0x1700009D")]
	public object Item
	{
		[Address(RVA = "0x14BC1C0", Offset = "0x14BB3C0", Length = "0xA4")]
		[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000930")]
		 get { } //Length: 164
	}

	[Token(Token = "0x1700009C")]
	public int Length
	{
		[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
		[CallerCount(Count = 55)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x600092F")]
		 get { } //Length: 26
	}

	[Address(RVA = "0x14BBDF0", Offset = "0x14BAFF0", Length = "0xE2")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000932")]
	private static ParamsArray() { }

	[Address(RVA = "0x14BBFB0", Offset = "0x14BB1B0", Length = "0x99")]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600092B")]
	public ParamsArray(object arg0) { }

	[Address(RVA = "0x14BC110", Offset = "0x14BB310", Length = "0xAB")]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600092C")]
	public ParamsArray(object arg0, object arg1) { }

	[Address(RVA = "0x14BC050", Offset = "0x14BB250", Length = "0xB5")]
	[CalledBy(Type = typeof(KeyPairPersistence), Member = "get_Filename", ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600092D")]
	public ParamsArray(object arg0, object arg1, object arg2) { }

	[Address(RVA = "0x14BBEE0", Offset = "0x14BB0E0", Length = "0xC5")]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600092E")]
	public ParamsArray(Object[] args) { }

	[Address(RVA = "0x14BC1C0", Offset = "0x14BB3C0", Length = "0xA4")]
	[CalledBy(Type = typeof(StringBuilder), Member = "AppendFormatHelper", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IFormatProvider), typeof(string), typeof(ParamsArray)}, ReturnType = typeof(StringBuilder))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000930")]
	public object get_Item(int index) { }

	[Address(RVA = "0x3B6AD0", Offset = "0x3B5CD0", Length = "0x1A")]
	[CallerCount(Count = 55)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600092F")]
	public int get_Length() { }

	[Address(RVA = "0x14BBDA0", Offset = "0x14BAFA0", Length = "0x47")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000931")]
	private object GetAtSlow(int index) { }

}

