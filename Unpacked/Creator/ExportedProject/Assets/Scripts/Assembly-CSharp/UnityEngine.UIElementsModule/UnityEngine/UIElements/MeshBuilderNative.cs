namespace UnityEngine.UIElements;

[NativeHeader("Modules/UIElements/Core/Native/Renderer/UIRMeshBuilder.bindings.h")]
[Token(Token = "0x200029C")]
internal static class MeshBuilderNative
{
	[Token(Token = "0x200029E")]
	internal struct NativeBorderParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A43")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A44")]
		public Color leftColor; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A45")]
		public Color topColor; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A46")]
		public Color rightColor; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A47")]
		public Color bottomColor; //Field offset: 0x40
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A48")]
		public float leftWidth; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000A49")]
		public float topWidth; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A4A")]
		public float rightWidth; //Field offset: 0x58
		[FieldOffset(Offset = "0x5C")]
		[Token(Token = "0x4000A4B")]
		public float bottomWidth; //Field offset: 0x5C
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A4C")]
		public Vector2 topLeftRadius; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000A4D")]
		public Vector2 topRightRadius; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A4E")]
		public Vector2 bottomRightRadius; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A4F")]
		public Vector2 bottomLeftRadius; //Field offset: 0x78
		[FieldOffset(Offset = "0x80")]
		[Token(Token = "0x4000A50")]
		internal NativeColorPage leftColorPage; //Field offset: 0x80
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000A51")]
		internal NativeColorPage topColorPage; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000A52")]
		internal NativeColorPage rightColorPage; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000A53")]
		internal NativeColorPage bottomColorPage; //Field offset: 0x98

	}

	[Token(Token = "0x200029D")]
	internal struct NativeColorPage
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A41")]
		public int isValid; //Field offset: 0x0
		[FieldOffset(Offset = "0x4")]
		[Token(Token = "0x4000A42")]
		public Color32 pageAndID; //Field offset: 0x4

	}

	[Token(Token = "0x200029F")]
	internal struct NativeRectParams
	{
		[FieldOffset(Offset = "0x0")]
		[Token(Token = "0x4000A54")]
		public Rect rect; //Field offset: 0x0
		[FieldOffset(Offset = "0x10")]
		[Token(Token = "0x4000A55")]
		public Rect subRect; //Field offset: 0x10
		[FieldOffset(Offset = "0x20")]
		[Token(Token = "0x4000A56")]
		public Rect uv; //Field offset: 0x20
		[FieldOffset(Offset = "0x30")]
		[Token(Token = "0x4000A57")]
		public Color color; //Field offset: 0x30
		[FieldOffset(Offset = "0x40")]
		[Token(Token = "0x4000A58")]
		public ScaleMode scaleMode; //Field offset: 0x40
		[FieldOffset(Offset = "0x48")]
		[Token(Token = "0x4000A59")]
		public IntPtr backgroundRepeatInstanceList; //Field offset: 0x48
		[FieldOffset(Offset = "0x50")]
		[Token(Token = "0x4000A5A")]
		public int backgroundRepeatInstanceListStartIndex; //Field offset: 0x50
		[FieldOffset(Offset = "0x54")]
		[Token(Token = "0x4000A5B")]
		public int backgroundRepeatInstanceListEndIndex; //Field offset: 0x54
		[FieldOffset(Offset = "0x58")]
		[Token(Token = "0x4000A5C")]
		public Vector2 topLeftRadius; //Field offset: 0x58
		[FieldOffset(Offset = "0x60")]
		[Token(Token = "0x4000A5D")]
		public Vector2 topRightRadius; //Field offset: 0x60
		[FieldOffset(Offset = "0x68")]
		[Token(Token = "0x4000A5E")]
		public Vector2 bottomRightRadius; //Field offset: 0x68
		[FieldOffset(Offset = "0x70")]
		[Token(Token = "0x4000A5F")]
		public Vector2 bottomLeftRadius; //Field offset: 0x70
		[FieldOffset(Offset = "0x78")]
		[Token(Token = "0x4000A60")]
		public Rect backgroundRepeatRect; //Field offset: 0x78
		[FieldOffset(Offset = "0x88")]
		[Token(Token = "0x4000A61")]
		public IntPtr texture; //Field offset: 0x88
		[FieldOffset(Offset = "0x90")]
		[Token(Token = "0x4000A62")]
		public IntPtr sprite; //Field offset: 0x90
		[FieldOffset(Offset = "0x98")]
		[Token(Token = "0x4000A63")]
		public IntPtr vectorImage; //Field offset: 0x98
		[FieldOffset(Offset = "0xA0")]
		[Token(Token = "0x4000A64")]
		public IntPtr spriteTexture; //Field offset: 0xA0
		[FieldOffset(Offset = "0xA8")]
		[Token(Token = "0x4000A65")]
		public IntPtr spriteVertices; //Field offset: 0xA8
		[FieldOffset(Offset = "0xB0")]
		[Token(Token = "0x4000A66")]
		public IntPtr spriteUVs; //Field offset: 0xB0
		[FieldOffset(Offset = "0xB8")]
		[Token(Token = "0x4000A67")]
		public IntPtr spriteTriangles; //Field offset: 0xB8
		[FieldOffset(Offset = "0xC0")]
		[Token(Token = "0x4000A68")]
		public Rect spriteGeomRect; //Field offset: 0xC0
		[FieldOffset(Offset = "0xD0")]
		[Token(Token = "0x4000A69")]
		public Vector2 contentSize; //Field offset: 0xD0
		[FieldOffset(Offset = "0xD8")]
		[Token(Token = "0x4000A6A")]
		public Vector2 textureSize; //Field offset: 0xD8
		[FieldOffset(Offset = "0xE0")]
		[Token(Token = "0x4000A6B")]
		public float texturePixelsPerPoint; //Field offset: 0xE0
		[FieldOffset(Offset = "0xE4")]
		[Token(Token = "0x4000A6C")]
		public int leftSlice; //Field offset: 0xE4
		[FieldOffset(Offset = "0xE8")]
		[Token(Token = "0x4000A6D")]
		public int topSlice; //Field offset: 0xE8
		[FieldOffset(Offset = "0xEC")]
		[Token(Token = "0x4000A6E")]
		public int rightSlice; //Field offset: 0xEC
		[FieldOffset(Offset = "0xF0")]
		[Token(Token = "0x4000A6F")]
		public int bottomSlice; //Field offset: 0xF0
		[FieldOffset(Offset = "0xF4")]
		[Token(Token = "0x4000A70")]
		public float sliceScale; //Field offset: 0xF4
		[FieldOffset(Offset = "0xF8")]
		[Token(Token = "0x4000A71")]
		public Vector4 rectInset; //Field offset: 0xF8
		[FieldOffset(Offset = "0x108")]
		[Token(Token = "0x4000A72")]
		public NativeColorPage colorPage; //Field offset: 0x108
		[FieldOffset(Offset = "0x110")]
		[Token(Token = "0x4000A73")]
		public int meshFlags; //Field offset: 0x110

	}


	[Address(RVA = "0x1C875D0", Offset = "0x1C867D0", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawBorder", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(BorderParams&)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6001208")]
	public static MeshWriteDataInterface MakeBorder(ref NativeBorderParams borderParams) { }

	[Address(RVA = "0x1C87580", Offset = "0x1C86780", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600120D")]
	private static void MakeBorder_Injected(ref NativeBorderParams borderParams, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x1C87680", Offset = "0x1C86880", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x6001209")]
	public static MeshWriteDataInterface MakeSolidRect(ref NativeRectParams rectParams) { }

	[Address(RVA = "0x1C87630", Offset = "0x1C86830", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600120E")]
	private static void MakeSolidRect_Injected(ref NativeRectParams rectParams, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x1C87730", Offset = "0x1C86930", Length = "0x51")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(Texture)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600120A")]
	public static MeshWriteDataInterface MakeTexturedRect(ref NativeRectParams rectParams) { }

	[Address(RVA = "0x1C876E0", Offset = "0x1C868E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600120F")]
	private static void MakeTexturedRect_Injected(ref NativeRectParams rectParams, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x1C87800", Offset = "0x1C86A00", Length = "0x1BE")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600120C")]
	public static MeshWriteDataInterface MakeVectorGraphics9SliceBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Vector4 sliceLTRB, Color tint, NativeColorPage colorPage) { }

	[Address(RVA = "0x1C87790", Offset = "0x1C86990", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001211")]
	private static void MakeVectorGraphics9SliceBackground_Injected(ref ManagedSpanWrapper svgVertices, ref ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, in Rect targetRect, in Vector4 sliceLTRB, in Color tint, in NativeColorPage colorPage, out MeshWriteDataInterface ret) { }

	[Address(RVA = "0x1C87A30", Offset = "0x1C86C30", Length = "0x1C9")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+TessellationJob", Member = "DrawVectorImage", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(UnsafeMeshGenerationNode), typeof(NativeRectParams&), typeof(VectorImage)}, ReturnType = typeof(void))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 1)]
	[ThreadSafe]
	[Token(Token = "0x600120B")]
	public static MeshWriteDataInterface MakeVectorGraphicsStretchBackground(Vertex[] svgVertices, UInt16[] svgIndices, float svgWidth, float svgHeight, Rect targetRect, Rect sourceUV, ScaleMode scaleMode, Color tint, NativeColorPage colorPage) { }

	[Address(RVA = "0x1C879C0", Offset = "0x1C86BC0", Length = "0x65")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6001210")]
	private static void MakeVectorGraphicsStretchBackground_Injected(ref ManagedSpanWrapper svgVertices, ref ManagedSpanWrapper svgIndices, float svgWidth, float svgHeight, in Rect targetRect, in Rect sourceUV, ScaleMode scaleMode, in Color tint, in NativeColorPage colorPage, out MeshWriteDataInterface ret) { }

}

