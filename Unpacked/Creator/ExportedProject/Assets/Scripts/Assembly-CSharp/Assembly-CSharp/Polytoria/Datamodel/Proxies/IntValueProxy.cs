namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003A9")]
public class IntValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FF3")]
	private readonly IntValue intValue; //Field offset: 0x20

	[Token(Token = "0x17000BB1")]
	public int Value
	{
		[Address(RVA = "0x4A5880", Offset = "0x4A4A80", Length = "0x1D")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002777")]
		 get { } //Length: 29
		[Address(RVA = "0x4A58A0", Offset = "0x4A4AA0", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(IntValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002778")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x6002776")]
	public IntValueProxy(IntValue target) { }

	[Address(RVA = "0x4A5880", Offset = "0x4A4A80", Length = "0x1D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002777")]
	public int get_Value() { }

	[Address(RVA = "0x4A58A0", Offset = "0x4A4AA0", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(IntValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002778")]
	public void set_Value(int value) { }

}

