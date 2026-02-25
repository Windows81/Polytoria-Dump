namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057A")]
internal class MeshGenerator : IMeshGenerator, IDisposable
{
	[Token(Token = "0x200057C")]
	internal struct BackgroundRepeatInstance
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012FD")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012FE")]
		public Rect backgroundRepeatRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x40012FF")]
		public Rect uv; //Field offset: 0x20

	}

	[Token(Token = "0x200057D")]
	internal struct BorderParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001300")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001301")]
		public Color playmodeTintColor; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001302")]
		public Color leftColor; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001303")]
		public Color topColor; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001304")]
		public Color rightColor; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001305")]
		public Color bottomColor; //Field offset: 0x50
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4001306")]
		public float leftWidth; //Field offset: 0x60
		[FieldOffset(Offset = "0x64")]
		[Token(Token = "0x4001307")]
		public float topWidth; //Field offset: 0x64
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4001308")]
		public float rightWidth; //Field offset: 0x68
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x4001309")]
		public float bottomWidth; //Field offset: 0x6C
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x400130A")]
		public Vector2 topLeftRadius; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400130B")]
		public Vector2 topRightRadius; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400130C")]
		public Vector2 bottomRightRadius; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x400130D")]
		public Vector2 bottomLeftRadius; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x400130E")]
		internal ColorPage leftColorPage; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400130F")]
		internal ColorPage topColorPage; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4001310")]
		internal ColorPage rightColorPage; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4001311")]
		internal ColorPage bottomColorPage; //Field offset: 0xA8

		[Address(RVA = "0x1B7D610", Offset = "0x1B7C810", Length = "0x11A")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(ColorPage), Member = "ToNativeColorPage", ReturnType = typeof(NativeColorPage))]
		[Token(Token = "0x6002735")]
		internal void ToNativeParams(out NativeBorderParams nativeBorderParams) { }

	}

	[Token(Token = "0x200057E")]
	internal struct RectangleParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001312")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4001313")]
		public Rect uv; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4001314")]
		public Color color; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4001315")]
		public Rect subRect; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4001316")]
		public Rect backgroundRepeatRect; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4001317")]
		public NativePagedList<BackgroundRepeatInstance> backgroundRepeatInstanceList; //Field offset: 0x50
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4001318")]
		public int backgroundRepeatInstanceListStartIndex; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4001319")]
		public int backgroundRepeatInstanceListEndIndex; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x400131A")]
		public BackgroundPosition backgroundPositionX; //Field offset: 0x60
		[FieldOffset(Offset = "0x6C")]
		[Token(Token = "0x400131B")]
		public BackgroundPosition backgroundPositionY; //Field offset: 0x6C
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x400131C")]
		public BackgroundRepeat backgroundRepeat; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x400131D")]
		public BackgroundSize backgroundSize; //Field offset: 0x80
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x400131E")]
		public Texture texture; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x400131F")]
		public Sprite sprite; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4001320")]
		public VectorImage vectorImage; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4001321")]
		public ScaleMode scaleMode; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB4")]
		[Token(Token = "0x4001322")]
		public Color playmodeTintColor; //Field offset: 0xB4
		[FieldOffset(Offset = "0xC4")]
		[Token(Token = "0x4001323")]
		public Vector2 topLeftRadius; //Field offset: 0xC4
		[FieldOffset(Offset = "0xCC")]
		[Token(Token = "0x4001324")]
		public Vector2 topRightRadius; //Field offset: 0xCC
		[FieldOffset(Offset = "0xD4")]
		[Token(Token = "0x4001325")]
		public Vector2 bottomRightRadius; //Field offset: 0xD4
		[FieldOffset(Offset = "0xDC")]
		[Token(Token = "0x4001326")]
		public Vector2 bottomLeftRadius; //Field offset: 0xDC
		[FieldOffset(Offset = "0xE4")]
		[Token(Token = "0x4001327")]
		public Vector2 contentSize; //Field offset: 0xE4
		[FieldOffset(Offset = "0xEC")]
		[Token(Token = "0x4001328")]
		public Vector2 textureSize; //Field offset: 0xEC
		[FieldOffset(Offset = "0xF4")]
		[Token(Token = "0x4001329")]
		public int leftSlice; //Field offset: 0xF4
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x400132A")]
		public int topSlice; //Field offset: 0xF8
		[FieldOffset(Offset = "0xFC")]
		[Token(Token = "0x400132B")]
		public int rightSlice; //Field offset: 0xFC
		[FieldOffset(Offset = "0x100")]
		[Token(Token = "0x400132C")]
		public int bottomSlice; //Field offset: 0x100
		[FieldOffset(Offset = "0x104")]
		[Token(Token = "0x400132D")]
		public float sliceScale; //Field offset: 0x104
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x400132E")]
		internal Rect spriteGeomRect; //Field offset: 0x108
		[FieldOffset(Offset = "0x118")]
		[Token(Token = "0x400132F")]
		public Vector4 rectInset; //Field offset: 0x118
		[FieldOffset(Offset = "0x128")]
		[Token(Token = "0x4001330")]
		internal ColorPage colorPage; //Field offset: 0x128
		[FieldOffset(Offset = "0x130")]
		[Token(Token = "0x4001331")]
		internal MeshFlags meshFlags; //Field offset: 0x130

		[Address(RVA = "0x1B8A410", Offset = "0x1B89610", Length = "0x4DB")]
		[CalledBy(Type = typeof(RectangleParams), Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), typeof(ScaleMode), typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = typeof(RectangleParams))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002737")]
		private static void AdjustSpriteUVsForScaleMode(Rect containerRect, Rect srcRect, Rect spriteGeomRect, Sprite sprite, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		[Address(RVA = "0x1B8A8F0", Offset = "0x1B89AF0", Length = "0x204")]
		[CalledBy(Type = typeof(RectangleParams), Member = "MakeTextured", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Texture), typeof(ScaleMode), typeof(Color)}, ReturnType = typeof(RectangleParams))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x6002736")]
		private static void AdjustUVsForScaleMode(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, out Rect rectOut, out Rect uvOut) { }

		[Address(RVA = "0x1B8AB00", Offset = "0x1B89D00", Length = "0xB4")]
		[CallerCount(Count = 0)]
		[Token(Token = "0x600273B")]
		private static Rect ApplyPackingRotation(Rect uv, SpritePackingRotation rotation) { }

		[Address(RVA = "0x1B8ABC0", Offset = "0x1B89DC0", Length = "0x10C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x6002739")]
		private static Rect ComputeGeomRect(Sprite sprite) { }

		[Address(RVA = "0x1B8ACD0", Offset = "0x1B89ED0", Length = "0x10C")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Token(Token = "0x600273A")]
		private static Rect ComputeUVRect(Sprite sprite) { }

		[Address(RVA = "0x1B8ADE0", Offset = "0x1B89FE0", Length = "0x73")]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600273F")]
		internal bool HasRadius(float epsilon) { }

		[Address(RVA = "0x1B8AE60", Offset = "0x1B8A060", Length = "0x45")]
		[CallerCount(Count = 0)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002740")]
		internal bool HasSlices(float epsilon) { }

		[Address(RVA = "0x1B8AEB0", Offset = "0x1B8A0B0", Length = "0xE66")]
		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
		[Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object), typeof(object), typeof(object)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
		[Calls(Type = typeof(Object), Member = "get_name", ReturnType = typeof(string))]
		[Calls(Type = typeof(Sprite), Member = "get_rect", ReturnType = typeof(Rect))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(RectangleParams), Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), typeof(ScaleMode), typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Sprite), Member = "get_packed", ReturnType = typeof(bool))]
		[Calls(Type = typeof(Sprite), Member = "get_border", ReturnType = typeof(Vector4))]
		[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
		[Calls(Type = typeof(string), Member = "Concat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(string), typeof(string)}, ReturnType = typeof(string))]
		[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
		[Calls(Type = typeof(Sprite), Member = "get_bounds", ReturnType = typeof(Bounds))]
		[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600273D")]
		public static RectangleParams MakeSprite(Rect containerRect, Rect subRect, Sprite sprite, ScaleMode scaleMode, Color playModeTintColor, bool hasRadius, ref Vector4 slices, bool useForRepeat = false) { }

		[Address(RVA = "0x1B8BD20", Offset = "0x1B8AF20", Length = "0x236")]
		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(RectangleParams), Member = "AdjustUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Texture), typeof(ScaleMode), typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 2)]
		[Token(Token = "0x600273C")]
		public static RectangleParams MakeTextured(Rect rect, Rect uv, Texture texture, ScaleMode scaleMode, Color playModeTintColor) { }

		[Address(RVA = "0x1B8BF60", Offset = "0x1B8B160", Length = "0x1BE")]
		[CalledBy(Type = typeof(Image), Member = "OnGenerateVisualContent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Token(Token = "0x600273E")]
		public static RectangleParams MakeVectorTextured(Rect rect, Rect uv, VectorImage vectorImage, ScaleMode scaleMode, Color playModeTintColor) { }

		[Address(RVA = "0x1B8C120", Offset = "0x1B8B320", Length = "0xFC")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Token(Token = "0x6002738")]
		internal static Rect RectIntersection(Rect a, Rect b) { }

		[Address(RVA = "0x1B8C220", Offset = "0x1B8B420", Length = "0x176")]
		[CalledBy(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(ColorPage), Member = "ToNativeColorPage", ReturnType = typeof(NativeColorPage))]
		[Token(Token = "0x6002741")]
		internal void ToNativeParams(out NativeRectParams nativeRectParams) { }

	}

	[Token(Token = "0x200057B")]
	private struct RepeatRectUV
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x40012FB")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x40012FC")]
		public Rect uv; //Field offset: 0x10

	}

	[Token(Token = "0x2000580")]
	private struct TessellationJob : IJobParallelFor
	{
		[FieldOffset(Offset = "0x0")]
		[ReadOnly]
		[Token(Token = "0x4001336")]
		public TempMeshAllocator allocator; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[ReadOnly]
		[Token(Token = "0x4001337")]
		public NativeSlice<TessellationJobParameters> jobParameters; //Field offset: 0x8

		[Address(RVA = "0x1B8D400", Offset = "0x1B8C600", Length = "0x392")]
		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeBorderParams&)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
		[Calls(Type = typeof(BorderParams), Member = "ToNativeParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeBorderParams&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
		[CallsDeduplicatedMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002744")]
		private void DrawBorder(UnsafeMeshGenerationNode node, ref BorderParams borderParams) { }

		[Address(RVA = "0x1B8D7A0", Offset = "0x1B8C9A0", Length = "0xB20")]
		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1+Enumerator<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), typeof(int)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Enumerator), Member = "HasNext", ReturnType = typeof(bool))]
		[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1+Enumerator<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "GetNext", ReturnType = typeof(BackgroundRepeatInstance))]
		[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Unity.Collections.NativeSlice`1<T>", typeof(int), typeof(int)}, ReturnType = "Unity.Collections.NativeSlice`1<T>")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
		[Calls(Type = typeof(UnsafeUtility), Member = "MemCpy", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(Void*), typeof(long)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Math), Member = "Min", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(ushort))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
		[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
		[Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeTexturedRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeRectParams&)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeSolidRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeRectParams&)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
		[CallsDeduplicatedMethods(Count = 30)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002745")]
		private void DrawRectangle(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, Texture tex) { }

		[Address(RVA = "0x1B8E2D0", Offset = "0x1B8D4D0", Length = "0x597")]
		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(TessellationJob), Member = "ExtractHandle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MeshGenerator), Member = "AdjustSpriteWinding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2[]), typeof(UInt16[]), typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Vertex)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B238B0")]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002746")]
		private void DrawSprite(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, Sprite sprite) { }

		[Address(RVA = "0x1B8E870", Offset = "0x1B8DA70", Length = "0x6F5")]
		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ushort)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<System.UInt16>))]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(Texture), typeof(TextureOptions)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<System.UInt16>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), Member = "CopyFrom", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Debug), Member = "Assert", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TempMeshAllocator), Member = "AllocateTempMesh", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int), typeof(NativeSlice`1<Vertex>&), typeof(NativeSlice`1<UInt16>&)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
		[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
		[Calls(Type = typeof(MeshGenerationNodeImpl), Member = "DrawGradients", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(VectorImage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeVectorGraphics9SliceBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex[]), typeof(UInt16[]), typeof(float), typeof(float), typeof(Rect), typeof(Vector4), typeof(Color), typeof(NativeColorPage)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(MeshBuilderNative), Member = "MakeVectorGraphicsStretchBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex[]), typeof(UInt16[]), typeof(float), typeof(float), typeof(Rect), typeof(Rect), typeof(ScaleMode), typeof(Color), typeof(NativeColorPage)}, ReturnType = typeof(MeshWriteDataInterface))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
		[Calls(Type = typeof(UIRenderDevice), Member = "PtrToSlice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vertex)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Void*), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsDeduplicatedMethods(Count = 10)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x6002747")]
		private void DrawVectorImage(UnsafeMeshGenerationNode node, ref NativeRectParams rectParams, VectorImage vi) { }

		[Address(RVA = "0x1B8EF70", Offset = "0x1B8E170", Length = "0x220")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters")]
		[Calls(Type = typeof(TessellationJob), Member = "ExtractHandle", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(TessellationJob), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TessellationJob), Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TessellationJob), Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(TessellationJob), Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
		[Token(Token = "0x6002742")]
		public override void Execute(int i) { }

		[Address(RVA = "0x7CE960", Offset = "0x7CDB60", Length = "0x89")]
		[CalledBy(Type = typeof(TessellationJob), Member = "Execute", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
		[CalledBy(Type = typeof(TessellationJob), Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 7)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
		[Calls(Type = typeof(GCHandle), Member = "GetTarget", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = typeof(object))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F72D0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
		[CallsDeduplicatedMethods(Count = 2)]
		[DeduplicatedMethod]
		[Token(Token = "0x6002743")]
		private T ExtractHandle(IntPtr handlePtr) { }

	}

	[Token(Token = "0x200057F")]
	private struct TessellationJobParameters
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4001332")]
		public bool isBorderJob; //Field offset: 0x0
		[FieldOffset(Offset = "0x8")]
		[Token(Token = "0x4001333")]
		public NativeRectParams rectParams; //Field offset: 0x8
		[FieldOffset(Offset = "0x120")]
		[Token(Token = "0x4001334")]
		public BorderParams borderParams; //Field offset: 0x120
		[FieldOffset(Offset = "0x1D0")]
		[Token(Token = "0x4001335")]
		public UnsafeMeshGenerationNode node; //Field offset: 0x1D0

	}

	[Token(Token = "0x40012E6")]
	private static readonly ProfilerMarker k_MarkerDrawRectangle; //Field offset: 0x0
	[Token(Token = "0x40012E7")]
	private static readonly ProfilerMarker k_MarkerDrawBorder; //Field offset: 0x8
	[Token(Token = "0x40012E8")]
	private static readonly ProfilerMarker k_MarkerDrawVectorImage; //Field offset: 0x10
	[Token(Token = "0x40012E9")]
	private static readonly ProfilerMarker k_MarkerDrawRectangleRepeat; //Field offset: 0x18
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x40012EA")]
	private MeshGenerationContext m_MeshGenerationContext; //Field offset: 0x10
	[FieldOffset(Offset = "0x18")]
	[Token(Token = "0x40012EB")]
	private List<RepeatRectUV>[] m_RepeatRectUVList; //Field offset: 0x18
	[FieldOffset(Offset = "0x20")]
	[Token(Token = "0x40012EC")]
	private NativePagedList<BackgroundRepeatInstance> m_BackgroundRepeatInstanceList; //Field offset: 0x20
	[FieldOffset(Offset = "0x28")]
	[Token(Token = "0x40012ED")]
	private GCHandlePool m_GCHandlePool; //Field offset: 0x28
	[FieldOffset(Offset = "0x30")]
	[Token(Token = "0x40012EE")]
	private NativeArray<TessellationJobParameters> m_JobParameters; //Field offset: 0x30
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x40")]
	[Token(Token = "0x40012EF")]
	private VisualElement <currentElement>k__BackingField; //Field offset: 0x40
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x48")]
	[Token(Token = "0x40012F0")]
	private TextJobSystem <textJobSystem>k__BackingField; //Field offset: 0x48
	[FieldOffset(Offset = "0x50")]
	[Token(Token = "0x40012F1")]
	private TextInfo m_TextInfo; //Field offset: 0x50
	[FieldOffset(Offset = "0x58")]
	[Token(Token = "0x40012F2")]
	private TextGenerationSettings m_Settings; //Field offset: 0x58
	[FieldOffset(Offset = "0x60")]
	[Token(Token = "0x40012F3")]
	private List<NativeSlice`1<Vertex>> m_VerticesArray; //Field offset: 0x60
	[FieldOffset(Offset = "0x68")]
	[Token(Token = "0x40012F4")]
	private List<NativeSlice`1<UInt16>> m_IndicesArray; //Field offset: 0x68
	[FieldOffset(Offset = "0x70")]
	[Token(Token = "0x40012F5")]
	private List<Texture2D> m_Atlases; //Field offset: 0x70
	[FieldOffset(Offset = "0x78")]
	[Token(Token = "0x40012F6")]
	private List<Single> m_SdfScales; //Field offset: 0x78
	[FieldOffset(Offset = "0x80")]
	[Token(Token = "0x40012F7")]
	private List<GlyphRenderMode> m_RenderModes; //Field offset: 0x80
	[FieldOffset(Offset = "0x88")]
	[Token(Token = "0x40012F8")]
	private MeshGenerationCallback m_OnMeshGenerationDelegate; //Field offset: 0x88
	[FieldOffset(Offset = "0x90")]
	[Token(Token = "0x40012F9")]
	private List<TessellationJobParameters> m_TesselationJobParameters; //Field offset: 0x90
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	[FieldOffset(Offset = "0x98")]
	[Token(Token = "0x40012FA")]
	private bool <disposed>k__BackingField; //Field offset: 0x98

	[Token(Token = "0x170009E9")]
	public override VisualElement currentElement
	{
		[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600271E")]
		 set { } //Length: 13
	}

	[Token(Token = "0x170009EB")]
	internal bool disposed
	{
		[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002730")]
		internal get { } //Length: 8
		[Address(RVA = "0xE0C420", Offset = "0xE0B620", Length = "0x7")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002731")]
		private set { } //Length: 7
	}

	[Token(Token = "0x170009EA")]
	public override TextJobSystem textJobSystem
	{
		[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
		[CallerCount(Count = 4)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x600271F")]
		 get { } //Length: 5
		[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
		[CompilerGenerated]
		[DeduplicatedMethod]
		[Token(Token = "0x6002720")]
		 set { } //Length: 13
	}

	[Address(RVA = "0x1B89A60", Offset = "0x1B88C60", Length = "0x111")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ProfilerUnsafeUtility), Member = "CreateMarker", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(ushort), typeof(MarkerFlags), typeof(int)}, ReturnType = typeof(IntPtr))]
	[Token(Token = "0x6002734")]
	private static MeshGenerator() { }

	[Address(RVA = "0x1B89B80", Offset = "0x1B88D80", Length = "0x461")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshWriteDataPool), typeof(EntryRecorder), typeof(TempMeshAllocatorImpl), typeof(MeshGenerationDeferrer), typeof(MeshGenerationNodeManager)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(GCHandlePool), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextInfo", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGenerationSettings", Member = ".ctor", ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED960")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE9C0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Token(Token = "0x600271D")]
	public MeshGenerator(MeshGenerationContext mgc) { }

	[Address(RVA = "0x1B848F0", Offset = "0x1B83AF0", Length = "0x3C1")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F6BD0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002723")]
	public static void AdjustBackgroundSizeForBorders(VisualElement visualElement, ref RectangleParams rectParams) { }

	[Address(RVA = "0x1B84CC0", Offset = "0x1B83EC0", Length = "0x3E6")]
	[CalledBy(Type = typeof(TessellationJob), Member = "DrawSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18028AEB0")]
	[Calls(Type = typeof(Unity.Collections.NativeSlice`1<System.UInt16>), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(ushort)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600272D")]
	private static void AdjustSpriteWinding(Vector2[] vertices, UInt16[] indices, NativeSlice<UInt16> newIndices) { }

	[Address(RVA = "0x1B850B0", Offset = "0x1B842B0", Length = "0x5D")]
	[CallerCount(Count = 0)]
	[Token(Token = "0x6002721")]
	private static Vector2 ConvertBorderRadiusPercentToPoints(Vector2 borderRectSize, Length length) { }

	[Address(RVA = "0x1B237B0", Offset = "0x1B229B0", Length = "0x171")]
	[CalledBy(Type = typeof(ATGTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(ATGMeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(UITKTextJobSystem), Member = "ConvertMeshInfoToUIRVertex", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshInfo[]), typeof(TempMeshAllocator), typeof(TextElement), typeof(List`1<Material>&), typeof(List`1<NativeSlice`1<Vertex>>&), typeof(List`1<NativeSlice`1<UInt16>>&), typeof(List`1<GlyphRenderMode>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18038DB40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED970")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002726")]
	internal static Vertex ConvertTextVertexToUIRVertex(ref TextCoreVertex vertex, Vector2 posOffset, float inverseScale, bool isDynamicColor = false, bool isColorGlyph = false) { }

	[Address(RVA = "0x1B85110", Offset = "0x1B84310", Length = "0xBD")]
	[CalledBy(Type = typeof(MeshGenerationContext), Member = "Dispose", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandlePool), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002732")]
	public override void Dispose() { }

	[Address(RVA = "0x1B851D0", Offset = "0x1B843D0", Length = "0x94")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandlePool), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002733")]
	private void Dispose(bool disposing) { }

	[Address(RVA = "0x1B85270", Offset = "0x1B84470", Length = "0x234B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180002400")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Vector2), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(float)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(List`1), Member = "set_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), "T"}, ReturnType = typeof(void))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(Allocator)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(NativePagedList`1), Member = "GetCount", ReturnType = typeof(int))]
	[Calls(Type = typeof(List`1), Member = "GetEnumerator", ReturnType = "System.Collections.Generic.List`1<T>+Enumerator<T>")]
	[Calls(Type = typeof(Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[Calls(Type = typeof(MeshGenerator), Member = "StampRectangleWithSubRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams), typeof(Rect), typeof(Rect), typeof(Rect), typeof(NativePagedList`1<BackgroundRepeatInstance>&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE430")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(AlignmentUtils), Member = "CeilToPixelGrid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), typeof(float), typeof(float)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAE0")]
	[Calls(Type = typeof(Vector2), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D3AA0")]
	[Calls(Type = typeof(Math), Member = "Max", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(int)}, ReturnType = typeof(int))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Length), Member = "IsAuto", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "get_y", ReturnType = typeof(Length))]
	[Calls(Type = typeof(Length), Member = "IsNone", ReturnType = typeof(bool))]
	[Calls(Type = typeof(BackgroundSize), Member = "get_x", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED950")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(IndexOutOfRangeException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[CallsDeduplicatedMethods(Count = 9)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600272B")]
	private void DoDrawRectangleRepeat(ref RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[Address(RVA = "0x1B875C0", Offset = "0x1B867C0", Length = "0x265")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D5D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002729")]
	public override void DrawBorder(BorderParams borderParams) { }

	[Address(RVA = "0x1B87860", Offset = "0x1B86A60", Length = "0xB8F")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "StampRectangleWithSubRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams), typeof(Rect), typeof(Rect), typeof(Rect), typeof(NativePagedList`1<BackgroundRepeatInstance>&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(RectangleParams), Member = "ToNativeParams", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(NativeRectParams&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "InsertUnsafeMeshGenerationNode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Sprite), Member = "get_triangles", ReturnType = typeof(UInt16[]))]
	[Calls(Type = typeof(Sprite), Member = "get_uv", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_vertices", ReturnType = typeof(Vector2[]))]
	[Calls(Type = typeof(Sprite), Member = "get_texture", ReturnType = typeof(Texture2D))]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(GCHandlePool), Member = "GetIntPtr", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(IntPtr))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1800D5D10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1802B6F00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6002728")]
	public override void DrawRectangle(RectangleParams rectParams) { }

	[Address(RVA = "0x1B87830", Offset = "0x1B86A30", Length = "0x25")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x181B7A690")]
	[Token(Token = "0x600272A")]
	public override void DrawRectangleRepeat(RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint) { }

	[Address(RVA = "0x1B883F0", Offset = "0x1B875F0", Length = "0x2C9")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.Material>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Single>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(float))]
	[Calls(Type = typeof(MeshGenerator), Member = "MakeText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture), typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>), typeof(Unity.Collections.NativeSlice`1<System.UInt16>), typeof(bool), typeof(float), typeof(float), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Token(Token = "0x6002725")]
	public override void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<Single> sdfScales) { }

	[Address(RVA = "0x1B886C0", Offset = "0x1B878C0", Length = "0x306")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Material), Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<System.Object>), Member = "AddWithResize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(List`1), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = "UnityEngine.TextCore.Text.TextGeneratorUtilities", Member = "IsBitmapRendering", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(GlyphRenderMode)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Texture2D), Member = "get_format", ReturnType = typeof(TextureFormat))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18001F7C0")]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Array), typeof(int), typeof(int)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Token(Token = "0x6002724")]
	public override void DrawText(List<NativeSlice`1<Vertex>> vertices, List<NativeSlice`1<UInt16>> indices, List<Material> materials, List<GlyphRenderMode> renderModes) { }

	[Address(RVA = "0xE0C2A0", Offset = "0xE0B4A0", Length = "0x8")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002730")]
	internal bool get_disposed() { }

	[Address(RVA = "0x2DD280", Offset = "0x2DC480", Length = "0x5")]
	[CallerCount(Count = 4)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600271F")]
	public override TextJobSystem get_textJobSystem() { }

	[Address(RVA = "0x1B889D0", Offset = "0x1B87BD0", Length = "0x2AA")]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "DrawVisualElementBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(DefaultElementBuilder), Member = "GenerateStencilClipEntryForRoundedRectBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationContext)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(VisualElement), Member = "get_resolvedStyle", ReturnType = typeof(IResolvedStyle))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x18002BFC0")]
	[Calls(Type = typeof(VisualElement), Member = "get_computedStyle", ReturnType = typeof(ComputedStyle&))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomLeftRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderTopRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(ComputedStyle), Member = "get_borderBottomRightRadius", ReturnType = typeof(Length))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002722")]
	public static void GetVisualElementRadii(VisualElement ve, out Vector2 topLeft, out Vector2 bottomLeft, out Vector2 topRight, out Vector2 bottomRight) { }

	[Address(RVA = "0x1B88C80", Offset = "0x1B87E80", Length = "0x147")]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DrawText", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<UnityEngine.UIElements.Vertex>>), typeof(System.Collections.Generic.List`1<Unity.Collections.NativeSlice`1<System.UInt16>>), typeof(System.Collections.Generic.List`1<UnityEngine.Texture2D>), typeof(System.Collections.Generic.List`1<UnityEngine.TextCore.LowLevel.GlyphRenderMode>), typeof(System.Collections.Generic.List`1<System.Single>)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(EntryPool), Member = "Get", ReturnType = typeof(Entry))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[Calls(Type = typeof(EntryRecorder), Member = "AppendMeshEntry", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Entry), typeof(Entry)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6002727")]
	private void MakeText(Texture texture, NativeSlice<Vertex> vertices, NativeSlice<UInt16> indices, bool isSdf, float sdfScale, float sharpness, bool multiChannel) { }

	[Address(RVA = "0x1B88DD0", Offset = "0x1B87FD0", Length = "0x56")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Reset", ReturnType = typeof(void))]
	[Calls(Type = typeof(GCHandlePool), Member = "ReturnAll", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600272F")]
	private void OnMeshGeneration(MeshGenerationContext ctx, object data) { }

	[Address(RVA = "0x1B88E30", Offset = "0x1B88030", Length = "0x350")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(NativeArray`1), Member = "Dispose", ReturnType = typeof(void))]
	[Calls(Type = typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int), typeof(Allocator), typeof(NativeArrayOptions)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(System.Collections.Generic.List`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), Member = "get_Item", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(int)}, ReturnType = typeof(TessellationJobParameters))]
	[Calls(Type = typeof(NativeSliceExtensions), Member = "Slice", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TessellationJobParameters)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Unity.Collections.NativeArray`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>), typeof(int), typeof(int)}, ReturnType = typeof(Unity.Collections.NativeSlice`1<UnityEngine.UIElements.UIR.MeshGenerator+TessellationJobParameters>))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "GetTempMeshAllocator", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TempMeshAllocator&)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ManagedJobExtension), Member = "ScheduleOrRunJob", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TessellationJob)}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TessellationJob), typeof(int), typeof(int), typeof(JobHandle)}, ReturnType = typeof(JobHandle))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationJob", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(JobHandle)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerationContext), Member = "AddMeshGenerationCallback", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(MeshGenerationCallback), typeof(object), typeof(MeshGenerationCallbackType), typeof(bool)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600272E")]
	public override void ScheduleJobs(MeshGenerationContext mgc) { }

	[Address(RVA = "0x309660", Offset = "0x308860", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x600271E")]
	public override void set_currentElement(VisualElement value) { }

	[Address(RVA = "0xE0C420", Offset = "0xE0B620", Length = "0x7")]
	[CallerCount(Count = 0)]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002731")]
	private void set_disposed(bool value) { }

	[Address(RVA = "0x2DD5F0", Offset = "0x2DC7F0", Length = "0xD")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CompilerGenerated]
	[DeduplicatedMethod]
	[Token(Token = "0x6002720")]
	public override void set_textJobSystem(TextJobSystem value) { }

	[Address(RVA = "0x1B89190", Offset = "0x1B88390", Length = "0x8CB")]
	[CalledBy(Type = typeof(EntryProcessor), Member = "AppendCommand", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RenderChainCommand)}, ReturnType = typeof(void))]
	[CalledBy(Type = typeof(MeshGenerator), Member = "DoDrawRectangleRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams&), typeof(Rect), typeof(float)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(UnityEngine.UIElements.UIR.NativePagedList`1<UnityEngine.UIElements.UIR.MeshGenerator+BackgroundRepeatInstance>), Member = "Add", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(BackgroundRepeatInstance)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(MeshGenerator), Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(RectangleParams)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsDeduplicatedMethods(Count = 4)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600272C")]
	private void StampRectangleWithSubRect(RectangleParams rectParams, Rect targetRect, Rect totalRect, Rect targetUV, ref NativePagedList<BackgroundRepeatInstance>& backgroundRepeatInstanceList) { }

}

