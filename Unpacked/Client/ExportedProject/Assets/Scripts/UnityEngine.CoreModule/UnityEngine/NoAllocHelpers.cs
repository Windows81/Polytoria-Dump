namespace UnityEngine;

[Token(Token = "0x2000152")]
[VisibleToOtherModules]
internal static class NoAllocHelpers
{
	[Token(Token = "0x2000153")]
	private class ListPrivateFieldAccess
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056D")]
		internal T[] _items; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056E")]
		internal int _size; //Field offset: 0x0
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400056F")]
		internal int _version; //Field offset: 0x0

	}


	[Address(RVA = "0x71C0E0", Offset = "0x71B2E0", Length = "0x109")]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"System.Collections.Generic.List`1<T>", typeof(int), typeof(VertexAttribute), typeof(int), typeof(VertexAttributeFormat)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "GetUVsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "System.Collections.Generic.List`1<T>", typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(List`1), Member = "set_Capacity", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009DD")]
	public static void EnsureListElemCount(List<T> list, int count) { }

	[Address(RVA = "0x71C1F0", Offset = "0x71B3F0", Length = "0x5A")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E0")]
	public static T[] ExtractArrayFromList(List<T> list) { }

	[Address(RVA = "0x19661D0", Offset = "0x19653D0", Length = "0xD5")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "CreateInstance", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Type), typeof(int)}, ReturnType = typeof(Array))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 2)]
	[RequiredByNativeCode]
	[Token(Token = "0x60009E3")]
	private static Array PrepareListForNativeFill(object list, Type elementType, int newSize) { }

	[Address(RVA = "0x71C350", Offset = "0x71B550", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(System.ReadOnlySpan`1<UnityEngine.RaycastHit2D>), Member = "ToArray", ReturnType = typeof(RaycastHit2D[]))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E1")]
	public static void ResetListContents(List<T> list, ReadOnlySpan<T> span) { }

	[Address(RVA = "0x71C530", Offset = "0x71B730", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002050")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002A250")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[Token(Token = "0x60009E2")]
	public static void ResetListSize(List<T> list, int size) { }

	[Address(RVA = "0x19662B0", Offset = "0x19654B0", Length = "0x1C")]
	[CalledBy(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetArrayForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "T[]", typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUvsImpl", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(Array), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vector4[]), typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "set_triangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Int32[]), typeof(int), typeof(int), typeof(MeshTopology), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x60009DE")]
	public static int SafeLength(Array values) { }

	[Address(RVA = "0x71C650", Offset = "0x71B850", Length = "0x2E")]
	[CalledBy(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), typeof(VertexAttributeFormat), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetListForChannel", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexAttribute), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUvsImpl", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), "System.Collections.Generic.List`1<T>", typeof(int), typeof(int), typeof(MeshUpdateFlags)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int), typeof(int), typeof(int), typeof(bool), typeof(int)}, ReturnType = typeof(void))]
	[CallerCount(Count = 14)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[DeduplicatedMethod]
	[Token(Token = "0x60009DF")]
	public static int SafeLength(List<T> values) { }

}

