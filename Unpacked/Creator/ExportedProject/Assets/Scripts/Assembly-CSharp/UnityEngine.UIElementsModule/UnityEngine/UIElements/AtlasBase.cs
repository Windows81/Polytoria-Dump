namespace UnityEngine.UIElements;

[Token(Token = "0x2000005")]
internal abstract class AtlasBase
{
	[FieldOffset(Offset = "0x10")]
	[Token(Token = "0x4000001")]
	internal TextureRegistry textureRegistry; //Field offset: 0x10

	[Address(RVA = "0x1A92620", Offset = "0x1A91820", Length = "0x98")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801ED930")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Token(Token = "0x6000011")]
	protected AtlasBase() { }

	[Address(RVA = "0x1136070", Offset = "0x1135270", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000C")]
	internal void InvokeAssignedToPanel(IPanel panel) { }

	[Address(RVA = "0x166E740", Offset = "0x166D940", Length = "0x14")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000D")]
	internal void InvokeRemovedFromPanel(IPanel panel) { }

	[Address(RVA = "0x174A200", Offset = "0x1749400", Length = "0x14")]
	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000E")]
	internal void InvokeUpdateDynamicTextures(IPanel panel) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000009")]
	protected override void OnAssignedToPanel(IPanel panel) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000A")]
	protected override void OnRemovedFromPanel(IPanel panel) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600000B")]
	protected override void OnUpdateDynamicTextures(IPanel panel) { }

	[Address(RVA = "0x1A924C0", Offset = "0x1A916C0", Length = "0xC9")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(RenderTreeManager), Member = "RepaintTexturedElements", ReturnType = typeof(void))]
	[CallsUnknownMethods(Count = 1)]
	[Token(Token = "0x600000F")]
	protected static void RepaintTexturedElements(IPanel panel) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000008")]
	public override void Reset() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000007")]
	public override void ReturnAtlas(VisualElement ctx, Texture2D src, TextureId atlas) { }

	[Address(RVA = "0x1A92590", Offset = "0x1A91790", Length = "0x1E")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TextureRegistry), Member = "UpdateDynamic", MemberParameters = new IL2CPP_TYPE_OBJECT[] {typeof(TextureId), typeof(Texture)}, ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x6000010")]
	protected void SetDynamicTexture(TextureId id, Texture texture) { }

	[Address(RVA = "0x1A925B0", Offset = "0x1A917B0", Length = "0x62")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Token(Token = "0x6000006")]
	public override bool TryGetAtlas(VisualElement ctx, Texture2D src, out TextureId atlas, out RectInt atlasRect) { }

}

