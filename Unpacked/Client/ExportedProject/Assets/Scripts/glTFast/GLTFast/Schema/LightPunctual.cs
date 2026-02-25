namespace GLTFast.Schema;

[Token(Token = "0x200009A")]
public class LightPunctual : NamedObject
{
	[Token(Token = "0x200009B")]
	internal enum Type
	{
		Unknown = 0,
		Spot = 1,
		Directional = 2,
		Point = 3,
	}

	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use LightColor for access.")]
	[Token(Token = "0x4000254")]
	public Single[] color; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000255")]
	public float intensity; //Field offset: 0x20
	[FieldOffset(Offset = "0x24")]
	[Token(Token = "0x4000256")]
	public float range; //Field offset: 0x24
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000257")]
	public SpotLight spot; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Obsolete("Use GetLightType and SetLightType for access.")]
	[Token(Token = "0x4000258")]
	public string type; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000259")]
	private Type m_TypeEnum; //Field offset: 0x38

	[Token(Token = "0x17000046")]
	public Color LightColor
	{
		[Address(RVA = "0x1075F10", Offset = "0x1075110", Length = "0x57")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001E3")]
		 get { } //Length: 87
	}

	[Address(RVA = "0x1075E80", Offset = "0x1075080", Length = "0x8D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(RuntimeFieldHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60001E5")]
	public LightPunctual() { }

	[Address(RVA = "0x1075F10", Offset = "0x1075110", Length = "0x57")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001E3")]
	public Color get_LightColor() { }

	[Address(RVA = "0x1075DF0", Offset = "0x1074FF0", Length = "0x88")]
	[CalledBy(Type = typeof(GameObjectInstantiator), Member = "AddLightPunctual", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(LightPunctualExtension), Member = "ToUnityLight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(LightPunctual), typeof(Light), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x60001E4")]
	public Type GetLightType() { }

}

