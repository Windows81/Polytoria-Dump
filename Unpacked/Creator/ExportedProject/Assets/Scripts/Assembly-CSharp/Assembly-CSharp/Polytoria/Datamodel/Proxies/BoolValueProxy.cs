namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x200039A")]
public class BoolValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FE4")]
	private readonly BoolValue boolValue; //Field offset: 0x20

	[Token(Token = "0x17000B59")]
	public bool Value
	{
		[Address(RVA = "0x4A1210", Offset = "0x4A0410", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026AD")]
		 get { } //Length: 30
		[Address(RVA = "0x4A1230", Offset = "0x4A0430", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BoolValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60026AE")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60026AC")]
	public BoolValueProxy(BoolValue target) { }

	[Address(RVA = "0x4A1210", Offset = "0x4A0410", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026AD")]
	public bool get_Value() { }

	[Address(RVA = "0x4A1230", Offset = "0x4A0430", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BoolValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60026AE")]
	public void set_Value(bool value) { }

}

