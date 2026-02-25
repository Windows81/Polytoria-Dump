namespace UnityEngine.UI;

[Token(Token = "0x2000081")]
public class VertexHelper : IDisposable
{
	[Token(Token = "0x400026D")]
	private static readonly Vector4 s_DefaultTangent; //Field offset: 0x0
	[Token(Token = "0x400026E")]
	private static readonly Vector3 s_DefaultNormal; //Field offset: 0x10
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000264")]
	private List<Vector3> m_Positions; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x4000265")]
	private List<Color32> m_Colors; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x4000266")]
	private List<Vector4> m_Uv0S; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x4000267")]
	private List<Vector4> m_Uv1S; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x4000268")]
	private List<Vector4> m_Uv2S; //Field offset: 0x30
	[FieldOffset(Offset = "0x38")]
	[Token(Token = "0x4000269")]
	private List<Vector4> m_Uv3S; //Field offset: 0x38
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x400026A")]
	private List<Vector3> m_Normals; //Field offset: 0x40
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x400026B")]
	private List<Vector4> m_Tangents; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x400026C")]
	private List<Int32> m_Indices; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x400026F")]
	private bool m_ListsInitalized; //Field offset: 0x58

	[Token(Token = "0x17000154")]
	public int currentIndexCount
	{
		[Address(RVA = "0x1CDE8E0", Offset = "0x1CDDAE0", Length = "0x41")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Token(Token = "0x6000525")]
		 get { } //Length: 65
	}

	[Token(Token = "0x17000153")]
	public int currentVertCount
	{
		[Address(RVA = "0x1CDE930", Offset = "0x1CDDB30", Length = "0x2CF")]
		[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "EncodeAllInfoIntoVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), "UnityEngine.UI.ProceduralImage.ProceduralImageInfo"}, ReturnType = typeof(void))]
		[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
		[CallerCount(Count = 5)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Token(Token = "0x6000524")]
		 get { } //Length: 719
	}

	[Address(RVA = "0x1CDE610", Offset = "0x1CDD810", Length = "0x88")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000532")]
	private static VertexHelper() { }

	[Address(RVA = "0x2BC7B0", Offset = "0x2BB9B0", Length = "0x7")]
	[CallerCount(Count = 2609)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600051F")]
	public VertexHelper() { }

	[Address(RVA = "0x1CDE6A0", Offset = "0x1CDD8A0", Length = "0x239")]
	[CalledBy(Type = typeof(BaseMeshEffect), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_tangents", ReturnType = typeof(Vector4[]))]
	[Calls(Type = typeof(Mesh), Member = "get_normals", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "GetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(Mesh), Member = "get_colors32", ReturnType = typeof(Color32[]))]
	[Calls(Type = typeof(Mesh), Member = "GetIndices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(Int32[]))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "get_vertices", ReturnType = typeof(Vector3[]))]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 2)]
	[Token(Token = "0x6000520")]
	public VertexHelper(Mesh m) { }

	[Address(RVA = "0x1CDCCB0", Offset = "0x1CDBEB0", Length = "0x166")]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 17)]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x600052D")]
	public void AddTriangle(int idx0, int idx1, int idx2) { }

	[Address(RVA = "0x1CDCE20", Offset = "0x1CDC020", Length = "0x283")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateCaret", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x600052E")]
	public void AddUIVertexQuad(UIVertex[] verts) { }

	[Address(RVA = "0x1CDD0B0", Offset = "0x1CDC2B0", Length = "0xBF")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Int32>), Member = "AddRange", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.IEnumerable`1<System.Int32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x600052F")]
	public void AddUIVertexStream(List<UIVertex> verts, List<Int32> indices) { }

	[Address(RVA = "0x1CDD170", Offset = "0x1CDC370", Length = "0x7A")]
	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(CanvasRenderer), Member = "SplitUIVertexStreams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Color32>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000530")]
	public void AddUIVertexTriangleStream(List<UIVertex> verts) { }

	[Address(RVA = "0x1CDD600", Offset = "0x1CDC800", Length = "0x43D")]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex[])}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector4)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Token(Token = "0x6000529")]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector4 uv2, Vector4 uv3, Vector3 normal, Vector4 tangent) { }

	[Address(RVA = "0x1CDD550", Offset = "0x1CDC750", Length = "0xA8")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[Token(Token = "0x600052C")]
	public void AddVert(UIVertex v) { }

	[Address(RVA = "0x1CDD3E0", Offset = "0x1CDC5E0", Length = "0x167")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[Token(Token = "0x600052A")]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0, Vector4 uv1, Vector3 normal, Vector4 tangent) { }

	[Address(RVA = "0x1CDD1F0", Offset = "0x1CDC3F0", Length = "0x1EF")]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 18)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[Token(Token = "0x600052B")]
	public void AddVert(Vector3 position, Color32 color, Vector4 uv0) { }

	[Address(RVA = "0x1CDDA40", Offset = "0x1CDCC40", Length = "0xEB")]
	[CalledBy(Type = typeof(Image), Member = "GenerateFilledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSimpleSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(RawImage), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Text), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SimpleFileBrowser.NonDrawingGraphic", Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000523")]
	public void Clear() { }

	[Address(RVA = "0x1CDDB30", Offset = "0x1CDCD30", Length = "0x210")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Release", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"TCollection"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Token(Token = "0x6000522")]
	public override void Dispose() { }

	[Address(RVA = "0x1CDDD40", Offset = "0x1CDCF40", Length = "0x15F")]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "DoMeshGeneration", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Graphic), Member = "OnPopulateMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "LateUpdate", ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "OnFillVBO", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CallerCount(Count = 7)]
	[Calls(Type = typeof(Mesh), Member = "SetVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(Mesh), Member = "RecalculateBounds", ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTriangles", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<System.Int32>), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetTangents", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(Mesh), Member = "SetUVs", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(System.Collections.Generic.List`1<UnityEngine.Vector4>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "SetColors", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Color32>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Mesh), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Mesh), Member = "SetNormals", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.Vector3>)}, ReturnType = typeof(void))]
	[Token(Token = "0x6000528")]
	public void FillMesh(Mesh mesh) { }

	[Address(RVA = "0x1CDE8E0", Offset = "0x1CDDAE0", Length = "0x41")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000525")]
	public int get_currentIndexCount() { }

	[Address(RVA = "0x1CDE930", Offset = "0x1CDDB30", Length = "0x2CF")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "EncodeAllInfoIntoVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), "UnityEngine.UI.ProceduralImage.ProceduralImageInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = "TMPro.TMP_InputField", Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector3[]), typeof(Color32), typeof(Vector3[])}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Image), Member = "AddQuad", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2), typeof(Vector2), typeof(Color32), typeof(Vector2), typeof(Vector2)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(InputField), Member = "GenerateHighlight", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), typeof(Vector2)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000524")]
	public int get_currentVertCount() { }

	[Address(RVA = "0x1CDDEA0", Offset = "0x1CDD0A0", Length = "0x7A")]
	[CalledBy(Type = typeof(Shadow), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000531")]
	public void GetUIVertexStream(List<UIVertex> stream) { }

	[Address(RVA = "0x1CDDF20", Offset = "0x1CDD120", Length = "0x1DD")]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexTriangleStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "PopulateUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex&), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "SetUIVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UIVertex), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "FillMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddVert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector3), typeof(Color32), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector4), typeof(Vector3), typeof(Vector4)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddTriangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "AddUIVertexStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>), typeof(System.Collections.Generic.List`1<System.Int32>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(VertexHelper), Member = "GetUIVertexStream", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<UnityEngine.UIVertex>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(BaseMeshEffect), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Mesh)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(Outline), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CollectionPool`2), Member = "Get", ReturnType = "TCollection")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Token(Token = "0x6000521")]
	private void InitializeListIfRequired() { }

	[Address(RVA = "0x1CDE100", Offset = "0x1CDD300", Length = "0x1B8")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "EncodeAllInfoIntoVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), "UnityEngine.UI.ProceduralImage.ProceduralImageInfo"}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000526")]
	public void PopulateUIVertex(ref UIVertex vertex, int i) { }

	[Address(RVA = "0x1CDE2C0", Offset = "0x1CDD4C0", Length = "0x346")]
	[CalledBy(Type = "UnityEngine.UI.ProceduralImage.ProceduralImage", Member = "EncodeAllInfoIntoVertices", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper), "UnityEngine.UI.ProceduralImage.ProceduralImageInfo"}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(PositionAsUV1), Member = "ModifyMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(VertexHelper)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VertexHelper), Member = "InitializeListIfRequired", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000527")]
	public void SetUIVertex(UIVertex vertex, int i) { }

}

