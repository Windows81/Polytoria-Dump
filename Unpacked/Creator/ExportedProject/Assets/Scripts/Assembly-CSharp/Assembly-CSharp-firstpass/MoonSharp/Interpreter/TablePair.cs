namespace MoonSharp.Interpreter;

[Token(Token = "0x2000054")]
public struct TablePair
{
	[Token(Token = "0x40001FE")]
	private static TablePair s_NilNode; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x40001FF")]
	private DynValue key; //Field offset: 0x0
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000200")]
	private DynValue value; //Field offset: 0x8

	[Token(Token = "0x170000B4")]
	public private DynValue Key
	{
		[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
		[CallerCount(Count = 140)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000576")]
		 get { } //Length: 4
		[Address(RVA = "0x310540", Offset = "0x30F740", Length = "0x37")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000577")]
		private set { } //Length: 55
	}

	[Token(Token = "0x170000B6")]
	public static TablePair Nil
	{
		[Address(RVA = "0x3104D0", Offset = "0x30F6D0", Length = "0x5A")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x600057B")]
		 get { } //Length: 90
	}

	[Token(Token = "0x170000B5")]
	public DynValue Value
	{
		[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000578")]
		 get { } //Length: 5
		[Address(RVA = "0x310580", Offset = "0x30F780", Length = "0x62")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6000579")]
		 set { } //Length: 98
	}

	[Address(RVA = "0x310350", Offset = "0x30F550", Length = "0x138")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x600057C")]
	private static TablePair() { }

	[Address(RVA = "0x310490", Offset = "0x30F690", Length = "0x32")]
	[CallerCount(Count = 48)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[DeduplicatedMethod]
	[Token(Token = "0x600057A")]
	public TablePair(DynValue key, DynValue val) { }

	[Address(RVA = "0x2F5C60", Offset = "0x2F4E60", Length = "0x4")]
	[CallerCount(Count = 140)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000576")]
	public DynValue get_Key() { }

	[Address(RVA = "0x3104D0", Offset = "0x30F6D0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x600057B")]
	public static TablePair get_Nil() { }

	[Address(RVA = "0x310530", Offset = "0x30F730", Length = "0x5")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000578")]
	public DynValue get_Value() { }

	[Address(RVA = "0x310540", Offset = "0x30F740", Length = "0x37")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000577")]
	private void set_Key(DynValue value) { }

	[Address(RVA = "0x310580", Offset = "0x30F780", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000579")]
	public void set_Value(DynValue value) { }

}

