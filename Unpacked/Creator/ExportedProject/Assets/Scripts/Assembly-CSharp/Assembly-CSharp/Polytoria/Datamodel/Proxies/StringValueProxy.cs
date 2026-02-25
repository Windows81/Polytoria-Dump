namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003C2")]
public class StringValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400100C")]
	private readonly StringValue stringValue; //Field offset: 0x20

	[Token(Token = "0x17000C53")]
	public string Value
	{
		[Address(RVA = "0x4ACD70", Offset = "0x4ABF70", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028ED")]
		 get { } //Length: 30
		[Address(RVA = "0x4ACD90", Offset = "0x4ABF90", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(StringValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60028EE")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60028EC")]
	public StringValueProxy(StringValue target) { }

	[Address(RVA = "0x4ACD70", Offset = "0x4ABF70", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028ED")]
	public string get_Value() { }

	[Address(RVA = "0x4ACD90", Offset = "0x4ABF90", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(StringValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60028EE")]
	public void set_Value(string value) { }

}

