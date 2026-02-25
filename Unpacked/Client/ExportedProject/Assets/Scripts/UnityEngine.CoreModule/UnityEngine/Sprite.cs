namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/SpriteUtility.h")]
[NativeHeader("Runtime/2D/Common/SpriteDataAccess.h")]
[NativeHeader("Runtime/2D/Common/ScriptBindings/SpritesMarshalling.h")]
[NativeType("Runtime/Graphics/SpriteFrame.h")]
[Token(Token = "0x200006A")]
public sealed class Sprite : object
{

	[Token(Token = "0x17000025")]
	public Texture2D associatedAlphaSplitTexture
	{
		[Address(RVA = "0x1940A50", Offset = "0x193FC50", Length = "0x90")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = "SoftMasking.SoftMask+Errors")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("GetAlphaTexture")]
		[Token(Token = "0x600011B")]
		 get { } //Length: 144
	}

	[Token(Token = "0x17000022")]
	public Vector4 border
	{
		[Address(RVA = "0x1940B40", Offset = "0x193FD40", Length = "0x8E")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_hasBorder", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "MaskRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(float), typeof(Vector4)}, ReturnType = typeof(Vector2))]
		[CallerCount(Count = 12)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000116")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000020")]
	public Bounds bounds
	{
		[Address(RVA = "0x1940C20", Offset = "0x193FE20", Length = "0x94")]
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 11)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000114")]
		 get { } //Length: 148
	}

	[Token(Token = "0x17000027")]
	public bool packed
	{
		[Address(RVA = "0x1940CC0", Offset = "0x193FEC0", Length = "0x7C")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = "SoftMasking.SoftMask+Errors")]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[ContainsUnimplementedInstructions]
		[Token(Token = "0x600011D")]
		 get { } //Length: 124
	}

	[Token(Token = "0x17000028")]
	public SpritePackingMode packingMode
	{
		[Address(RVA = "0x1940500", Offset = "0x193F700", Length = "0x76")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011E")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000029")]
	public SpritePackingRotation packingRotation
	{
		[Address(RVA = "0x19405C0", Offset = "0x193F7C0", Length = "0x76")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x600011F")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000026")]
	public Vector2 pivot
	{
		[Address(RVA = "0x1940D90", Offset = "0x193FF90", Length = "0x87")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Sprite)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("GetPivotInPixels")]
		[Token(Token = "0x600011C")]
		 get { } //Length: 135
	}

	[Token(Token = "0x17000024")]
	public float pixelsPerUnit
	{
		[Address(RVA = "0x1940E60", Offset = "0x1940060", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Sprite)}, ReturnType = typeof(float))]
		[CalledBy(Type = "RLD.SpriteRendererEx", Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[NativeMethod("GetPixelsToUnits")]
		[Token(Token = "0x600011A")]
		 get { } //Length: 118
	}

	[Token(Token = "0x17000021")]
	public Rect rect
	{
		[Address(RVA = "0x1940F30", Offset = "0x1940130", Length = "0x8E")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "MaskRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(float), typeof(Vector4)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Sprite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.DefaultElementBuilder", Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
		[CallerCount(Count = 23)]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000115")]
		 get { } //Length: 142
	}

	[Token(Token = "0x17000023")]
	public Texture2D texture
	{
		[Address(RVA = "0x1941000", Offset = "0x1940200", Length = "0x90")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "SoftMasking.SoftMask", Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
		[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Sprite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__SpriteSupportsAlphaHitTest|11_1", ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_alphaHitTestMinimumThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_eventAlphaThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.SpriteRendererEx", Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_mainTexture", ReturnType = typeof(Texture))]
		[CallerCount(Count = 32)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
		[CallsUnknownMethods(Count = 1)]
		[Token(Token = "0x6000117")]
		 get { } //Length: 144
	}

	[Token(Token = "0x1700002A")]
	public Vector2 textureRectOffset
	{
		[Address(RVA = "0x1940930", Offset = "0x193FB30", Length = "0x87")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[Token(Token = "0x6000120")]
		 get { } //Length: 135
	}

	[Token(Token = "0x1700002C")]
	public UInt16[] triangles
	{
		[Address(RVA = "0x19410E0", Offset = "0x19402E0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
		[Token(Token = "0x6000122")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002D")]
	public Vector2[] uv
	{
		[Address(RVA = "0x19411A0", Offset = "0x19403A0", Length = "0x76")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 4)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
		[Token(Token = "0x6000123")]
		 get { } //Length: 118
	}

	[Token(Token = "0x1700002B")]
	public Vector2[] vertices
	{
		[Address(RVA = "0x1941260", Offset = "0x1940460", Length = "0x76")]
		[CalledBy(Type = "RLD.SpriteRendererEx", Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = "RLD.AABB")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeGeomRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
		[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
		[CalledBy(Type = "RLD.SpriteEx", Member = "GetWorldVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Transform)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
		[CalledBy(Type = "RLD.SpriteEx", Member = "GetModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
		[CalledBy(Type = "RLD.ObjectVertexCollect", Member = "CollectModelSpriteVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "RLD.AABB"}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
		[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
		[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
		[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
		[CallsUnknownMethods(Count = 1)]
		[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
		[Token(Token = "0x6000121")]
		 get { } //Length: 118
	}

	[Address(RVA = "0x19409C0", Offset = "0x193FBC0", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[CallsDeduplicatedMethods(Count = 1)]
	[RequiredByNativeCode]
	[Token(Token = "0x600010B")]
	private Sprite() { }

	[Address(RVA = "0x193FA10", Offset = "0x193EC10", Length = "0xAE")]
	[CalledBy(Type = "RLD.RTPrefab", Member = "get_PreviewSprite", ReturnType = typeof(Sprite))]
	[CalledBy(Type = "Polytoria.Datamodel.UIImage", Member = "<GetImage>b__29_0", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Polytoria.Controllers.ImageCacheKey", "Polytoria.Controllers.ImageCacheEntry"}, ReturnType = typeof(void))]
	[CalledBy(Type = "Polytoria.Controllers.ScreenshotController+<DoScreenshot>d__24", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadLeaderboardThumbnail>d__121", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.UIController+<LoadThumbnail>d__134", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImage>d__77", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController+<LoadThumbnailImages>d__75", Member = "MoveNext", ReturnType = typeof(bool))]
	[CalledBy(Type = "Polytoria.Controllers.CreatorController", Member = "Start", ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkReaderExtensions", Member = "ReadSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkReader"}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	[Token(Token = "0x600012A")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot) { }

	[Address(RVA = "0x193FAC0", Offset = "0x193ECC0", Length = "0xBC")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	[Token(Token = "0x6000129")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit) { }

	[Address(RVA = "0x1940170", Offset = "0x193F370", Length = "0xC3")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	[Token(Token = "0x6000128")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude) { }

	[Address(RVA = "0x193F940", Offset = "0x193EB40", Length = "0xC6")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	[Token(Token = "0x6000127")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType) { }

	[Address(RVA = "0x193F8E0", Offset = "0x193EAE0", Length = "0x5B")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	[Token(Token = "0x6000126")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border) { }

	[Address(RVA = "0x193FBF0", Offset = "0x193EDF0", Length = "0x578")]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint)}, ReturnType = typeof(Sprite))]
	[CalledBy(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float)}, ReturnType = typeof(Sprite))]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA10")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED9B0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_value_box")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001D10")]
	[Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F40")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001F20")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA00")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE830")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x180001DB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Object), typeof(Object)}, ReturnType = typeof(bool))]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(object)}, ReturnType = typeof(string))]
	[Calls(Type = typeof(string), Member = "Format", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(string), typeof(Object[])}, ReturnType = typeof(string))]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x6000125")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTextures) { }

	[Address(RVA = "0x193FB80", Offset = "0x193ED80", Length = "0x63")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Sprite), Member = "Create", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Texture2D), typeof(Rect), typeof(Vector2), typeof(float), typeof(uint), typeof(SpriteMeshType), typeof(Vector4), typeof(bool), typeof(SecondarySpriteTexture[])}, ReturnType = typeof(Sprite))]
	[Token(Token = "0x6000124")]
	public static Sprite Create(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape) { }

	[Address(RVA = "0x193F7F0", Offset = "0x193E9F0", Length = "0xEE")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801F7350")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SpritesBindings::CreateSprite", ThrowsException = True)]
	[Token(Token = "0x6000113")]
	internal static Sprite CreateSprite(Texture2D texture, Rect rect, Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x193F770", Offset = "0x193E970", Length = "0x71")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000132")]
	private static IntPtr CreateSprite_Injected(IntPtr texture, in Rect rect, in Vector2 pivot, float pixelsPerUnit, uint extrude, SpriteMeshType meshType, in Vector4 border, bool generateFallbackPhysicsShape, SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x1940A50", Offset = "0x193FC50", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_material", ReturnType = typeof(Material))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "UpdateMaterial", ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = "SoftMasking.SoftMask+Errors")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetAlphaTexture")]
	[Token(Token = "0x600011B")]
	public Texture2D get_associatedAlphaSplitTexture() { }

	[Address(RVA = "0x1940A10", Offset = "0x193FC10", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013A")]
	private static IntPtr get_associatedAlphaSplitTexture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940B40", Offset = "0x193FD40", Length = "0x8E")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = typeof(DataUtility), Member = "GetMinSize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_hasBorder", ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSlicedSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "MaskRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(float), typeof(Vector4)}, ReturnType = typeof(Vector2))]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000116")]
	public Vector4 get_border() { }

	[Address(RVA = "0x1940AF0", Offset = "0x193FCF0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000135")]
	private static void get_border_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x1940C20", Offset = "0x193FE20", Length = "0x94")]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 11)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000114")]
	public Bounds get_bounds() { }

	[Address(RVA = "0x1940BD0", Offset = "0x193FDD0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000133")]
	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[Address(RVA = "0x1940CC0", Offset = "0x193FEC0", Length = "0x7C")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask+Diagnostics", Member = "CheckSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = "SoftMasking.SoftMask+Errors")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[ContainsUnimplementedInstructions]
	[Token(Token = "0x600011D")]
	public bool get_packed() { }

	[Address(RVA = "0x1940500", Offset = "0x193F700", Length = "0x76")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011E")]
	public SpritePackingMode get_packingMode() { }

	[Address(RVA = "0x19405C0", Offset = "0x193F7C0", Length = "0x76")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600011F")]
	public SpritePackingRotation get_packingRotation() { }

	[Address(RVA = "0x1940D90", Offset = "0x193FF90", Length = "0x87")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Sprite)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetPivotInPixels")]
	[Token(Token = "0x600011C")]
	public Vector2 get_pivot() { }

	[Address(RVA = "0x1940D40", Offset = "0x193FF40", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013B")]
	private static void get_pivot_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[Address(RVA = "0x1940E60", Offset = "0x1940060", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "GetTextureDisplaySize", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.Image", Member = "DoMeasure", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode", typeof(float), "UnityEngine.UIElements.VisualElement+MeasureMode"}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UIElements.UIElementsUtility", Member = "PixelsPerUnitScaleForElement", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.VisualElement", typeof(Sprite)}, ReturnType = typeof(float))]
	[CalledBy(Type = "RLD.SpriteRendererEx", Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_pixelsPerUnit", ReturnType = typeof(float))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[NativeMethod("GetPixelsToUnits")]
	[Token(Token = "0x600011A")]
	public float get_pixelsPerUnit() { }

	[Address(RVA = "0x1940E20", Offset = "0x1940020", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000139")]
	private static float get_pixelsPerUnit_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940F30", Offset = "0x1940130", Length = "0x8E")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "SetNativeSize", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.DefaultElementBuilder", Member = "DrawVisualElementBackground", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.MeshGenerationContext"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "AdjustSpriteUVsForScaleMode", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Rect&), typeof(Rect&)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GetDrawingDimensions", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(bool)}, ReturnType = typeof(Vector4))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredHeight", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "MapCoordinate", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Rect)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "MaskRepeat", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(float), typeof(Vector4)}, ReturnType = typeof(Vector2))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_preferredWidth", ReturnType = typeof(float))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 23)]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000115")]
	public Rect get_rect() { }

	[Address(RVA = "0x1940EE0", Offset = "0x19400E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000134")]
	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[Address(RVA = "0x1941000", Offset = "0x1940200", Length = "0x90")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "get_mainTexture", ReturnType = typeof(Texture))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CalledBy(Type = "RLD.SpriteRendererEx", Member = "IsPixelFullyTransparent", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer), typeof(Vector3)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_eventAlphaThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_alphaHitTestMinimumThreshold", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__ResetAlphaHitThresholdIfNeeded|11_0", ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "<set_sprite>g__SpriteSupportsAlphaHitTest|11_1", ReturnType = typeof(bool))]
	[CalledBy(Type = "Mirror.NetworkWriterExtensions", Member = "WriteSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"Mirror.NetworkWriter", typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "DeduceSourceParameters", ReturnType = "SoftMasking.SoftMask+SourceParameters")]
	[CalledBy(Type = "SoftMasking.SoftMask", Member = "CalculateSpriteBased", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "SoftMasking.SoftMask+BorderMode", typeof(float)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "IsRaycastLocationValid", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Vector2), typeof(Camera)}, ReturnType = typeof(bool))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "TrackSprite", ReturnType = typeof(void))]
	[CallerCount(Count = 32)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(Unmarshal), Member = "UnmarshalUnityObject", MemberTypeParameters = new IL2CPP_TYPE_OBJECT[] {"T"}, MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(IntPtr)}, ReturnType = "T")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000117")]
	public Texture2D get_texture() { }

	[Address(RVA = "0x1940FC0", Offset = "0x19401C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000136")]
	private static IntPtr get_texture_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940930", Offset = "0x193FB30", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000120")]
	public Vector2 get_textureRectOffset() { }

	[Address(RVA = "0x19410E0", Offset = "0x19402E0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SpriteAccessLegacy::GetSpriteIndices", HasExplicitThis = True)]
	[Token(Token = "0x6000122")]
	public UInt16[] get_triangles() { }

	[Address(RVA = "0x19410A0", Offset = "0x19402A0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013D")]
	private static UInt16[] get_triangles_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19411A0", Offset = "0x19403A0", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeUVRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SpriteAccessLegacy::GetSpriteUVs", HasExplicitThis = True)]
	[Token(Token = "0x6000123")]
	public Vector2[] get_uv() { }

	[Address(RVA = "0x1941160", Offset = "0x1940360", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013E")]
	private static Vector2[] get_uv_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1941260", Offset = "0x1940460", Length = "0x76")]
	[CalledBy(Type = "RLD.ObjectVertexCollect", Member = "CollectModelSpriteVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "RLD.AABB"}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CalledBy(Type = "RLD.SpriteEx", Member = "GetModelVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CalledBy(Type = "RLD.SpriteEx", Member = "GetWorldVerts", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), typeof(Transform)}, ReturnType = "System.Collections.Generic.List`1<Vector3>")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UI.VertexHelper", typeof(bool)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "MakeSprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Rect), typeof(Rect), typeof(Sprite), "UnityEngine.ScaleMode", typeof(Color), typeof(bool), typeof(Vector4&), typeof(bool)}, ReturnType = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams", Member = "ComputeGeomRect", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Rect))]
	[CalledBy(Type = "RLD.SpriteRendererEx", Member = "GetModelSpaceAABB", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(SpriteRenderer)}, ReturnType = "RLD.AABB")]
	[CalledBy(Type = "UnityEngine.UIElements.UIR.MeshGenerator", Member = "DrawRectangle", MemberParameters = new IL2CPP_TYPE_OBJECT[] {"UnityEngine.UIElements.UIR.MeshGenerator+RectangleParams"}, ReturnType = typeof(void))]
	[CallerCount(Count = 8)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SpriteAccessLegacy::GetSpriteVertices", HasExplicitThis = True)]
	[Token(Token = "0x6000121")]
	public Vector2[] get_vertices() { }

	[Address(RVA = "0x1941220", Offset = "0x1940420", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600013C")]
	private static Vector2[] get_vertices_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940290", Offset = "0x193F490", Length = "0x8E")]
	[CalledBy(Type = typeof(DataUtility), Member = "GetInnerUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000110")]
	internal Vector4 GetInnerUVs() { }

	[Address(RVA = "0x1940240", Offset = "0x193F440", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012F")]
	private static void GetInnerUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x1940370", Offset = "0x193F570", Length = "0x8E")]
	[CalledBy(Type = typeof(DataUtility), Member = "GetOuterUV", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000111")]
	internal Vector4 GetOuterUVs() { }

	[Address(RVA = "0x1940320", Offset = "0x193F520", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000130")]
	private static void GetOuterUVs_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x1940440", Offset = "0x193F640", Length = "0x76")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600010E")]
	internal int GetPacked() { }

	[Address(RVA = "0x1940400", Offset = "0x193F600", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012D")]
	private static int GetPacked_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940500", Offset = "0x193F700", Length = "0x76")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010C")]
	internal int GetPackingMode() { }

	[Address(RVA = "0x19404C0", Offset = "0x193F6C0", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012B")]
	private static int GetPackingMode_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x19405C0", Offset = "0x193F7C0", Length = "0x76")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010D")]
	internal int GetPackingRotation() { }

	[Address(RVA = "0x1940580", Offset = "0x193F780", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012C")]
	private static int GetPackingRotation_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940690", Offset = "0x193F890", Length = "0x8E")]
	[CalledBy(Type = typeof(DataUtility), Member = "GetPadding", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(Vector4))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000112")]
	internal Vector4 GetPadding() { }

	[Address(RVA = "0x1940640", Offset = "0x193F840", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000131")]
	private static void GetPadding_Injected(IntPtr _unity_self, out Vector4 ret) { }

	[Address(RVA = "0x1940760", Offset = "0x193F960", Length = "0x76")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "set_sprite", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite)}, ReturnType = typeof(void))]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "UnityEngine.SecondarySpriteTexture[]&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000118")]
	public int GetSecondaryTextureCount() { }

	[Address(RVA = "0x1940720", Offset = "0x193F920", Length = "0x33")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000137")]
	private static int GetSecondaryTextureCount_Injected(IntPtr _unity_self) { }

	[Address(RVA = "0x1940830", Offset = "0x193FA30", Length = "0xA7")]
	[CalledBy(Type = "UnityEngine.UI.Image", Member = "CheckSecondaryTexturesChanged", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(Sprite), "UnityEngine.SecondarySpriteTexture[]&"}, ReturnType = typeof(bool))]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object), typeof(string)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[FreeFunction("SpritesBindings::GetSecondaryTextures", ThrowsException = True, HasExplicitThis = True)]
	[Token(Token = "0x6000119")]
	public int GetSecondaryTextures(SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x19407E0", Offset = "0x193F9E0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x6000138")]
	private static int GetSecondaryTextures_Injected(IntPtr _unity_self, SecondarySpriteTexture[] secondaryTexture) { }

	[Address(RVA = "0x1940930", Offset = "0x193FB30", Length = "0x87")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(ThrowHelper), Member = "ThrowNullReferenceException", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(object)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010F")]
	internal Vector2 GetTextureRectOffset() { }

	[Address(RVA = "0x19408E0", Offset = "0x193FAE0", Length = "0x42")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEAB0")]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600012E")]
	private static void GetTextureRectOffset_Injected(IntPtr _unity_self, out Vector2 ret) { }

}

