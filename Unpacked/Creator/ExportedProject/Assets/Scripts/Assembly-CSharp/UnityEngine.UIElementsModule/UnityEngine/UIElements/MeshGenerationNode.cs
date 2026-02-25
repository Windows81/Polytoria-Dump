namespace UnityEngine.UIElements;

[NativeContainer]
[Token(Token = "0x20002CA")]
public struct MeshGenerationNode
{
	[FieldOffset(Offset = "0x0")]
	[Token(Token = "0x4000B54")]
	private UnsafeMeshGenerationNode m_UnsafeNode; //Field offset: 0x0

	[Address(RVA = "0x1C890F0", Offset = "0x1C882F0", Length = "0x4")]
	[CallerCount(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600136C")]
	internal static void Create(GCHandle handle, out MeshGenerationNode node) { }

	[Address(RVA = "0x1C89100", Offset = "0x1C88300", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x600136D")]
	internal Entry GetParentEntry() { }

}

