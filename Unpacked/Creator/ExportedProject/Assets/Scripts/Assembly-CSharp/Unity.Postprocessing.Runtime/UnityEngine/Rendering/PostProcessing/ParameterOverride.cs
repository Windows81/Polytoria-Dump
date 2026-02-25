namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x200004F")]
public abstract class ParameterOverride
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000158")]
	public bool overrideState; //Field offset: 0x10

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C2")]
	protected ParameterOverride() { }

	[Token(Token = "0x60000BD")]
	public abstract int GetHash() { }

	[Address(RVA = "0x71CFD0", Offset = "0x71C1D0", Length = "0xC8")]
	[CalledBy(Type = typeof(ParameterOverride`1), Member = "Interp", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride), typeof(ParameterOverride), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(ParameterOverride`1), Member = "SetValue", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ParameterOverride)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BE")]
	public T GetValue() { }

	[Token(Token = "0x60000BC")]
	internal abstract void Interp(ParameterOverride from, ParameterOverride to, float t) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C0")]
	protected private override void OnDisable() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000BF")]
	protected private override void OnEnable() { }

	[Token(Token = "0x60000C1")]
	internal abstract void SetValue(ParameterOverride parameter) { }

}

