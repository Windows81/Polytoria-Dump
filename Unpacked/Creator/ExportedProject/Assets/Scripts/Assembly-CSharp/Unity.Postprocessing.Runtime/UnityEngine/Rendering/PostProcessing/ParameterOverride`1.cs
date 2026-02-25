namespace UnityEngine.Rendering.PostProcessing;

[Token(Token = "0x2000050")]
public class ParameterOverride : ParameterOverride
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000159")]
	public T value; //Field offset: 0x0

	[Address(RVA = "0xE66600", Offset = "0xE65800", Length = "0x1E")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C3")]
	public ParameterOverride`1() { }

	[Address(RVA = "0xE66940", Offset = "0xE65B40", Length = "0x29")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C4")]
	public ParameterOverride`1(T value) { }

	[Address(RVA = "0xE66850", Offset = "0xE65A50", Length = "0x37")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C5")]
	public ParameterOverride`1(T value, bool overrideState) { }

	[Address(RVA = "0xE650F0", Offset = "0xE642F0", Length = "0x6A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(bool), Member = "GetHashCode", ReturnType = typeof(int))]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CA")]
	public virtual int GetHash() { }

	[Address(RVA = "0xE65A40", Offset = "0xE64C40", Length = "0xAA")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParameterOverride), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C6")]
	internal virtual void Interp(ParameterOverride from, ParameterOverride to, float t) { }

	[Address(RVA = "0xE65B60", Offset = "0xE64D60", Length = "0x28")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C7")]
	public override void Interp(T from, T to, float t) { }

	[Address(RVA = "0xE66C50", Offset = "0xE65E50", Length = "0x17")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000CB")]
	public static T op_Implicit(ParameterOverride<T> prop) { }

	[Address(RVA = "0xE66060", Offset = "0xE65260", Length = "0x8")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C8")]
	public void Override(T x) { }

	[Address(RVA = "0xE66090", Offset = "0xE65290", Length = "0x36")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ParameterOverride), Member = "GetValue", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x60000C9")]
	internal virtual void SetValue(ParameterOverride parameter) { }

}

