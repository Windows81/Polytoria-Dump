namespace GLTFast.Schema;

[Token(Token = "0x2000093")]
public abstract class CameraBase : NamedObject
{
	[Token(Token = "0x2000094")]
	internal enum Type
	{
		Orthographic = 0,
		Perspective = 1,
	}

	[FieldOffset(Offset = "0x18")]
	[Obsolete("Use GetCameraType and SetCameraType for access.")]
	[Token(Token = "0x400023F")]
	public string type; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000240")]
	private Nullable<Type> m_TypeEnum; //Field offset: 0x20

	[Token(Token = "0x17000041")]
	public abstract CameraOrthographic Orthographic
	{
		[Token(Token = "0x60001DA")]
		 get { } //Length: 0
	}

	[Token(Token = "0x17000042")]
	public abstract CameraPerspective Perspective
	{
		[Token(Token = "0x60001DB")]
		 get { } //Length: 0
	}

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001DC")]
	protected CameraBase() { }

	[Token(Token = "0x60001DA")]
	public abstract CameraOrthographic get_Orthographic() { }

	[Token(Token = "0x60001DB")]
	public abstract CameraPerspective get_Perspective() { }

	[Address(RVA = "0x1075750", Offset = "0x1074950", Length = "0x198")]
	[CalledBy(Type = typeof(GameObjectInstantiator), Member = "AddCamera", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(uint), typeof(uint)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Enum), Member = "TryParse", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"System.Int32Enum"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(bool), typeof(Int32Enum&)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Nullable`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Nullable`1), Member = "get_Value", ReturnType = "T")]
	[CallsUnknownMethods(Count = 2)]
	[Token(Token = "0x60001D9")]
	public Type GetCameraType() { }

}

