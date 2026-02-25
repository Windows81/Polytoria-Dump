namespace SimpleFileBrowser;

[RequireComponent(typeof(CanvasRenderer))]
[Token(Token = "0x200001E")]
public class NonDrawingGraphic : Graphic
{

	[Address(RVA = "0x154F390", Offset = "0x154E590", Length = "0x49")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EE810")]
	[Calls(Type = typeof(CppNativeMethods), Member = "il2cpp_runtime_class_init")]
	[Calls(Type = typeof(Graphic), Member = ".ctor", ReturnType = typeof(void))]
	[Token(Token = "0x600010C")]
	public NonDrawingGraphic() { }

	[Address(RVA = "0x154F370", Offset = "0x154E570", Length = "0x1F")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VertexHelper), Member = "Clear", ReturnType = typeof(void))]
	[Calls(Type = typeof(CppNativeMethods), Member = "NativeMethod_0x1801EEA50")]
	[Token(Token = "0x600010B")]
	protected virtual void OnPopulateMesh(VertexHelper vh) { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x6000109")]
	public virtual void SetMaterialDirty() { }

	[Address(RVA = "0x2C3410", Offset = "0x2C2610", Length = "0x3")]
	[CallerCount(Count = 8626)]
	[DeduplicatedMethod]
	[Token(Token = "0x600010A")]
	public virtual void SetVerticesDirty() { }

}

