namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Class (4), AllowMultiple = False)]
[Token(Token = "0x2000008")]
public sealed class PostProcessAttribute : Attribute
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400000B")]
	public readonly Type renderer; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400000C")]
	public readonly PostProcessEvent eventType; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x400000D")]
	public readonly string menuItem; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x400000E")]
	public readonly bool allowInSceneView; //Field offset: 0x28
	[FieldOffset(Offset = "0x29")]
	[Token(Token = "0x400000F")]
	internal readonly bool builtinEffect; //Field offset: 0x29

	[Address(RVA = "0x1839010", Offset = "0x1838210", Length = "0x6B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000007")]
	public PostProcessAttribute(Type renderer, PostProcessEvent eventType, string menuItem, bool allowInSceneView = true) { }

	[Address(RVA = "0x1838FA0", Offset = "0x18381A0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000008")]
	internal PostProcessAttribute(Type renderer, string menuItem, bool allowInSceneView = true) { }

}

