namespace System;

[Token(Token = "0x20001D8")]
internal struct Variant
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000931")]
	public short vt; //Field offset: 0x0
	[FieldOffset(Offset = "0x2")]
	[Token(Token = "0x4000932")]
	public ushort wReserved1; //Field offset: 0x2
	[FieldOffset(Offset = "0x4")]
	[Token(Token = "0x4000933")]
	public ushort wReserved2; //Field offset: 0x4
	[FieldOffset(Offset = "0x6")]
	[Token(Token = "0x4000934")]
	public ushort wReserved3; //Field offset: 0x6
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000942")]
	public uint uintVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000941")]
	public int intVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000940")]
	public ulong ullVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093F")]
	public uint ulVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093E")]
	public ushort uiVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093D")]
	public sbyte cVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093C")]
	public IntPtr bstrVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093A")]
	public double dblVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000943")]
	public IntPtr pdispVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000939")]
	public float fltVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000938")]
	public short iVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000937")]
	public byte bVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000936")]
	public int lVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000935")]
	public long llVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x400093B")]
	public short boolVal; //Field offset: 0x8
	[FieldOffset(Offset = "0x8")]
	[Token(Token = "0x4000944")]
	public BRECORD bRecord; //Field offset: 0x8

	[Address(RVA = "0x151F260", Offset = "0x151E460", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Marshal), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(Marshal), Member = "FreeBSTR", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(void))]
	[Token(Token = "0x6001062")]
	public void Clear() { }

}

