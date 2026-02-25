namespace RLD;

[DefaultMember("Item")]
[Token(Token = "0x20001D0")]
public class MeshVertexChunkCollection : IEnumerable<MeshVertexChunk>, IEnumerable
{
	[Token(Token = "0x20001D1")]
	private struct VertexChunkIndices
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x400072F")]
		private int _XIndex; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000730")]
		private int _YIndex; //Field offset: 0x4
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4000731")]
		private int _ZIndex; //Field offset: 0x8

		[Token(Token = "0x170005C5")]
		public int XIndex
		{
			[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
			[CallerCount(Count = 129)]
			[DeduplicatedMethod]
			[Token(Token = "0x600124B")]
			 get { } //Length: 3
		}

		[Token(Token = "0x170005C6")]
		public int YIndex
		{
			[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
			[CallerCount(Count = 1)]
			[DeduplicatedMethod]
			[Token(Token = "0x600124C")]
			 get { } //Length: 4
		}

		[Token(Token = "0x170005C7")]
		public int ZIndex
		{
			[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
			[CallerCount(Count = 5)]
			[DeduplicatedMethod]
			[Token(Token = "0x600124D")]
			 get { } //Length: 4
		}

		[Address(RVA = "0x58D8C0", Offset = "0x58CAC0", Length = "0xB")]
		[CallerCount(Count = 4)]
		[DeduplicatedMethod]
		[Token(Token = "0x600124E")]
		public VertexChunkIndices(int xIndex, int yIndex, int zIndex) { }

		[Address(RVA = "0x344910", Offset = "0x343B10", Length = "0x3")]
		[CallerCount(Count = 129)]
		[DeduplicatedMethod]
		[Token(Token = "0x600124B")]
		public int get_XIndex() { }

		[Address(RVA = "0x3B87A0", Offset = "0x3B79A0", Length = "0x4")]
		[CallerCount(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600124C")]
		public int get_YIndex() { }

		[Address(RVA = "0x3B9430", Offset = "0x3B8630", Length = "0x4")]
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
		[Token(Token = "0x600124D")]
		public int get_ZIndex() { }

	}

	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x400072D")]
	private Mesh _mesh; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x400072E")]
	private List<MeshVertexChunk> _vertexChunks; //Field offset: 0x18

	[Token(Token = "0x170005C4")]
	public int Count
	{
		[Address(RVA = "0x576660", Offset = "0x575860", Length = "0x3C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6001244")]
		 get { } //Length: 60
	}

	[Token(Token = "0x170005C3")]
	public MeshVertexChunk Item
	{
		[Address(RVA = "0x5766A0", Offset = "0x5758A0", Length = "0x51")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6001243")]
		 get { } //Length: 81
	}

	[Address(RVA = "0x5765E0", Offset = "0x5757E0", Length = "0x7C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600124A")]
	public MeshVertexChunkCollection() { }

	[Address(RVA = "0x575860", Offset = "0x574A60", Length = "0x692")]
	[CalledBy(Type = typeof(MeshVertexChunkCollectionDb), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(MeshVertexChunkCollection))]
	[CalledBy(Type = typeof(MeshVertexChunkCollectionDb), Member = "CreateMeshVertChunkCollection", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<RLD.MeshVertexChunkCollection+VertexChunkIndices, System.Object>), Member = "ContainsKey", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexChunkIndices)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshVertexChunk), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(Mesh)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Dictionary`2), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.Dictionary`2<TKey, TValue>+Enumerator<TKey, TValue>")]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(Dictionary`2), Member = "get_Count", ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001EA0")]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<RLD.MeshVertexChunkCollection+VertexChunkIndices, System.Object>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexChunkIndices)}, ReturnType = typeof(object))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<RLD.MeshVertexChunkCollection+VertexChunkIndices, System.Object>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexChunkIndices), typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.Dictionary`2<RLD.MeshVertexChunkCollection+VertexChunkIndices, System.Object>), Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802897E0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(Mesh), Member = "get_bounds", ReturnType = typeof(Bounds))]
	[Calls(Type = typeof(Mesh), Member = "get_isReadable", ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[CallsDeduplicatedMethods(Count = 2)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001249")]
	public bool FromMesh(Mesh mesh) { }

	[Address(RVA = "0x576660", Offset = "0x575860", Length = "0x3C")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6001244")]
	public int get_Count() { }

	[Address(RVA = "0x5766A0", Offset = "0x5758A0", Length = "0x51")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6001243")]
	public MeshVertexChunk get_Item(int chunkIndex) { }

	[Address(RVA = "0x575F00", Offset = "0x575100", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001245")]
	public override IEnumerator<MeshVertexChunk> GetEnumerator() { }

	[Address(RVA = "0x575F80", Offset = "0x575180", Length = "0x307")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AABB), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "GetScreenRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(Rect))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001E30")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6001247")]
	public List<MeshVertexChunk> GetWorldChunksHoveredByPoint(Vector3 hoverPoint, Matrix4x4 worldMtx, Camera camera) { }

	[Address(RVA = "0x576290", Offset = "0x575490", Length = "0x343")]
	[CalledBy(Type = typeof(GizmoObjectVertexSnapDrag3D), Member = "GetWorldPointClosestToInputDevice", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera), typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.GameObject>), typeof(Vector3&)}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<System.Object>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(AABB), Member = "Transform", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Matrix4x4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(AABB), Member = "GetScreenCenterAndCornerPoints", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Camera)}, ReturnType = typeof(System.Collections.Generic.List`1<UnityEngine.Vector2>))]
	[Calls(Type = typeof(System.Collections.Generic.List`1+Enumerator<UnityEngine.Vector2>), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6001248")]
	public MeshVertexChunk GetWorldVertChunkClosestToScreenPt(Vector2 screenPoint, Matrix4x4 worldMtx, Camera camera) { }

	[Address(RVA = "0x575F00", Offset = "0x575100", Length = "0x7D")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[DeduplicatedMethod]
	[Token(Token = "0x6001246")]
	private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

