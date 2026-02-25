namespace Polytoria.Datamodel.Proxies;

[Token(Token = "0x20003B1")]
public class NumberValueProxy : ValueBaseProxy
{
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000FFB")]
	private readonly NumberValue numberValue; //Field offset: 0x20

	[Token(Token = "0x17000BD3")]
	public float Value
	{
		[Address(RVA = "0x4A6350", Offset = "0x4A5550", Length = "0x1F")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[DeduplicatedMethod]
		[Token(Token = "0x60027C9")]
		 get { } //Length: 31
		[Address(RVA = "0x4A6370", Offset = "0x4A5570", Length = "0x1E")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(NumberValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x60027CA")]
		 set { } //Length: 30
	}

	[Address(RVA = "0x4A11B0", Offset = "0x4A03B0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[MoonSharpHidden]
	[Token(Token = "0x60027C8")]
	public NumberValueProxy(NumberValue target) { }

	[Address(RVA = "0x4A6350", Offset = "0x4A5550", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60027C9")]
	public float get_Value() { }

	[Address(RVA = "0x4A6370", Offset = "0x4A5570", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberValue), Member = "set_Value", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x60027CA")]
	public void set_Value(float value) { }

}

