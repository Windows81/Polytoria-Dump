namespace GLTFast.Schema;

[Token(Token = "0x2000092")]
public abstract class CameraBase : CameraBase
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023D")]
	public TOrthographic orthographic; //Field offset: 0x0
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x400023E")]
	public TPerspective perspective; //Field offset: 0x0

	[Token(Token = "0x1700003F")]
	public virtual CameraOrthographic Orthographic
	{
		[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
		[CallerCount(Count = 16)]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D6")]
		 get { } //Length: 5
	}

	[Token(Token = "0x17000040")]
	public virtual CameraPerspective Perspective
	{
		[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
		[CallerCount(Count = 27)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[DeduplicatedMethod]
		[Token(Token = "0x60001D7")]
		 get { } //Length: 95
	}

	[Address(RVA = "0x2FF940", Offset = "0x2FEB40", Length = "0x7")]
	[CallerCount(Count = 83)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D8")]
	protected CameraBase`2() { }

	[Address(RVA = "0x2F5BE0", Offset = "0x2F4DE0", Length = "0x5")]
	[CallerCount(Count = 16)]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D6")]
	public virtual CameraOrthographic get_Orthographic() { }

	[Address(RVA = "0x2F5BF0", Offset = "0x2F4DF0", Length = "0x5F")]
	[CallerCount(Count = 27)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[DeduplicatedMethod]
	[Token(Token = "0x60001D7")]
	public virtual CameraPerspective get_Perspective() { }

}

